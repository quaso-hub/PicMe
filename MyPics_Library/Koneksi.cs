using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyPics_Library
{
    public class Koneksi
    {
        private MySqlConnection myPicsConnect;

        public MySqlConnection MyPicsConnect { get => myPicsConnect; set => myPicsConnect = value; }

        public void Connect()
        {
            if (myPicsConnect.State == System.Data.ConnectionState.Open)
            {
                myPicsConnect.Close();
            }
            myPicsConnect.Open();
        }

        public Koneksi()
        {
            Configuration myConf = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            ConfigurationSectionGroup userSetting = myConf.SectionGroups["userSettings"];
            var settingSection = userSetting.Sections["FormApps.kuis"] as ClientSettingsSection;
            string vServer = settingSection.Settings.Get("dbServer").Value.ValueXml.InnerText;
            string vDb = settingSection.Settings.Get("dbName").Value.ValueXml.InnerText;
            string vUID = settingSection.Settings.Get("dbUID").Value.ValueXml.InnerText;
            string vPWD = settingSection.Settings.Get("dbPWD").Value.ValueXml.InnerText;

            string vConnString = "Server=" + vServer + ";Database=" + vDb + ";Uid=" + vUID + ";Pwd=" + vPWD + ";";

            myPicsConnect = new MySqlConnection();
            myPicsConnect.ConnectionString = vConnString;

            Connect();
        }

        public static MySqlDataReader JalankanPerintahSelect(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand cmd = new MySqlCommand(sql, k.myPicsConnect);
            MySqlDataReader hasil = cmd.ExecuteReader();
            return hasil;
        }

        public static void JalankanPerintahNonQuery(string sql)
        {
            Koneksi k = new Koneksi();

            MySqlCommand cmd = new MySqlCommand(sql, k.myPicsConnect);
            cmd.ExecuteNonQuery();
        }
    }
}

