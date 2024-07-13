using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPics_Library
{
    public enum statusPost
    {
        privacy,
        publik
    }

    public class Picture
    {


        private int id;
        private string filename;
        private DateTime inputDate;
        private DateTime eventTime;
        private User ownerID;
        private statusPost status;
        private string caption;

        public Picture(int id, string filename, DateTime inputDate, DateTime eventTime, User ownerID, statusPost status, string caption)
        {
            this.id = id;
            this.filename = filename;
            this.inputDate = inputDate;
            this.eventTime = eventTime;
            this.ownerID = ownerID;
            this.status = status;
            this.caption = caption;
        }

        public int Id { get => id; set => id = value; }
        public string Filename { get => filename; set => filename = value; }
        public DateTime InputDate { get => inputDate; set => inputDate = value; }
        public DateTime EventTime { get => eventTime; set => eventTime = value; }
        public User OwnerID { get => ownerID; set => ownerID = value; }
        private statusPost Status { get => status; set => status = value; }
        public string Caption { get => caption; set => caption = value; }

        public static void uploadFoto(Picture p)
        {
            string sql = "";
            sql = "insert into tPicture(filename,inputdate,eventtime,ownerID,status,caption)" +
                "values=('" + p.Filename + "','" + p.InputDate + "','" + p.EventTime + "','" +
                p.OwnerID + "','" + p.Status + "','" + p.caption + "')";
            Koneksi.JalankanPerintahSelect(sql);

        }

   
    }
}
