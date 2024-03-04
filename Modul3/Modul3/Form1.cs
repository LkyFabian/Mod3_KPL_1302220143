using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul3
{
    public partial class Form1 : Form
    {
        int angka;
        int temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 8;
            angka = 8;
            label1.Text = angka.ToString(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 2; 
            angka = 2;
            label1.Text = angka.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 7;
            angka = 7;
            label1.Text = angka.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            temp = temp * 10;
            label1.Text = temp + angka.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 0;
            angka = 0;
            label1.Text = angka.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 4;
            angka = 4;
            label1.Text = angka.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 5;
            angka = 5;
            label1.Text = angka.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 6;
            angka = 6;
            label1.Text = angka.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 1;
            angka = 1;
            label1.Text = angka.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 3;
            angka = 3;
            label1.Text = angka.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = angka.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temp = temp * 10 + 9;
            angka = 9;
            label1.Text = angka.ToString();
        }
    }
}
