﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  //buton 1 'e tıklantıdığında ne olmasını istiyorum...
        {
            MessageBox.Show(AD.Text + " HOŞGELDİNİZ");
            textBox1.Visible = true;
            string tcno = TCNO.Text;
            textBox1.Text = tcno.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false; // seçtiğim textbox gözükmesini istemiyorsam bunu yaparım.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
