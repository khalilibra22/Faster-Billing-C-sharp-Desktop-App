﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturation
{
    public partial class PintBonAchat : Form
    {
        public PintBonAchat()
        {
            InitializeComponent();
        }

        private void closePrintFrom_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimazeWindowBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void PintBonAchat_Load(object sender, EventArgs e)
        {

        }
    }
}
