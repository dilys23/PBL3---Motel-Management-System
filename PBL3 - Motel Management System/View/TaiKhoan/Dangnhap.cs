using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    public partial class Dangnhap : Form
    {
        private string matk;
        public Dangnhap()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox3.Width - 3, pictureBox3.Height - 3);
            Region rg = new Region(gp);
            pictureBox3.Region = rg;
            SetTextBox(txtMatKhau);
            SetTextBox(txtTaiKhoan);
            SetButton(btnDangNhap);

        }
        private int borderSize = 2;
        private int borderRadius = 0;
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void SetTextBox(TextBox txt)
        {
            GraphicsPath pathTxt;
            if (txt.Multiline)
            {
                pathTxt = GetFigurePath(txt.ClientRectangle, borderRadius - borderSize);
                txt.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(txt.ClientRectangle, borderSize * 2);
                txt.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        private void SetButton(Button btn)
        {
            GraphicsPath pathBtn;
            if (btn.Size.Width > btn.Size.Height)
            {
                // Bo tròn theo chiều cao
                pathBtn = GetFigurePath(btn.ClientRectangle, btn.Size.Height / 2);
                btn.Region = new Region(pathBtn);
            }
            else
            {
                // Bo tròn theo chiều rộng
                pathBtn = GetFigurePath(btn.ClientRectangle, btn.Size.Width / 2);
                btn.Region = new Region(pathBtn);
            }
            pathBtn.Dispose();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mk = QLBLL.Instance.MaHoaMatKhau(txtMatKhau.Text);
            if(QLBLL.Instance.GetIdTk(txtTaiKhoan.Text, mk) != null)
            {
                VaiTro vaitro = QLBLL.Instance.CheckVaiTro(txtTaiKhoan.Text, mk);
                if(vaitro.TenVaiTro=="Chủ trọ" )
                {
                     matk = vaitro.MaTaiKhoan;
                    TrangChu tc = new TrangChu(matk);
                    tc.Show();
                    this.Hide();
                }
                else
                {
                     matk = vaitro.MaTaiKhoan;
                    TrangChuKhach tc = new TrangChuKhach(matk);
                    tc.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông Báo", MessageBoxButtons.OK);
            }

            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar=='*')
            {
                btnChiTiet.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                iconButton1.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                //formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                //this.Size = formSize;
            }
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {

            //formSize = this.ClientSize;
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
