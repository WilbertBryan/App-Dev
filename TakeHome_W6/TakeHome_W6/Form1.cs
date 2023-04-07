using System;
using System.Windows.Forms;

namespace TakeHome_W6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                int input = Convert.ToInt32(textBox1.Text);
                if (input > 0)
                {
                    Form2 frm2 = new Form2(input);
                    frm2.Show();
                    //this.Close();
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;

        }
    }
}
