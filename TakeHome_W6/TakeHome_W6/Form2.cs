using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TakeHome_W6
{
    public partial class Form2 : Form
    {
        int row;
        int nextline = 0;
        string[] split;
        string katarandom;
        string word;
        Button[,] buttons;
        bool menang = false;
 
        public Form2(int num)
        {
            InitializeComponent();
            row = num;
            string txtfile = File.ReadAllText(@"C:\APDEV\TakeHome_W6\Wordle Word List.txt");
            split = txtfile.Split(',');//14912
            Random rnd = new Random();
            int random = rnd.Next(1, 14913);
            katarandom = split[random].ToUpper();

            MessageBox.Show(katarandom);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            buttons = new Button[row, 5];
            int x = 10, y = 10;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Location = new Point(x, y);
                    buttons[i, j].Size = new Size(50, 50);
                    this.Controls.Add(buttons[i, j]);
                    x += 55;
                }
                x = 10;
                y += 55;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (menang == false)
            {
                Button button = (Button)sender;
                for (int j = 0; j < 5; j++)
                {
                    if (string.IsNullOrEmpty(buttons[nextline, j].Text))
                    {
                        buttons[nextline, j].Text = button.Text;
                        word += button.Text;
                        break;
                    }
                }
            }

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            
            bool ada = false;
            //MessageBox.Show(word);
            if (string.IsNullOrEmpty(word) && menang == false)
                MessageBox.Show("Input first");
            else if (menang == false)
            {
                
                foreach (string a in split)
                {
                    if (a.ToUpper() == (word))
                    {
                        ada = true;
                    }
                }
                if (ada == false)
                {
                    MessageBox.Show(word + " is not on the word list");
                }
                else
                {
                    bool[] arr = new bool[5];
                    //Cek hijau
                    for (int i = 0; i < 5; i++)
                    {
                        if (word[i] == katarandom[i])
                        {
                            buttons[nextline, i].BackColor = Color.LightGreen;
                            arr[i] = true;
                        }
                    }

                    for (int i = 0; i <= 4; i++)
                    {
                        for (int j = 0; j <= 4; j++)
                        {
                            //MessageBox.Show("kata random - " + katarandom[i].ToString() + " word - " + word[j].ToString() +" "+ arr[j] + " " + j.ToString()) ;
                            if (katarandom[i] == word[j] && arr[i] == true)
                            {
                                //MessageBox.Show("MASUK CUY");
                                if (i < 4)
                                {
                                    i++;
                                    j = -1;
                                }
                            }
                            else if (katarandom[i] == word[j] && arr[j] == false)
                            {
                                buttons[nextline, j].BackColor = Color.LightGoldenrodYellow;
                                arr[j] = true;
                                //MessageBox.Show("MASUK kata random - " + katarandom[i].ToString() + " word - " + word[j].ToString() + " " + arr[j]+" "+j.ToString());
                                if (i < 4)
                                {
                                    i++; j = -1;
                                }

                            }
                        }
                    }
                    if (word.Contains(katarandom))
                    {
                        menang = true;
                        MessageBox.Show("You Win");
                    }

                    if (nextline <= row)
                        nextline++;

                    if (menang == false && nextline == row)
                    {
                        MessageBox.Show("YOU LOST! The Word Is: " + katarandom);
                        menang = true;
                    }
                       

                    word = "";
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(menang == false)
            {
                word = "";
                for (int i = 4; i >= 0; i--)
                {
                    if (!string.IsNullOrEmpty(buttons[nextline, i].Text))
                    {
                        buttons[nextline, i].Text = "";
                        break;
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    if (!string.IsNullOrEmpty(buttons[nextline, j].Text))
                    {
                        word += buttons[nextline, j].Text;

                    }
                }
            }
        }
    }
}
