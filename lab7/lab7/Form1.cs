using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(textBox1.Text);
            if (checkBox1.Checked)
            {
                label4.Text = (height - 100).ToString();
            }

            if (checkBox2.Checked)
            {
                if (radioButton1.Checked)
                {
                    label5.Text = ((height - 100) * 0.85).ToString();
                }
                else
                {
                    label5.Text = ((height - 100) * 0.9).ToString();
                }
            }
        }
    }
}