﻿using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    public partial class ThemKhach : Form
    {
        public ThemKhach()
        {
            InitializeComponent();
        }

        private void ThemKhach_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TrangChu tc = new TrangChu();

      

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ChitietHopDong(), panelKhach);
        }
    }
}
