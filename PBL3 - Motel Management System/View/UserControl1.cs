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
    public partial class TaiKhoan : UserControl
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
       
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            // Đóng Form hiện tại
        //Form parentForm = this.FindForm();
         this.ParentForm.Close();
    
    // Khởi tạo lại Form đăng nhập và hiển thị nó
         Dangnhap dn = new Dangnhap();
        dn.Show();
        }
    }
}
