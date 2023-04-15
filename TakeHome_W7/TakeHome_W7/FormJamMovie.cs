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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace TakeHome_W7
{
    public partial class FormJamMovie : Form
    {
        public static FormJamMovie formJamMovie;
        Button[] buttonmovie;
        private FormKursi jampertama; private FormKursi jamkedua; private FormKursi jamketiga;

        int nomerbutton;
        public FormJamMovie(int nomer)
        {
            formJamMovie = this;
            InitializeComponent();
            nomerbutton = nomer;
        }

        private void FormJamMovie_Load(object sender, EventArgs e)
        {

            PictureBox pictureBox = new PictureBox();

            string txtfile = File.ReadAllText(@"C:\APDEV\TakeHome_W7\Movie List.txt");
            string[] split = txtfile.Split(',');

            pictureBox.Location = new Point(20, 30);
            pictureBox.Size = new Size(150, 180);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            int angka= nomerbutton * 2 + 1;

            string imagePath = split[angka].Replace("\"", "");
            pictureBox.ImageLocation = imagePath;
            this.Controls.Add(pictureBox);


            Label label = new Label();
            label.Location = new Point(190, 10);
            label.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            label.Size = new Size(1000, 30);
            int angkaa=nomerbutton *2;
            label.Text = split[angkaa];
            this.Controls.Add(label);


            buttonmovie = new Button[3];

            int xbutton = 190;
            int hour0 = 13;
            int hour1 = 14;
            int hour2 = 15;
            for (int i = 0; i < 3; i++)
            {
                buttonmovie[i] = new Button();
                buttonmovie[i].Location = new Point(xbutton, 40);
                buttonmovie[i].Size = new Size(80, 50);
                buttonmovie[i].Tag = i.ToString();

                if (nomerbutton == 0 || nomerbutton == 3 || nomerbutton == 6)
                    buttonmovie[i].Text = hour0.ToString() + ".00";
                else if (nomerbutton == 1 || nomerbutton == 4 || nomerbutton == 7)
                    buttonmovie[i].Text = hour1.ToString() + ".00";
                else if (nomerbutton == 2 || nomerbutton == 5)
                    buttonmovie[i].Text = hour2.ToString() + ".00"; 

                buttonmovie[i].Click += button_Click;
                this.Controls.Add(buttonmovie[i]);

                xbutton += 90;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string no = btn.Tag.ToString();
            int jam = Convert.ToInt32(no);
            
            if (no == "0")
            {
                if (jampertama == null)
                    jampertama = new FormKursi();

                jampertama.MdiParent = Form1.form1;
                jampertama.Dock = DockStyle.Fill;
                jampertama.FormBorderStyle = FormBorderStyle.None;
                jampertama.Show();
                this.Hide();
            }
            else if (no == "1")
            {              
                if (jamkedua == null)
                    jamkedua = new FormKursi();

                jamkedua.MdiParent = Form1.form1;
                jamkedua.Dock = DockStyle.Fill;
                jamkedua.FormBorderStyle = FormBorderStyle.None;
                jamkedua.Show();
                this.Hide();
            }
            else if (no == "2")
            {
                if (jamketiga == null)
                    jamketiga = new FormKursi();

                jamketiga.MdiParent = Form1.form1;
                jamketiga.Dock = DockStyle.Fill;
                jamketiga.FormBorderStyle = FormBorderStyle.None;
                jamketiga.Show();
                this.Hide();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormMovie.formmovie.Show();
            this.Hide();
        }
    }
}
