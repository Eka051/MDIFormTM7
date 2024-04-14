using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string radioButtonSelected = "";
            if (radioButton1.Checked)
            {
                radioButtonSelected = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                radioButtonSelected = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                radioButtonSelected = radioButton3.Text;
            }
            string textBox = textBox1.Text;

            label1.Text = $"{textBox1.Text} telah memilih {radioButtonSelected}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
