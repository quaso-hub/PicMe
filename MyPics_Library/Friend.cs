using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPics_Library
{
    public class Friend
    {
        private User user1;
        private User user2;

        public Friend(User user1, User user2)
        {
            this.user1 = user1;
            this.user2 = user2;
        }

        public User User1 { get => user1; set => user1 = value; }
        public User User2 { get => user2; set => user2 = value; }

        #region methods 


        //Method FriendRequest dipakai untuk merekap aktivitas antara user dengan user lainnya
        //sehingga ketika 2 pihak saling berteman, maka MyPics akan mencatat dan memasukkan
        //kedalam database 
        public static void FriendRequest(Friend p)
        {
            string sql = "INSERT FROM tfriend(tUser_id, tUser_id1) values('" + p.User1 + "','" + p.User2 + "')";

            Koneksi.JalankanPerintahNonQuery(sql);
        }

        #endregion
    }
}
