using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += ".";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            decimal resultado =Convert.ToDecimal(dt.Compute(txt_resultado.Text, ""));
            txt_resultado.Text = resultado.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "5";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "/";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txt_resultado.Text += "+";
        }
    }
}
