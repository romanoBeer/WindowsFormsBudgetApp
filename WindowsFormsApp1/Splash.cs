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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(2);

            if (progressBar1.Value == 100) 
            { 
                timer1.Enabled = false;
                loginFrm loginFrm = new loginFrm();
                loginFrm.Show();
                this.Hide();
            }
        }
    }
}
