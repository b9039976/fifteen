﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMSystem15
{
    public partial class viewBalance : Form
    {
        public viewBalance()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainList f2 = new mainList();
            f2.Show();
            this.Hide();
        }
    }
    }
