using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private float wynikAktu = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ',';
        }
        
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        
        private void dodawanie(object sender, EventArgs e)
        {
            wynikAktu += (float) Convert.ToDouble(textBox1.Text);
            textBox1.Text = ""; 

        }
        
        private void odejmowanie(object sender, EventArgs e)
        {
            wynikAktu -= (float) Convert.ToDouble(textBox1.Text);
            textBox1.Text = ""; 
        }
        
        private void mnozenie(object sender, EventArgs e)
        {
            wynikAktu = 1;
            wynikAktu *= (float) Convert.ToDouble(textBox1.Text);
            textBox1.Text = ""; 
        }
        
        private void dzielenie(object sender, EventArgs e)
        {
            wynikAktu = 1;
            wynikAktu /= (float) Convert.ToDouble(textBox1.Text);
            textBox1.Text = ""; 
        }
        
        private void clear(object sender, EventArgs e)
        {
            textBox1.Text = ""; 
        }
        
        private void wynik(object sender, EventArgs e)
        {
            textBox1.Text = wynikAktu.ToString();
        }
    }
}