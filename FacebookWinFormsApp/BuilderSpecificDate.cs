using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using LogicUnit;

namespace BasicFacebookFeatures
{
    public class BuilderSpecificDate
    {
        private AppLogicSingleton m_LogicUnit = Singleton<AppLogicSingleton>.Instance;

        public void GetSpecificActivities(bool i_ShowAlbums, bool i_ShowPosts, Panel o_PanelSpecificDate, DateTime i_SpecificDate)
        {
            ListBox listBoxDesiredAlbums = new ListBox();
            ListBox listBoxDesiredPosts = new ListBox();
            Label labelDesiredAlbums = new Label();
            Label labelDesiredPosts = new Label();
            List<Album> albums = m_LogicUnit.FetchAlbumsCreatedSpecificDate(i_SpecificDate);
            List<Post> posts = m_LogicUnit.FetchPostsBetweenDates(i_SpecificDate, i_SpecificDate);
            Point panelLocation = o_PanelSpecificDate.Location;

            labelDesiredAlbums.Text = "Albums:";
            labelDesiredPosts.Text = "Posts:";
            listBoxDesiredAlbums.DisplayMember = "Name";
            foreach (Album album in albums)
            {
                listBoxDesiredAlbums.Items.Add(album);
            }

            foreach (Post post in posts)
            {
                listBoxDesiredPosts.Items.Add(post);
            }

            o_PanelSpecificDate.Controls.Add(labelDesiredAlbums);
            o_PanelSpecificDate.Controls.Add(listBoxDesiredAlbums);
            o_PanelSpecificDate.Controls.Add(labelDesiredPosts);
            o_PanelSpecificDate.Controls.Add(listBoxDesiredPosts);
            listBoxDesiredAlbums.Location = new Point(listBoxDesiredAlbums.Location.X, labelDesiredAlbums.Location.Y + 40);
            labelDesiredPosts.Location = new Point(labelDesiredPosts.Location.X, listBoxDesiredAlbums.Location.Y + 100);
            listBoxDesiredPosts.Location = new Point(listBoxDesiredPosts.Location.X, labelDesiredPosts.Location.Y + 40); 
        }
    }
}