using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPics_Library
{

    public enum repost
    {
        yes,
        no

    }
    public class Tagging
    {

        private Picture idPicture;
        private User idUser;
        private repost repostStatus;

        public Tagging(Picture idPicture, User idUser, repost repostStatus)
        {
            this.idPicture = idPicture;
            this.idUser = idUser;
            this.repostStatus = repostStatus;
        }

        public Picture IdPicture { get => idPicture; set => idPicture = value; }
        public User IdUser { get => idUser; set => idUser = value; }
        public repost RepostStatus { get => repostStatus; set => repostStatus = value; }

        public static void insertTagging(Tagging t)
        {
            string sql = "";
            sql = "insert into tTagging(tPicture_id,tUser_id) values ('" + t.IdPicture + "','" +
                t.IdUser + "','" + t.RepostStatus + "')";
        }
    }
}
