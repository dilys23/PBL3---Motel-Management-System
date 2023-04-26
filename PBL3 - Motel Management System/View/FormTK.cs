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
    public partial class Taikhoan : Form
    {
        public Taikhoan()
        {
            InitializeComponent();
        }
        TrangChu tc= new TrangChu();

      

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemTK(), panelTK);
        }

        private void panelTK_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemTK(),panelTK);    
        }
    }
}
