﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Person
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            p.name = textBox1.Text;
            p.age = Convert.ToInt32(textBox2.Text);
            p.address = textBox3.Text;

            StringBuilder sb = new StringBuilder();
            sb.Append("Person Name : " + p.name + "\n");
            sb.Append("Person Age : " + p.age + "\n");
            sb.Append("Person Address : " + p.address + "\n");

            label4.Text = sb.ToString();
        }
    }
}
