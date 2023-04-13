using PBL3___Motel_Management_System.View;
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
    public partial class HopDong : Form
    {
        public HopDong()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        TrangChu tc = new TrangChu();

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemHopDong(), panelHopDong);
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaHopDong(), panelHopDong);
        }
    }
}
