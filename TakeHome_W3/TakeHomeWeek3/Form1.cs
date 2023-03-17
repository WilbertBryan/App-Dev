using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeHomeWeek3
{
    public partial class MainWindowForm : Form
    {
        bool klik = false;

        public MainWindowForm()
        {
            InitializeComponent();
        }

        public void nyala()
        {
            if (checkBox_Content.Checked && klik == true)
                btn_Submit.Enabled = true;
            else
                btn_Submit.Enabled = false;
        }
        private void btn_NextForm_Click(object sender, EventArgs e)
        {
            klik = true;
            Second_Window_Form second_Window_Form = new Second_Window_Form();
            second_Window_Form.mainform = this;
            second_Window_Form.Show();
            nyala();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txtBox_Name.Text != "" && txtBox_Artist.Text != "")
                Second_Window_Form.instance.label.Text = "Hi, my name is " + txtBox_Name.Text + " and my favorite artist is " + txtBox_Artist.Text;
            else
                MessageBox.Show("Enter Correct Input");

        }

        private void checkBox_Content_CheckedChanged(object sender, EventArgs e)
        {
            nyala();
        }
    }
}