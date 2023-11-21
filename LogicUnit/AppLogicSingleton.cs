using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace LogicUnit
{
        public sealed class AppLogicSingleton : IEnumerable
    {
        public static AppLogicSingleton Instance
        {
            get { return NestedHolder.instance; }
        }

        public DateTime m_StartDatePostBetweenDates { get; set; }

        public DateTime m_EndDatePostBetweenDates { get; set; }

        public PostsSorter m_PostsSorter { get; set; }

        public LoginResult m_LoginResult { get; set; }

        public User m_LoggedInUser { get; set; }

        public bool m_IsUserLogged { get; set; }

        public const int k_NewToOldSort = 0;

        private AppLogicSingleton() 
        { 
        }
       
        internal class NestedHolder
        {
            internal static volatile AppLogicSingleton instance = new AppLogicSingleton();
        }

        public FacebookObjectCollection<Group> FetchGroups()
        {
            FacebookObjectCollection<Group> groups = new FacebookObjectCollection<Group>();

            try
            {
                groups = m_LoggedInUser.Groups;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch groups at the moment :(");
            }

            return groups;
        }

        public List<Page> FetchLikedPages()
        {
            List<Page> pages = new List<Page>();

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    pages.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch pages at the moment :(");
            }

            return pages;
        }

        public List<Album> FetchAlbums()
        {
            List<Album> albums = new List<Album>();

            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    albums.Add(album);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch albums at the moment :(");
            }

            return albums;
        }

        public List<Event> FetchEvents()
        {
            List<Event> events = new List<Event>();

            try
            {
                foreach (Event singleEvent in m_LoggedInUser.Events)
                {
                    events.Add(singleEvent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch events at the moment :(");
            }

            return events;
        }

        public List<Post> FetchPosts(int i_PostsSortStrategy)
        {
            List<Post> posts = new List<Post>();
          
            try
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    posts.Add(post);
                }

                if (i_PostsSortStrategy == k_NewToOldSort)
                {
                    m_PostsSorter = new PostsSorter(new NewToOldComparer());
                }
                else
                {
                    m_PostsSorter = new PostsSorter(new OldToNewComparer());
                }

                m_PostsSorter.Sort(posts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch posts at the moment :(");
            }

            return posts;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return new RangeDatesIterator(m_StartDatePostBetweenDates, m_EndDatePostBetweenDates, this);
        }

        private class RangeDatesIterator : IEnumerator
        {   
            private int m_CurrentIdx = -1;
            private int m_Count = -1;
            private AppLogicSingleton m_Collection;
            private DateTime m_StartDatePostBetweenDates;
            private DateTime m_EndDatePostBetweenDates;

            public RangeDatesIterator(DateTime i_StartDate, DateTime i_EndDate, AppLogicSingleton i_Collection)
            {
                m_Collection = i_Collection;
                m_StartDatePostBetweenDates = i_StartDate;
                m_EndDatePostBetweenDates = i_EndDate;
                m_Count = m_Collection.m_LoggedInUser.Posts.Count;
            }

            public object Current
            {
                get
                {

                    return m_Collection.m_LoggedInUser.Posts[m_CurrentIdx];
                }
            }

            public bool MoveNext()
            {
                ++m_CurrentIdx;

                return m_CurrentIdx < m_Collection.m_LoggedInUser.Posts.Count;
            }

            public void Reset()
            {
                m_CurrentIdx = 0;
            }
        }

        public List<Post> FetchPostsBetweenDates(DateTime i_StartDate, DateTime i_EndDate)
        {
            List<Post> posts = new List<Post>();

            m_StartDatePostBetweenDates = i_StartDate;
            m_EndDatePostBetweenDates = i_EndDate;
            try
            {
                for (IEnumerator it = (this as IEnumerable).GetEnumerator();
                     it.MoveNext();)
                {
                    if ((it.Current as Post) != null)
                    {
                        if ((it.Current as Post).CreatedTime.Value.Date >= i_StartDate.Date &&
                           (it.Current as Post).CreatedTime.Value.Date <= i_EndDate.Date)
                        {
                            posts.Add(it.Current as Post);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch posts at the moment :(");
            }

            return posts;
        }

        public void FetchActiveYears(Dictionary<int, int> io_ActiveYears)
        {
            int year;
            ////By default, sort from newest to oldest post:
            List<Post> posts = FetchPosts(k_NewToOldSort);

            try
            {
                foreach (Post post in posts)
                {
                    year = post.CreatedTime.Value.Year;
                    if (io_ActiveYears.ContainsKey(year))
                    {
                        io_ActiveYears[year]++;
                    }
                    else
                    {
                        io_ActiveYears.Add(year, 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch active year at the moment :(");
            }
        }

        public List<int> FetchUserMostActiveYears()
        {
            Dictionary<int, int> activeYears = new Dictionary<int, int>();
            List<int> yearsWithMaxValue = new List<int>();
            int maxPostsInYears = 0;

            FetchActiveYears(activeYears);
            if (activeYears != null)
            {
                maxPostsInYears = activeYears.Values.Max();
                foreach (var pair in activeYears)
                {
                    if (pair.Value == maxPostsInYears)
                    {
                        yearsWithMaxValue.Add(pair.Key);
                    }
                }
            }
            else
            {
                MessageBox.Show("No active year/s :(");
            }

            return yearsWithMaxValue;
        }

        public List<Album> FetchAlbumsCreatedSpecificDate(DateTime i_SpecificDate)
        {
            List<Album> albums = new List<Album>();

            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    if (album.CreatedTime.Value.Date == i_SpecificDate.Date)
                    {
                        albums.Add(album);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch albums at the moment :(");
            }

            return albums;
        }
    }
}