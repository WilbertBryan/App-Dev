using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHome_W8
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerData playerData= new PlayerData();
            playerData.MdiParent= this;
            playerData.Dock= DockStyle.Fill;
            playerData.ControlBox = false;
            playerData.FormBorderStyle = FormBorderStyle.None;
            playerData.Show();
        }

        private void showMatchDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowMatch showMatch= new ShowMatch();
            showMatch.MdiParent= this;
            showMatch.Dock= DockStyle.Fill;
            showMatch.ControlBox = false;
            showMatch.FormBorderStyle = FormBorderStyle.None;
            showMatch.Show();
        }
    }
}
