﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChronoBikes2
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

        private void signinBTN_Click(object sender, EventArgs e)
        {
            userControl11.Show();
            userControl11.BringToFront();
            userControl21.Hide();
        }

        private void signupBTN_Click(object sender, EventArgs e)
        {
            userControl21.Show();
            userControl21.BringToFront();
            userControl11.Hide();
        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
