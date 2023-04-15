using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TakeHome_W7
{
    public partial class FormMovie : Form
    {
        int jumlahmovie = 0;
        public static FormMovie formmovie;
        string[] split;

        private FormJamMovie [] movie;

        public FormMovie()
        {
            InitializeComponent();
            string txtfile = File.ReadAllText(@"C:\APDEV\TakeHome_W7\Movie List.txt");
            split = txtfile.Split(',');
            jumlahmovie = split.Length / 2;
            movie = new FormJamMovie[jumlahmovie];
            formmovie = this;
        }
        Button[] button;
        Label[] label;
        PictureBox[] picturebox;
        private void FormMovie_Load(object sender, EventArgs e)
        {
            button = new Button[jumlahmovie];// INI GA ADA
            label=new Label[jumlahmovie];
            picturebox = new PictureBox[jumlahmovie];

            int xlabel = 35,ylabel=20;
            int xpicture=20,ypicture=50;
            int xbutton = 30, ybutton = 190;
            
            
            int length=split.Count()/2;
            int judul = 0;
            int photo = 1;
            
            for (int i=0;i<length;i++)
            {
                label[i] = new Label();
                label[i].Location = new Point(xlabel, ylabel);
                label[i].Size = new Size(90, 30);
                label[i].Text = split[judul];
                label[i].Font= new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                this.Controls.Add(label[i]);
                judul += 2;

                picturebox[i]= new PictureBox();
                picturebox[i].Location=new Point(xpicture, ypicture);
                picturebox[i].SizeMode=PictureBoxSizeMode.StretchImage;
                picturebox[i].Size = new Size(100, 130);
                string imagePath = split[photo].Replace("\"", "");
                picturebox[i].ImageLocation = imagePath;
                this.Controls.Add(picturebox[i]);
                photo += 2;
                

                button[i]=new Button();
                button[i].Location = new Point(xbutton,ybutton);
                button[i].Size = new Size(80, 30);
                button[i].Text = "Choose";
                button[i].Tag = i.ToString();
                button[i].Click += button_Click;
                this.Controls.Add(button[i]);
                xbutton += 180;

                if(i<=2 || i>=4)
                {
                    xlabel += 175;
                    xpicture += 180;
                }
                else
                {
                    xlabel = 35;
                    ylabel += 220;

                    xpicture = 20;
                    ypicture += 220;

                    xbutton = 30;
                    ybutton += 220;
                }
            }

        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int no = Convert.ToInt32(btn.Tag.ToString());
            
            for(int i=0;i<jumlahmovie;i++)
            {
                if(i==no)
                {
                    if (movie[i]==null) 
                        movie[i] = new FormJamMovie(i);

                    movie[i].MdiParent = Form1.form1;
                    movie[i].FormBorderStyle = FormBorderStyle.None;
                    movie[i].Dock = DockStyle.Fill;
                    movie[i].Show();
                    this.Hide();
                }
            }
          
        }
    }
}
