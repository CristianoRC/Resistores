﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareResistores
{
    public partial class Frm_Pai : Form
    {
        public Frm_Pai()
        {
            InitializeComponent();
        }

        private void Btm_Cores_Click(object sender, EventArgs e)
        {
            Frm_RCores frm_RCores = new Frm_RCores();

            frm_RCores.MdiParent = this;

            frm_RCores.Show();
        }

        private void Frm_Pai_Load(object sender, EventArgs e)
        {

        }

        private void Btm_Serie_Click(object sender, EventArgs e)
        {
            Frm_Serie frm_Serie = new Frm_Serie();

            frm_Serie.MdiParent = this;

            frm_Serie.Show();
        }

        private void Btm_Paralelo_Click(object sender, EventArgs e)
        {
            Frm_Paralelo frm_paralelo = new Frm_Paralelo();

            frm_paralelo.MdiParent = this;

            frm_paralelo.Show();
        }
    }
}
