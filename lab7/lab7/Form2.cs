using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float size = 9;
            if (radioButton1.Checked)
            {
                size = 8;
            }
            if (radioButton2.Checked)
            {
                size = 10;
            }

            if (radioButton3.Checked)
            {
                size = 12;
            }

            var style = FontStyle.Regular;

            if (checkBox1.Checked)
            {
                style |= FontStyle.Bold;
            }

            if (checkBox2.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (checkBox3.Checked)
            {
                style |= FontStyle.Underline;
            }

            textBox1.Font = new Font(this.Font.FontFamily, size, style);
            if (radioButton4.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            if (radioButton5.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }

            if (radioButton6.Checked)
            {
                textBox1.ForeColor = Color.Orange; 
            }
        }
    }
}