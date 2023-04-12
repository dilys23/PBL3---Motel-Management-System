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
    public partial class Phong : Form
    {
        
       
        public Phong()
        {
            InitializeComponent();
            //this.paneDesktop = paneDesktop;
         
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong();
            themPhong.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            SuaPhong themSuaph = new SuaPhong();
            themSuaph.ShowDialog();
        }
        //private Form activeForm = null;
        TrangChu tc = new TrangChu();

        private void btnThemday_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemDay(), panelPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemPhong(), panelPhong);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaPhong(), panelPhong);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

