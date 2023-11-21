namespace BasicFacebookFeatures
{
   public partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxStrategySort = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.albumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.F = new System.Windows.Forms.Label();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.listBoxBio = new System.Windows.Forms.ListBox();
            this.buttonBio = new System.Windows.Forms.Button();
            this.pictureBoxAlbumsPictures = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.buttonAlbums = new System.Windows.Forms.Button();
            this.pictureBoxEventsPictures = new System.Windows.Forms.PictureBox();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.buttonEvents = new System.Windows.Forms.Button();
            this.pictureBoxGroupsPictures = new System.Windows.Forms.PictureBox();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.listBoxPostsComments = new System.Windows.Forms.ListBox();
            this.buttonPosts = new System.Windows.Forms.Button();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.buttonPublishPost = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSpecificDate = new System.Windows.Forms.Panel();
            this.buttonSpecificDate = new System.Windows.Forms.Button();
            this.listBoxMostActiveYear = new System.Windows.Forms.ListBox();
            this.SpecialFeatures = new System.Windows.Forms.Label();
            this.buttonMostActiveYear = new System.Windows.Forms.Button();
            this.listBoxPostsBetweenDates = new System.Windows.Forms.ListBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelFromDate = new System.Windows.Forms.Label();
            this.dateTimePickerUpDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.buttonShowPostsBetweenDates = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsPictures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(21, 38);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(70, 24);
            nameLabel.TabIndex = 79;
            nameLabel.Text = "Album:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonLogin.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 53;
            this.label1.Text = "Enter App ID:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1427, 807);
            this.tabControl1.TabIndex = 54;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Azure;
            this.tabPage1.Controls.Add(this.comboBoxStrategySort);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.checkBoxRememberMe);
            this.tabPage1.Controls.Add(this.F);
            this.tabPage1.Controls.Add(this.pictureBoxLikedPages);
            this.tabPage1.Controls.Add(this.listBoxLikedPages);
            this.tabPage1.Controls.Add(this.buttonLikedPages);
            this.tabPage1.Controls.Add(this.listBoxBio);
            this.tabPage1.Controls.Add(this.buttonBio);
            this.tabPage1.Controls.Add(this.pictureBoxAlbumsPictures);
            this.tabPage1.Controls.Add(this.listBoxAlbums);
            this.tabPage1.Controls.Add(this.buttonAlbums);
            this.tabPage1.Controls.Add(this.pictureBoxEventsPictures);
            this.tabPage1.Controls.Add(this.listBoxEvents);
            this.tabPage1.Controls.Add(this.buttonEvents);
            this.tabPage1.Controls.Add(this.pictureBoxGroupsPictures);
            this.tabPage1.Controls.Add(this.listBoxGroups);
            this.tabPage1.Controls.Add(this.buttonGroups);
            this.tabPage1.Controls.Add(this.listBoxPostsComments);
            this.tabPage1.Controls.Add(this.buttonPosts);
            this.tabPage1.Controls.Add(this.listBoxPosts);
            this.tabPage1.Controls.Add(this.buttonPublishPost);
            this.tabPage1.Controls.Add(this.textBoxStatus);
            this.tabPage1.Controls.Add(this.labelStatus);
            this.tabPage1.Controls.Add(this.pictureBoxProfile);
            this.tabPage1.Controls.Add(this.textBoxAppID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1419, 772);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Basic Features";
            // 
            // comboBoxStrategySort
            // 
            this.comboBoxStrategySort.FormattingEnabled = true;
            this.comboBoxStrategySort.Items.AddRange(new object[] {
            "Sort: Newst to Oldest",
            "Sort: Oldest to Newest"});
            this.comboBoxStrategySort.Location = new System.Drawing.Point(8, 325);
            this.comboBoxStrategySort.Name = "comboBoxStrategySort";
            this.comboBoxStrategySort.Size = new System.Drawing.Size(157, 30);
            this.comboBoxStrategySort.TabIndex = 81;
            this.comboBoxStrategySort.SelectedIndexChanged += new System.EventHandler(this.comboBoxStrategySort_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(994, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 92);
            this.panel1.TabIndex = 79;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(115, 40);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 28);
            this.nameTextBox.TabIndex = 80;
            // 
            // albumBindingSource
            // 
            this.albumBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Album);
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(213, 148);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(153, 26);
            this.checkBoxRememberMe.TabIndex = 78;
            this.checkBoxRememberMe.Text = "Remember Me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F.Location = new System.Drawing.Point(809, 57);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(278, 60);
            this.F.TabIndex = 77;
            this.F.Text = "Facebook";
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBoxLikedPages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(1126, 506);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(100, 114);
            this.pictureBoxLikedPages.TabIndex = 76;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 22;
            this.listBoxLikedPages.Location = new System.Drawing.Point(792, 506);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(434, 114);
            this.listBoxLikedPages.TabIndex = 75;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxPages_SelectedIndexChanged);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonLikedPages.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLikedPages.Location = new System.Drawing.Point(620, 506);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(166, 58);
            this.buttonLikedPages.TabIndex = 74;
            this.buttonLikedPages.Text = "Show Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = false;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonLikedPages_Click);
            // 
            // listBoxBio
            // 
            this.listBoxBio.FormattingEnabled = true;
            this.listBoxBio.ItemHeight = 22;
            this.listBoxBio.Location = new System.Drawing.Point(792, 376);
            this.listBoxBio.Name = "listBoxBio";
            this.listBoxBio.Size = new System.Drawing.Size(434, 114);
            this.listBoxBio.TabIndex = 73;
            // 
            // buttonBio
            // 
            this.buttonBio.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonBio.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBio.Location = new System.Drawing.Point(620, 376);
            this.buttonBio.Name = "buttonBio";
            this.buttonBio.Size = new System.Drawing.Size(166, 59);
            this.buttonBio.TabIndex = 72;
            this.buttonBio.Text = "Show My Bio";
            this.buttonBio.UseVisualStyleBackColor = false;
            this.buttonBio.Click += new System.EventHandler(this.buttonBio_Click);
            // 
            // pictureBoxAlbumsPictures
            // 
            this.pictureBoxAlbumsPictures.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBoxAlbumsPictures.Location = new System.Drawing.Point(1126, 241);
            this.pictureBoxAlbumsPictures.Name = "pictureBoxAlbumsPictures";
            this.pictureBoxAlbumsPictures.Size = new System.Drawing.Size(100, 114);
            this.pictureBoxAlbumsPictures.TabIndex = 71;
            this.pictureBoxAlbumsPictures.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.DataSource = this.albumBindingSource;
            this.listBoxAlbums.DisplayMember = "Name";
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 22;
            this.listBoxAlbums.Location = new System.Drawing.Point(792, 241);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(434, 114);
            this.listBoxAlbums.TabIndex = 70;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // buttonAlbums
            // 
            this.buttonAlbums.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonAlbums.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlbums.Location = new System.Drawing.Point(620, 241);
            this.buttonAlbums.Name = "buttonAlbums";
            this.buttonAlbums.Size = new System.Drawing.Size(166, 59);
            this.buttonAlbums.TabIndex = 69;
            this.buttonAlbums.Text = "Show My Albums";
            this.buttonAlbums.UseVisualStyleBackColor = false;
            this.buttonAlbums.Click += new System.EventHandler(this.buttonAlbums_Click);
            // 
            // pictureBoxEventsPictures
            // 
            this.pictureBoxEventsPictures.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBoxEventsPictures.Location = new System.Drawing.Point(1126, 640);
            this.pictureBoxEventsPictures.Name = "pictureBoxEventsPictures";
            this.pictureBoxEventsPictures.Size = new System.Drawing.Size(100, 114);
            this.pictureBoxEventsPictures.TabIndex = 68;
            this.pictureBoxEventsPictures.TabStop = false;
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.ItemHeight = 22;
            this.listBoxEvents.Location = new System.Drawing.Point(792, 640);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(434, 114);
            this.listBoxEvents.TabIndex = 67;
            this.listBoxEvents.SelectedIndexChanged += new System.EventHandler(this.listBoxEvents_SelectedIndexChanged);
            // 
            // buttonEvents
            // 
            this.buttonEvents.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonEvents.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEvents.Location = new System.Drawing.Point(620, 640);
            this.buttonEvents.Name = "buttonEvents";
            this.buttonEvents.Size = new System.Drawing.Size(166, 54);
            this.buttonEvents.TabIndex = 66;
            this.buttonEvents.Text = "Show My Events";
            this.buttonEvents.UseVisualStyleBackColor = false;
            this.buttonEvents.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // pictureBoxGroupsPictures
            // 
            this.pictureBoxGroupsPictures.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBoxGroupsPictures.Location = new System.Drawing.Point(514, 487);
            this.pictureBoxGroupsPictures.Name = "pictureBoxGroupsPictures";
            this.pictureBoxGroupsPictures.Size = new System.Drawing.Size(100, 114);
            this.pictureBoxGroupsPictures.TabIndex = 65;
            this.pictureBoxGroupsPictures.TabStop = false;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 22;
            this.listBoxGroups.Location = new System.Drawing.Point(180, 487);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(434, 114);
            this.listBoxGroups.TabIndex = 64;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // buttonGroups
            // 
            this.buttonGroups.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonGroups.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGroups.Location = new System.Drawing.Point(8, 487);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(166, 59);
            this.buttonGroups.TabIndex = 63;
            this.buttonGroups.Text = "Show My Groups";
            this.buttonGroups.UseVisualStyleBackColor = false;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // listBoxPostsComments
            // 
            this.listBoxPostsComments.FormattingEnabled = true;
            this.listBoxPostsComments.ItemHeight = 22;
            this.listBoxPostsComments.Location = new System.Drawing.Point(484, 285);
            this.listBoxPostsComments.Name = "listBoxPostsComments";
            this.listBoxPostsComments.Size = new System.Drawing.Size(130, 70);
            this.listBoxPostsComments.TabIndex = 62;
            // 
            // buttonPosts
            // 
            this.buttonPosts.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonPosts.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPosts.Location = new System.Drawing.Point(8, 241);
            this.buttonPosts.Name = "buttonPosts";
            this.buttonPosts.Size = new System.Drawing.Size(166, 59);
            this.buttonPosts.TabIndex = 61;
            this.buttonPosts.Text = "Show My Posts";
            this.buttonPosts.UseVisualStyleBackColor = false;
            this.buttonPosts.Click += new System.EventHandler(this.buttonPosts_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.BackColor = System.Drawing.Color.White;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 22;
            this.listBoxPosts.Location = new System.Drawing.Point(180, 241);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(434, 114);
            this.listBoxPosts.TabIndex = 60;
            this.listBoxPosts.SelectedIndexChanged += new System.EventHandler(this.listBoxPosts_SelectedIndexChanged);
            // 
            // buttonPublishPost
            // 
            this.buttonPublishPost.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonPublishPost.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPublishPost.Location = new System.Drawing.Point(388, 196);
            this.buttonPublishPost.Name = "buttonPublishPost";
            this.buttonPublishPost.Size = new System.Drawing.Size(141, 27);
            this.buttonPublishPost.TabIndex = 58;
            this.buttonPublishPost.Text = "Post";
            this.buttonPublishPost.UseVisualStyleBackColor = false;
            this.buttonPublishPost.Click += new System.EventHandler(this.buttonPublishPost_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.BackColor = System.Drawing.Color.White;
            this.textBoxStatus.Location = new System.Drawing.Point(128, 195);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(238, 28);
            this.textBoxStatus.TabIndex = 57;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Lucida Sans Typewriter", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(14, 195);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(112, 16);
            this.labelStatus.TabIndex = 56;
            this.labelStatus.Text = "Write Status:";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(100, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.BackColor = System.Drawing.Color.White;
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 28);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "312231804497926";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Azure;
            this.tabPage2.Controls.Add(this.panelSpecificDate);
            this.tabPage2.Controls.Add(this.buttonSpecificDate);
            this.tabPage2.Controls.Add(this.listBoxMostActiveYear);
            this.tabPage2.Controls.Add(this.SpecialFeatures);
            this.tabPage2.Controls.Add(this.buttonMostActiveYear);
            this.tabPage2.Controls.Add(this.listBoxPostsBetweenDates);
            this.tabPage2.Controls.Add(this.labelUpdate);
            this.tabPage2.Controls.Add(this.labelFromDate);
            this.tabPage2.Controls.Add(this.dateTimePickerUpDate);
            this.tabPage2.Controls.Add(this.dateTimePickerFromDate);
            this.tabPage2.Controls.Add(this.buttonShowPostsBetweenDates);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1419, 772);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Special Features";
            // 
            // panelSpecificDate
            // 
            this.panelSpecificDate.BackColor = System.Drawing.Color.LightBlue;
            this.panelSpecificDate.Location = new System.Drawing.Point(998, 200);
            this.panelSpecificDate.Name = "panelSpecificDate";
            this.panelSpecificDate.Size = new System.Drawing.Size(269, 323);
            this.panelSpecificDate.TabIndex = 13;
            // 
            // buttonSpecificDate
            // 
            this.buttonSpecificDate.BackColor = System.Drawing.Color.LightBlue;
            this.buttonSpecificDate.Location = new System.Drawing.Point(1063, 75);
            this.buttonSpecificDate.Name = "buttonSpecificDate";
            this.buttonSpecificDate.Size = new System.Drawing.Size(148, 87);
            this.buttonSpecificDate.TabIndex = 12;
            this.buttonSpecificDate.Text = "Show My Activities On A Specific Date";
            this.buttonSpecificDate.UseVisualStyleBackColor = false;
            this.buttonSpecificDate.Click += new System.EventHandler(this.buttonSpecificDate_Click);
            // 
            // listBoxMostActiveYear
            // 
            this.listBoxMostActiveYear.FormattingEnabled = true;
            this.listBoxMostActiveYear.ItemHeight = 22;
            this.listBoxMostActiveYear.Location = new System.Drawing.Point(200, 463);
            this.listBoxMostActiveYear.Name = "listBoxMostActiveYear";
            this.listBoxMostActiveYear.Size = new System.Drawing.Size(688, 180);
            this.listBoxMostActiveYear.TabIndex = 11;
            // 
            // SpecialFeatures
            // 
            this.SpecialFeatures.AutoSize = true;
            this.SpecialFeatures.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecialFeatures.Location = new System.Drawing.Point(461, 40);
            this.SpecialFeatures.Name = "SpecialFeatures";
            this.SpecialFeatures.Size = new System.Drawing.Size(241, 22);
            this.SpecialFeatures.TabIndex = 10;
            this.SpecialFeatures.Text = "Our Special Features:";
            // 
            // buttonMostActiveYear
            // 
            this.buttonMostActiveYear.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonMostActiveYear.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostActiveYear.Location = new System.Drawing.Point(18, 395);
            this.buttonMostActiveYear.Name = "buttonMostActiveYear";
            this.buttonMostActiveYear.Size = new System.Drawing.Size(151, 144);
            this.buttonMostActiveYear.TabIndex = 6;
            this.buttonMostActiveYear.Text = "Show My Most Active Year";
            this.buttonMostActiveYear.UseVisualStyleBackColor = false;
            this.buttonMostActiveYear.Click += new System.EventHandler(this.buttonMostActiveYear_Click);
            // 
            // listBoxPostsBetweenDates
            // 
            this.listBoxPostsBetweenDates.FormattingEnabled = true;
            this.listBoxPostsBetweenDates.ItemHeight = 22;
            this.listBoxPostsBetweenDates.Location = new System.Drawing.Point(200, 166);
            this.listBoxPostsBetweenDates.Name = "listBoxPostsBetweenDates";
            this.listBoxPostsBetweenDates.Size = new System.Drawing.Size(688, 180);
            this.listBoxPostsBetweenDates.TabIndex = 5;
            // 
            // labelUpdate
            // 
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpdate.Location = new System.Drawing.Point(563, 123);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(98, 22);
            this.labelUpdate.TabIndex = 4;
            this.labelUpdate.Text = "To Date:";
            // 
            // labelFromDate
            // 
            this.labelFromDate.AutoSize = true;
            this.labelFromDate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFromDate.Location = new System.Drawing.Point(196, 118);
            this.labelFromDate.Name = "labelFromDate";
            this.labelFromDate.Size = new System.Drawing.Size(120, 22);
            this.labelFromDate.TabIndex = 3;
            this.labelFromDate.Text = "From Date:";
            // 
            // dateTimePickerUpDate
            // 
            this.dateTimePickerUpDate.Location = new System.Drawing.Point(667, 118);
            this.dateTimePickerUpDate.Name = "dateTimePickerUpDate";
            this.dateTimePickerUpDate.Size = new System.Drawing.Size(221, 28);
            this.dateTimePickerUpDate.TabIndex = 2;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(322, 118);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(217, 28);
            this.dateTimePickerFromDate.TabIndex = 1;
            // 
            // buttonShowPostsBetweenDates
            // 
            this.buttonShowPostsBetweenDates.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonShowPostsBetweenDates.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowPostsBetweenDates.Location = new System.Drawing.Point(8, 118);
            this.buttonShowPostsBetweenDates.Name = "buttonShowPostsBetweenDates";
            this.buttonShowPostsBetweenDates.Size = new System.Drawing.Size(147, 74);
            this.buttonShowPostsBetweenDates.TabIndex = 0;
            this.buttonShowPostsBetweenDates.Text = "Show Posts Between Dates";
            this.buttonShowPostsBetweenDates.UseVisualStyleBackColor = false;
            this.buttonShowPostsBetweenDates.Click += new System.EventHandler(this.buttonShowPostsBetweenDates_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 807);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Our Facebook App";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.albumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbumsPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEventsPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGroupsPictures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonPublishPost;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.PictureBox pictureBoxEventsPictures;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Button buttonEvents;
        private System.Windows.Forms.PictureBox pictureBoxGroupsPictures;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.ListBox listBoxPostsComments;
        private System.Windows.Forms.Button buttonPosts;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.ListBox listBoxAlbums;
        private System.Windows.Forms.Button buttonAlbums;
        private System.Windows.Forms.PictureBox pictureBoxAlbumsPictures;
        private System.Windows.Forms.Button buttonBio;
        private System.Windows.Forms.PictureBox pictureBoxLikedPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.ListBox listBoxBio;
        private System.Windows.Forms.Button buttonMostActiveYear;
        private System.Windows.Forms.ListBox listBoxPostsBetweenDates;
        private System.Windows.Forms.Label labelUpdate;
        private System.Windows.Forms.Label labelFromDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerUpDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Button buttonShowPostsBetweenDates;
        private System.Windows.Forms.Label SpecialFeatures;
        private System.Windows.Forms.ListBox listBoxMostActiveYear;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource albumBindingSource;
        private System.Windows.Forms.Button buttonSpecificDate;
        private System.Windows.Forms.Panel panelSpecificDate;
        private System.Windows.Forms.ComboBox comboBoxStrategySort;
    }
}