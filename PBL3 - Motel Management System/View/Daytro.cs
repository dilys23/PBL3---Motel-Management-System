using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class Daytro : Form
    {
        public Daytro()
        {
            InitializeComponent();
        }
        TrangChu tc = new TrangChu();   

        private void btnThem_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemPhong(), panelDay);
        }

        private void btnThemday_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemDay(), panelDay);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaPhong(), panelDay);
        }

        private void btnSuaday_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaDay(), panelDay);
        }
    }
}
