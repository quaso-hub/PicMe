using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPics_Library
{
    public class Like
    {
        private User idUserWhoLikes;
        private Picture whichPicture;

        #region Constructor
        public Like(User idUserWhoLikes, Picture whichPicture)
        {
            this.idUserWhoLikes = idUserWhoLikes;
            this.whichPicture = whichPicture;
        }
        #endregion

        #region Properties

        public User IdUserWhoLikes { get => idUserWhoLikes; set => idUserWhoLikes = value; }
        public Picture WhichPicture { get => whichPicture; set => whichPicture = value; }

        #endregion

        #region Methods

        public static void insertLike(Like l)
        {
            string sql = "";
            sql = "INSERT INTO tlike (tUser_id,tPicture_id) values ('" + l.IdUserWhoLikes + "','" + l.whichPicture + "')";
            Koneksi.JalankanPerintahSelect(sql);

        }

        public static void calculation(Like l)
        {
            string sql = "";
            sql = "SELECT " + l.whichPicture +  "COUNT(" + l.idUserWhoLikes + ")FROM tlike;";
            Koneksi.JalankanPerintahSelect(sql);
        }


        #endregion
    }
}
