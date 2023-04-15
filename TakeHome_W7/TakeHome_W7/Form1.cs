using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHome_W7
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();

           form1=this;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormMovie formMovie = new FormMovie();
            formMovie.MdiParent = this;
            formMovie.FormBorderStyle = FormBorderStyle.None;
            formMovie.Dock = DockStyle.Fill;
            formMovie.Show();
        }
    }
}
