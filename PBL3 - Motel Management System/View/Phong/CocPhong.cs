using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class CocPhong : Form
    {
        private Loader loader;
        private ThuePhong tp;
        CultureInfo vietnamCulture = new CultureInfo("vi-VN");
        public CocPhong(ThuePhong tp,Loader loader)
        {
            InitializeComponent();
            this.loader=loader;
            this.tp = tp;
            LoadForm();
           
        }
        public void LoadForm()
        {
           
            Nguoi nguoi = new Nguoi();
            HopDong hd = new HopDong();
            hd = QLBLL.Instance.GetHopDongByIdPhong(tp.hopDong.MaPhongTro);
            if (tp != null)
            {
                if (QLBLL.Instance.PhongDaCocByIdPhong(tp.hopDong.MaPhongTro) == true)
                {
                    nguoi = QLBLL.Instance.GetNguoiByMaHopDong(hd.MaHopDong);
                    txtTen.Text = nguoi.Ten;
                    txtTen.Enabled = false;
                    txtSdt.Text = nguoi.Sdt;
                    txtSdt.Enabled  = false;
                    txtTienCoc.Text = hd.TienCoc.ToString("#,##0") + "₫";
                    txtTienCoc.Enabled = false;
                    txtCccd.Text = nguoi.Cccd;
                    txtCccd.Enabled = false;
                    DateTime batdau = DateTime.ParseExact(hd.NgayBatDau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime ketthuc = DateTime.ParseExact(hd.NgayKetThuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                  
                    dtpNgayCoc.Value = batdau;
                    dtpNgayCoc.Enabled = false;
                    dtpNgayNhanPhong.Value = ketthuc;
                    dtpNgayNhanPhong.Enabled = false;
                    btnXacNhan.Visible = false;
                    btnTrove.Visible = false;
                }
            }            
        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckHopLe()
        {
            bool status = true;
            errorProvider1.SetError(txtCccd, "");
            errorProvider1.SetError(txtSdt, "");
            errorProvider1.SetError(txtTen, "");
            errorProvider1.SetError(txtTienCoc, "");
            if(txtCccd.Text == "")
            {
                errorProvider1.SetError(txtCccd, "Vui lòng điền số Cccd");
                status = false;

            }
            if (txtSdt.Text == "")
            {
                errorProvider1.SetError(txtSdt, "Vui lòng điền số điện thoại");
                status = false;

            }
            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Vui lòng điền họ và tên");
                status = false;

            }
            if (txtTienCoc.Text == "")
            {
                errorProvider1.SetError(txtTienCoc, "Vui lòng điền tiền cọc");
                status = false;

            }
            if(txtTienCoc.Text != "")
            {

            if(!double.TryParse(txtTienCoc.Text,out double n))
            {
                    errorProvider1.SetError(txtTienCoc, "Tiền cọc phải là một số");
                    status = false;
                }
            }
            return status;
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(CheckHopLe())
            {
                Nguoi nguoi = new Nguoi
                {
                    MaNguoi = QLBLL.Instance.TaoIdNguoi(),
                    Ten = txtTen.Text,
                    Cccd = txtCccd.Text,
                    Sdt = txtSdt.Text,
                    Diachi = "",
                    GioiTinh = false,
                    NgaySinh = "",
                    TonTai = true
            };
                HopDong hd = new HopDong
                {
                    MaHopDong = QLBLL.Instance.TaoIdHopDong(),
                    MaNguoi = nguoi.MaNguoi,
                    MaPhongTro = tp.hopDong.MaPhongTro,
                    NgayBatDau = dtpNgayCoc.Value.ToString("yyyy-MM-dd"),
                    NgayKetThuc = dtpNgayNhanPhong.Value.ToString("yyyy-MM-dd"),
                    TienCoc = (Convert.ToDouble(txtTienCoc.Text.Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", ""))),
                    TinhTrang = false,
                    TonTai = true

            };
                QLBLL.Instance.AddNguoiBll(nguoi);
                QLBLL.Instance.AddHdBll(hd);
                MessageBox.Show("Cọc phòng thành công");
                this.Close();
                this.loader(null);
            }
        }
    }
}
