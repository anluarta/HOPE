﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Test
{
    public partial class frmControlUser : Form
    {
        public frmControlUser()
        {
            InitializeComponent();
        }
        public void BtnVoltar(object sender, EventArgs e)
        {
            Controls.Clear();
            Close();
        }
    }
}
