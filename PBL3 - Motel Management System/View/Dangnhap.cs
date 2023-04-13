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
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        TrangChu tc = new TrangChu();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            tc.ShowDialog();
            this.Close();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
