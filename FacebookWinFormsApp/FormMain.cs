using System;
using System.Collections.Generic;
using System.Threading;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using LogicUnit;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private AppLogicSingleton m_LogicUnit = Singleton<AppLogicSingleton>.Instance;
        private LoginResult m_LoginResult;
        private FormComposerSpecificDate m_FormComposer;
        private int m_PostsSortStrategy = 0;

        public event Action m_StatusPosted;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            AppSettings.Instance.AutoLogin = this.checkBoxRememberMe.Checked;
            AppSettings.Instance.Save();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.checkBoxRememberMe.Checked = AppSettings.Instance.AutoLogin;
            if (AppSettings.Instance.AutoLogin)
            {
                m_LogicUnit.m_IsUserLogged = true;
                new Thread(this.autoLogin).Start();
            }

            m_StatusPosted += fetchFacebookUserMostActiveYear;
            m_StatusPosted += fetchFacebookUserPosts;
        }

        private void autoLogin()
        {
                try
                {
                    LoginResult result = FacebookService.Connect(AppSettings.Instance.AccessToken);
                    m_LogicUnit.m_LoggedInUser = result.LoggedInUser;
                    fetchFacebookInfo();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("#190"))
                    {
                        this.Invoke((Action)login);
                    }
                    else
                    {
                        this.Invoke(new Action(() => MessageBox.Show("Could not connect to Facebook server. Please try again later..")));
                    }
                } 
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");
            ////to handle a case where "login" is pressed if REMEMBER ME is already checked:
            if (m_LoginResult == null && !AppSettings.Instance.AutoLogin)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(              
                textBoxAppID.Text,
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_access_member_info");
            m_LogicUnit.m_LoggedInUser = m_LoginResult.LoggedInUser;
            m_LogicUnit.m_IsUserLogged = true;
            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                if(m_LoginResult.LoggedInUser == null)
                {
                    MessageBox.Show("Note: You need to login in order to proceed.");
                    m_LoginResult = null;
                }
                else 
                { 
                    buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    buttonLogin.BackColor = Color.LightGreen;
                    pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                    buttonLogin.Enabled = false;
                    buttonLogout.Enabled = true;
                    m_LogicUnit.m_LoggedInUser = m_LoginResult.LoggedInUser;
                    AppSettings.Instance.AccessToken = m_LoginResult.AccessToken;
                }
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            m_LogicUnit.m_IsUserLogged = false;
        }

        private void fetchFacebookInfo()
        {
            pictureBoxProfile.Load(m_LogicUnit.m_LoggedInUser.PictureNormalURL);
            buttonLogin.Invoke(new Action(() =>
                buttonLogin.Text = string.Format("Logged in as {0}", m_LogicUnit.m_LoggedInUser.Name)));
            new Thread(fetchFacebookUserAlbums).Start();
            new Thread(fetchFacebookUserBio).Start();
            new Thread(fetchFacebookUserEvents).Start();
            new Thread(fetchFacebookUserGroups).Start();
            new Thread(fetchFacebookUserLikedPages).Start();
            new Thread(fetchFacebookUserMostActiveYear).Start();
            new Thread(fetchFacebookUserPosts).Start();
            new Thread(fetchFacebookUserPostsBetweenDate).Start();
        }

        private void fetchFacebookUserPosts()
        {
            List<Post> posts;

            if (m_LogicUnit.m_IsUserLogged)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));
                posts = m_LogicUnit.FetchPosts(m_PostsSortStrategy);
                foreach (Post post in posts)
                {
                    if (post.Message != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                    }
                    else if (post.Caption != null)
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                    }
                    else
                    {
                        listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                    }
                }

                if (listBoxPosts.Items.Count == 0)
                {
                    MessageBox.Show("No Posts to retrieve :(");
                }
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            new Thread(fetchFacebookUserPosts).Start();
        }

        private void comboBoxStrategySort_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_PostsSortStrategy = comboBoxStrategySort.SelectedIndex;
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Post selected;
            
            try
            {
                selected = m_LogicUnit.m_LoggedInUser.Posts[listBoxPosts.SelectedIndex];
                listBoxPostsComments.DisplayMember = "Message";
                listBoxPostsComments.DataSource = selected.Comments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch comments at the moment :(");
            }
        }

        private void fetchFacebookUserGroups()
        {
            FacebookObjectCollection<Group> userGroups;
            
            if (m_LogicUnit.m_IsUserLogged)
            {
                listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Clear()));
                listBoxGroups.Invoke(new Action(() => listBoxGroups.DisplayMember = "Name"));
                userGroups = m_LogicUnit.FetchGroups();
                try
                {
                    foreach (Group group in userGroups)
                    {
                        listBoxGroups.Invoke(new Action(() => listBoxGroups.Items.Add(group)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxGroups.Items.Count == 0)
                {
                    MessageBox.Show("No groups to retrieve :(");
                }
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
          new Thread(fetchFacebookUserGroups).Start();
        }

        private void fetchFacebookUserLikedPages()
        {
            List<Page> userLikedPages;
            
            if (m_LogicUnit.m_IsUserLogged)
            {
                listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Clear()));
                listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.DisplayMember = "Name"));
                userLikedPages = m_LogicUnit.FetchLikedPages();
                try
                {
                    foreach (Page page in userLikedPages)
                    {
                        listBoxLikedPages.Invoke(new Action(() => listBoxLikedPages.Items.Add(page)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxLikedPages.Items.Count == 0)
                {
                    MessageBox.Show("No pages to retrieve :(");
                }
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            new Thread(fetchFacebookUserLikedPages).Start();
        }

        private void listBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selectedPage;

            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                selectedPage = listBoxLikedPages.SelectedItem as Page;
                pictureBoxLikedPages.LoadAsync(selectedPage.PictureNormalURL);
            }
        }

        private void fetchFacebookUserBio()
        {
            IUserBio facebookUserBio = new AdapterUserBio();
            List<object> userBio = new List<object>();

            try
            {
                if (m_LogicUnit.m_IsUserLogged)
                {
                    listBoxBio.Invoke(new Action(() => listBoxBio.Items.Clear()));
                    (facebookUserBio as AdapterUserBio).GetUserBio(userBio);
                    foreach (object bioItem in userBio)
                    {
                        listBoxBio.Invoke(new Action(() => listBoxBio.Items.Add(bioItem)));
                    }
                }
                else
                {
                    MessageBox.Show("Please login first!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to fetch bio at the moment :(");
            }
        }

        private void buttonBio_Click(object sender, EventArgs e)
        {
            new Thread(fetchFacebookUserBio).Start();
        }

        private void buttonPublishPost_Click(object sender, EventArgs e)
        {
            Status postedStatus;
 
            if (m_LogicUnit.m_IsUserLogged)
            {
                try
                {
                    postedStatus = m_LogicUnit.m_LoggedInUser.PostStatus(textBoxStatus.Text);
                    MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
                    m_StatusPosted.Invoke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Currently this feature isn't permitted.");                  
                }
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }

        private void fetchFacebookUserEvents()
        {
            List<Event> userEvents;

            if (m_LogicUnit.m_IsUserLogged)
            {
                listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Clear()));
                listBoxEvents.Invoke(new Action(() => listBoxEvents.DisplayMember = "Name"));
                userEvents = m_LogicUnit.FetchEvents();
                try
                {
                    foreach (Event userEvent in userEvents)
                    {
                        listBoxEvents.Invoke(new Action(() => listBoxEvents.Items.Add(userEvent)));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                if (listBoxEvents.Items.Count == 0)
                {
                    MessageBox.Show("No events to retrieve :(");
                }
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            new Thread(fetchFacebookUserEvents).Start();
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            Event selectedEvent;

            if (listBoxEvents.SelectedItems.Count == 1)
            {
                selectedEvent = listBoxEvents.SelectedItem as Event;
                if (selectedEvent.PictureNormalURL != null)
                {
                    pictureBoxEventsPictures.LoadAsync(selectedEvent.PictureNormalURL);
                }
                else
                {
                    pictureBoxEventsPictures.Image = pictureBoxEventsPictures.ErrorImage;
                }
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            Group selectedGroup;

            if (listBoxGroups.SelectedItems.Count == 1)
            {
                selectedGroup = listBoxGroups.SelectedItem as Group;
                if (selectedGroup.PictureNormalURL != null)
                {
                    pictureBoxGroupsPictures.LoadAsync(selectedGroup.PictureNormalURL);
                }
                else
                {
                    pictureBoxGroupsPictures.Image = pictureBoxGroupsPictures.ErrorImage;
                }
            }
        }

        private void fetchFacebookUserAlbums()
        {
            if (!listBoxAlbums.InvokeRequired)
            {
                albumBindingSource.DataSource = m_LogicUnit.m_LoggedInUser.Albums;
            }
            else
            {
                listBoxAlbums.Invoke(new Action(() => albumBindingSource.DataSource = m_LogicUnit.m_LoggedInUser.Albums));
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            new Thread(fetchFacebookUserAlbums).Start();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album selectedAlbum;

            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    pictureBoxAlbumsPictures.LoadAsync(selectedAlbum.PictureAlbumURL);
                }
                else
                {
                    pictureBoxAlbumsPictures.Image = pictureBoxAlbumsPictures.ErrorImage;
                }
            }
        }

        private void fetchFacebookUserMostActiveYear()
        {
            List<int> activeYears;

            if (m_LogicUnit.m_IsUserLogged)
            {
                listBoxMostActiveYear.Invoke(new Action(() => listBoxMostActiveYear.Items.Clear()));              
                activeYears = m_LogicUnit.FetchUserMostActiveYears();
                try
                {
                    foreach (int year in activeYears)
                    {
                        listBoxMostActiveYear.Invoke(new Action(() => listBoxMostActiveYear.Items.Add(year)));                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("You got no active Years :(");
                }
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }

        private void buttonMostActiveYear_Click(object sender, EventArgs e)
        {
            new Thread(fetchFacebookUserMostActiveYear).Start();
        }

        private void fetchFacebookUserPostsBetweenDate()
        {
            List<Post> posts;
            DateTime startDate = dateTimePickerFromDate.Value.Date;
            DateTime endDate = dateTimePickerUpDate.Value.Date;

            if (m_LogicUnit.m_IsUserLogged)
            {
                if (startDate <= endDate)
                {
                    listBoxPostsBetweenDates.Invoke(new Action(() => listBoxPostsBetweenDates.Items.Clear()));
                    posts = m_LogicUnit.FetchPostsBetweenDates(startDate, endDate);
                    try
                    {
                        foreach (Post post in posts)
                        {
                            listBoxPostsBetweenDates.Invoke(new Action(() => listBoxPostsBetweenDates.Items.Add(post)));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (listBoxPostsBetweenDates.Items.Count == 0)
                    {
                        MessageBox.Show("No posts between this range.");
                    }
                }
                else
                {
                    listBoxPostsBetweenDates.Invoke(new Action(() => listBoxPostsBetweenDates.Items.Clear()));
                    MessageBox.Show("Invalid dates range!");
                }
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }

        private void buttonShowPostsBetweenDates_Click(object sender, EventArgs e)
        {
            new Thread(fetchFacebookUserPostsBetweenDate).Start();
        }

        private void buttonSpecificDate_Click(object sender, EventArgs e)
        {
            if (m_LogicUnit.m_IsUserLogged)
            {
                panelSpecificDate.Controls.Clear();
                m_FormComposer = new FormComposerSpecificDate();
                m_FormComposer.SetUserInfo(panelSpecificDate);
                m_FormComposer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please login first!");
            }
        }
    }
}