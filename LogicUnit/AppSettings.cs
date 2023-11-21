using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;
using System.Reflection;

namespace LogicUnit
{
    public class AppSettings
    {
        private static readonly string sr_FileName;
        private static AppSettings s_This;

        public static AppSettings Instance
        {
            get
            {
                if (s_This == null)
                {
                    s_This = AppSettings.FromFileOrDefault();
                }

                return s_This;
            }
        }

        public bool AutoLogin { get; set; }

        public string AccessToken { get; set; }

        static AppSettings()
        {
            sr_FileName = Application.ExecutablePath + ".settings.xml";
        }

        public static AppSettings FromFileOrDefault()
        {
            AppSettings loadedThis = null;

            if (File.Exists(sr_FileName))
            {
                using (FileStream stream = new FileStream(sr_FileName, FileMode.OpenOrCreate))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    loadedThis = (AppSettings)serializer.Deserialize(stream);
                }
            }
            else
            {
                loadedThis = new AppSettings()
                {
                    AutoLogin = false
                };
            }

            return loadedThis;
        }

        public AppSettings()
        {
        }

        public void Save()
        {
            using (FileStream stream = new FileStream(sr_FileName, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                serializer.Serialize(stream, this);
            }
        }
    }
}