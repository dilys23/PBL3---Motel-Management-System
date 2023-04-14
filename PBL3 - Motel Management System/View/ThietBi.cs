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

namespace PBL3___Motel_Management_System.View
{
    public partial class ThietBi : Form
    {
        public ThietBi()
        {
            InitializeComponent();
        }
        TrangChu tc= new TrangChu();
        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemThietBi(), panelDV);
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaThietBI(), panelDV);
        }
    }
}
