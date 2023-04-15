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
    public partial class ThemDVphong : Form
    {
        public ThemDVphong()
        {
            InitializeComponent();
        }

        private void panelThemHD_Paint(object sender, PaintEventArgs e)
        {

        }
        TrangChu tc = new TrangChu();

        private void iconButton4_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemHopDong(), panelThemHD);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
