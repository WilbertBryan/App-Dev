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
    public partial class Second_Window_Form : Form
    {
        public static Second_Window_Form instance;
        public Label label { get; set; }
        public MainWindowForm mainform { get; set; }
        public Second_Window_Form()
        {
            InitializeComponent();
            instance = this;
            label = label_hi;

        }

        private void CheckBox_checking(object sender, EventArgs e)
        {
            if (checkBox_term.Checked && checkBox_true.Checked)
            {
                btn_Magic.Enabled = true;
            }
            else
                btn_Magic.Enabled = false;
        }

        private void btn_Magic_Click(object sender, EventArgs e)
        {
            bool bgColor = false;
            bool txtColor = false;
            if (!radioBtn_Blue.Checked && !radioBtn_Red.Checked && !radioBtn_Yellow.Checked && !radioBtn_Pink.Checked && !radioBtn_Green.Checked)
                bgColor = true;
            if (!radioBtn_Gray.Checked && !radioBtn_Navy.Checked && !radioBtn_Orange.Checked)
                txtColor = true;

            if (bgColor && txtColor)
            {
                MessageBox.Show("Enter Correct Input");
                
            }
            else
            {
                if (radioBtn_Blue.Checked)
                {mainform.BackColor = Color.Blue;}
                else if(radioBtn_Red.Checked)
                { mainform.BackColor = Color.Red;}
                else if(radioBtn_Yellow.Checked)
                { mainform.BackColor = Color.Yellow;}
                else if( radioBtn_Pink.Checked)
                { mainform.BackColor= Color.Pink;}
                else if(radioBtn_Blue.Checked)
                { mainform.BackColor = Color.Blue;}

                if(radioBtn_Gray.Checked)
                { mainform.ForeColor = Color.Gray;}
                else if(radioBtn_Navy.Checked)
                { mainform.ForeColor= Color.Navy;}
                else if(radioBtn_Orange.Checked)
                { mainform .ForeColor = Color.Orange;}

            }

        }
    }
}