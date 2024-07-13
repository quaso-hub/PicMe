using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MyPics_Library
{
    public class Hashtag
    {
        string hashtagPost;
        private Picture idPicture;

        public Hashtag(string hashtagPost, Picture idPicture)
        {
            this.hashtagPost = hashtagPost;
            this.idPicture = idPicture;
        }

        public string HashtagPost { get => hashtagPost; set => hashtagPost = value; }
        public Picture IdPicture { get => idPicture; set => idPicture = value; }

        public static void insertHashtag(Hashtag h)
        {
            string sql = "";
            sql = "insert into thashtag(hashtag,tPicture_id) values ('" + h.HashtagPost +
                "','" + h.IdPicture + "')";
            Koneksi.JalankanPerintahSelect(sql);
        }
    }
}
