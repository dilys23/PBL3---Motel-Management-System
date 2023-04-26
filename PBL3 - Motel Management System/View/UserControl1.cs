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
        public Panel DesktopPanel { get; set; }

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
       // TrangChu tc = new TrangChu();   
        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            //tc.openChildForm(new DoiMK());
            using (DoiMK frm = new DoiMK())
            {
                frm.ShowDialog();
            }
            
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            //using (ChuTro frm = new ChuTro())
            //{
            //    frm.ShowDialog();
            //}
            // Khởi tạo form
            //ChuTro form = new ChuTro();

            //// Thiết lập DockStyle.Fill để form điền vào Panel
            //form.TopLevel = false;
            //form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.Fill;

            //// Hiển thị form trong Panel của trang chủ
            //DesktopPanel.Controls.Clear();
            //DesktopPanel.Controls.Add(form);
            //form.Show();
            ChuTro form = new ChuTro(); // Tạo một đối tượng form mới
            form.TopLevel = false; // Set TopLevel = false để hiển thị form trên panel của trang chủ
            form.FormBorderStyle = FormBorderStyle.None;
            //form.Dock = DockStyle.None; // Dock form vào panel của trang chủ
            this.Parent.Controls.Add(form); // Thêm form vào panel của trang chủ
            this.Parent.Controls.Remove(this); // Xóa user control hiện tại
            form.Show(); // Hiển thị form mới
        }
    }
}
