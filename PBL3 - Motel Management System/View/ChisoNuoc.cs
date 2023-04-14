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
    public partial class ChisoNuoc : Form
    {
        public ChisoNuoc()
        {
            InitializeComponent();
        }
        TrangChu tc= new TrangChu();
        private void ChisoNuoc_Load(object sender, EventArgs e)
        {

        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemCSNuoc(), panel2);
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaCSNuoc(), panel2);
        }
    }
}
