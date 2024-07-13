using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicMe
{
    public partial class Form1 : Form
    {
        private bool isLiked = false;
        private bool isKomen = false;
        private bool isRepost = false;
        public Form1()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SetFormSize(int width, int height)
        {
            this.Size = new Size(width, height);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SetFormSize(801, 770);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetFormSize(1238, 770);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
