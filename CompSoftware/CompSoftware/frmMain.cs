﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompSoftware
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProgOps.OpenDataBase();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProgOps.CloseDataBase();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
