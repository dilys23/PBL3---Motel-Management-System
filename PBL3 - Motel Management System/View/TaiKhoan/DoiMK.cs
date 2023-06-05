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
                    DAL.TaiKhoan tk = new DAL.TaiKhoan();
                    DAL.TaiKhoan taikhoancu = QLBLL.Instance.GetTaiKhoanByIdPhong(idPhong);
                    tk.MaTaiKhoan = taikhoancu.MaTaiKhoan;
                    tk.TenTaiKhoan = taikhoancu.TenTaiKhoan;
                    tk.MatKhau = txtMKmoi.Text;
                    tk.TonTai = true;
                    if(taikhoancu.MatKhau!= txtMKcu.Text)
                    {
                        MessageBox.Show("Nhập mật khẩu không đúng, vui lòng nhập lại");
                    }
                    else
                    {
                        QLBLL.Instance.UpdateTaiKhoanPhong(tk);
                        MessageBox.Show("Thay đổi mật khẩu phòng thành công");
                        this.Close();
                        loader(null);
                    }        
                }
                else
                {
                    DAL.TaiKhoan tk = new DAL.TaiKhoan();
                    DAL.TaiKhoan taikhoancu = QLBLL.Instance.GetTaiKhoanByIdTaiKhoan(idTk);
                    tk.MaTaiKhoan = taikhoancu.MaTaiKhoan;
                    tk.TenTaiKhoan = taikhoancu.TenTaiKhoan;
                    tk.MatKhau = txtMKmoi.Text;
                    tk.TonTai = true;
                    if (taikhoancu.MatKhau != txtMKcu.Text)
                    {
                        MessageBox.Show("Nhập mật khẩu không đúng, vui lòng nhập lại");
                    }
                    else
                    {
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
    }
}
