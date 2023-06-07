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

namespace PBL3___Motel_Management_System.View
{
    public partial class DoiMK : Form
    {
        private string idPhong;
        private string idChutro;
        private string idTk;
        private Loader loader;
        public DoiMK(string idPhong,string idTk, Loader loader)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            this.idTk = idTk;
            this.loader = loader;
        }
        
       
        private Boolean checkMatKhau()
        {
            int i = 0;
            errorProvider1.SetError(txtMKmoi, "");
            errorProvider1.SetError(txtXacthucMK, "");
            if (txtMKmoi.Text == "")
            {
                i++;
                errorProvider1.SetError(txtMKmoi, "Vui lòng nhập mật khẩu");
            }
            if (txtXacthucMK.Text == "")
            {
                i++;
                errorProvider1.SetError(txtXacthucMK, "Vui lòng nhập mật khẩu ");
            }
            if(txtMKmoi.Text != txtXacthucMK.Text)
            {
                i++;
                errorProvider1.SetError(txtXacthucMK, "Vui lòng nhập lại mật khẩu ");
            }

            if (i == 0) return true;
            else return false;
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            if(checkMatKhau())
            {
                if (idPhong != null)
                {
                    DAL.TaiKhoan tk = QLBLL.Instance.GetTaiKhoanByIdPhong(idPhong);
                    string mkcu = QLBLL.Instance.MaHoaMatKhau(txtMKcu.Text);
                    if(tk.MatKhau!= mkcu)
                    {
                        MessageBox.Show("Nhập mật khẩu không đúng, vui lòng nhập lại");
                    }
                    else
                    {
                        tk.MatKhau = QLBLL.Instance.MaHoaMatKhau(txtXacthucMK.Text);
                        QLBLL.Instance.UpdateTaiKhoanPhong(tk);
                        MessageBox.Show("Thay đổi mật khẩu phòng thành công");
                        this.Close();
                        loader(null);
                    }        
                }
                else
                {
                    DAL.TaiKhoan tk = QLBLL.Instance.GetTaiKhoanByIdTaiKhoan(idTk);
                    string mkcu = QLBLL.Instance.MaHoaMatKhau(txtMKcu.Text);
                    if (tk.MatKhau != mkcu)
                    {
                        MessageBox.Show("Nhập mật khẩu không đúng, vui lòng nhập lại");
                    }
                    else
                    {
                        tk.MatKhau = QLBLL.Instance.MaHoaMatKhau(txtXacthucMK.Text);
                        QLBLL.Instance.UpdateTaiKhoanChutro(tk);
                        MessageBox.Show("Thay đổi mật khẩu tài khoản thành công");
                        this.Close();
                        loader(null);
                    }
                }
            }
            
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtMKcu.PasswordChar == '*')
            {
                iconButton4.BringToFront();
                txtMKcu.PasswordChar = '\0';
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (txtMKcu.PasswordChar == '\0')
            {
                iconButton1.BringToFront();
                txtMKcu.PasswordChar = '*';
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (txtMKmoi.PasswordChar == '*')
            {
                iconButton5.BringToFront();
                txtMKmoi.PasswordChar = '\0';
            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (txtMKmoi.PasswordChar == '\0')
            {
                iconButton2.BringToFront();
                txtMKmoi.PasswordChar = '*';
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (txtXacthucMK.PasswordChar == '*')
            {
                iconButton6.BringToFront();
                txtXacthucMK.PasswordChar = '\0';
            }
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            if (txtXacthucMK.PasswordChar == '\0')
            {
                iconButton3.BringToFront();
                txtXacthucMK.PasswordChar = '*';
            }
        }
    }
}
