using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TakeHome_W7
{
    public partial class FormKursi : Form
    {
        Button[,] button;
        string[] alfabet = { "A", "B", "C", "D","E","F","G","H","I","J" };
        List<string> angka = new List<string>();
        public FormKursi()
        {
            InitializeComponent();
        }
        public void Randomizer()
        {
            Random random = new Random();
            int occupancy = random.Next(1, 71);
            int nambah = 1;
            while (nambah <= occupancy)
            {
                int r = random.Next(1, 101);
                if (!angka.Contains(r.ToString()))
                {
                    angka.Add(r.ToString());
                    nambah++;
                }

            }
        }
        private void FormKursi_Load(object sender, EventArgs e)
        {
            button = new Button[11, 11];
            int x = 50, y = 10;
            int number = 1;
            int tambah = 0;
            int nomer = 1;
            Randomizer();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Location = new Point(x, y);
                    button[i, j].Size = new Size(40, 40);
                    button[i, j].Text = alfabet[tambah]+nomer.ToString() ;
                    button[i, j].Tag = number.ToString();
                    button[i, j].Click += button_Click;
                    this.Controls.Add(button[i, j]);
                    number++;
                    x += 50;
                    nomer++;
                }
                nomer = 1;
                tambah++;
                x = 50;
                y += 40;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    string lokasi = button[i, j].Tag.ToString();
                    if (angka.Contains(lokasi))
                    {
                        button[i, j].BackColor = Color.Tomato;
                        button[i, j].Enabled = false;
                    }
                    this.Controls.Add(button[i, j]);
                }
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string a = btn.Tag.ToString();

            if (btn.BackColor == Color.Yellow)
                btn.BackColor = Color.White;
            else
                btn.BackColor = Color.Yellow;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (button[i, j].BackColor == Color.Yellow)
                    {
                        button[i, j].BackColor = Color.Transparent;
                    }
                }
            }
            FormJamMovie.formJamMovie.Show();

            this.Hide();
        }
        private void btn_reserve_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   if (button[i,j].BackColor == Color.Yellow)
                    {
                        button[i, j].BackColor = Color.Tomato;
                        button[i, j].Enabled = false;
                    }
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                        button[i, j].BackColor = Color.White;
                        button[i, j].Enabled = true;
                }
            }
        }
    }
}
