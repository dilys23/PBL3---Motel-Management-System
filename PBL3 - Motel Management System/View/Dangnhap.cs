using PBL3___Motel_Management_System.BLL;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
            if(qLBLL.GetIdTk(tk,mk)!=null)
            {
                TrangChu tc = new TrangChu();
                tc.ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu bị sai", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
