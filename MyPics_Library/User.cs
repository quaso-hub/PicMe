using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPics_Library
{
    public class User
    {
        int id;
        string username;
        string email;
        string password;


        #region constructors
        public User(int id, string username, string email, string password)
        {
            this.Id = id;
            this.Username = username;
            this.Email = email;
            this.Password = password;
        }
        #endregion

        #region properties

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region methods

        public static User CekLogin(string username, string password)
        {
            string sql = "";
            sql = "SELECT * FROM tuser WHERE username='" + username + "'AND password='" + password + "'";
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(sql);

            while (hasil.Read() == true)
            {
                User p = new User(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString()
                    , hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString());
                return p;
            }
            return null;
        }

        public static void Register(User u)
        {
            string sql = "";
            sql = "insert into tuser(username,email,password)" +
                "values ('" + u.username + "','" + u.email + "','" +
                u.password + "')";
            Koneksi.JalankanPerintahSelect(sql);

        }

        /*public static List<User> BacaData(string kriteria, string nilaiKriteria)
        {
            string sql;

            if (kriteria == "")
            {
                sql = "SELECT * FROM tuser;";
            }
            else
            {
                sql = "SELECT * FROM tuser " + kriteria + " like '%" + nilaiKriteria + "%'";

            }
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(sql);

            //list untuk menampung data
            List<User> listPegawai = new List<User>();
            while (hasil.Read() == true)
            {

                User k = new User(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString()
                    , hasil.GetValue(3).ToString());
                listPegawai.Add(k);

            }
            return listPegawai; 

            
        } */
        #endregion
    }
}
