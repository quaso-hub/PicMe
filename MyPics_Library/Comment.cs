using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPics_Library
{
    public class Comment
    {
        string komentar;
        DateTime commentDate;
        User idUser;
        Picture idPicture;

        public Comment(string komentar, DateTime commentDate, User idUser, Picture idPicture)
        {
            this.komentar = komentar;
            this.commentDate = commentDate;
            this.idUser = idUser;
            this.idPicture = idPicture;
        }

        public string Komentar { get => komentar; set => komentar = value; }
        public DateTime CommentDate { get => commentDate; set => commentDate = value; }
        public User IdUser { get => idUser; set => idUser = value; }
        public Picture IdPicture { get => idPicture; set => idPicture = value; }

        public static void insertCommentar(Comment C)
        {
            string sql = "";
            sql = "INSERT INTO tcomment(comment,commentdate,tPicture_id,tUser_id) values('"
                + C.Komentar + "','" + C.CommentDate + "','" + C.IdUser + "','" + C.IdPicture
                + "')";
            Koneksi.JalankanPerintahSelect(sql);
        }
    }
}
