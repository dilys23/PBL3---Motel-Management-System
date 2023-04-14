using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3___Motel_Management_System.View;
namespace PBL3___Motel_Management_System
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }
        TrangChu tc= new TrangChu();

        private void btnIn_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new XuatHoaDon(), panel2);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemHoaDon(), panel2);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaHoaDon(), panel2);
        }
    }
}
