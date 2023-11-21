using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicUnit;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
     partial class FormComposerSpecificDate : Form
    {
        public BuilderSpecificDate m_Builder = new BuilderSpecificDate();
        private bool m_ShowAlbums;
        private bool m_ShowPosts;
        private Panel m_PanelSpecificDate;

        public FormComposerSpecificDate()
        {
            m_ShowAlbums = false;
            m_ShowPosts = false;
            InitializeComponent();
        }

        private void buttonSpecificDate_Click(object sender, EventArgs e)
        {
            m_Builder.GetSpecificActivities(m_ShowAlbums, m_ShowPosts, m_PanelSpecificDate, dateTimePickerDesired.Value.Date);
            Close();
        }

        private void checkBoxCreatedAlbums_CheckedChanged(object sender, EventArgs e)
        {
            m_ShowAlbums = checkBoxCreatedAlbums.Checked;
        }

        private void checkBoxCreatedPosts_CheckedChanged(object sender, EventArgs e)
        {
            m_ShowPosts = checkBoxCreatedPosts.Checked;
        }

        public void SetUserInfo(Panel o_PanelSpecificDate)
        {            
            m_PanelSpecificDate = o_PanelSpecificDate;
        }
    }
}