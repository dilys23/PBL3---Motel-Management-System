using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace PBL3___Motel_Management_System.View
{

    public partial class ThanhToan : Form
    {
        private Loader loader;
        private string IdHd;
        public ThanhToan(string idHd, Loader loader)
        {
            InitializeComponent();
            this.loader = loader;
            this.IdHd = idHd;
            HoaDon hd = QLBLL.Instance.GetHoaDonById(idHd);
            PhongTro pt = QLBLL.Instance.GetPhongTroByMaHoaDon(idHd);
            txtTenPhong.Text = pt.TenPhongTro;

            // Định dạng số tiền theo tiền tệ VND
            CultureInfo vietnamCulture = new CultureInfo("vi-VN");
            txtTongTien.Text = hd.TongTien.ToString("#,##0") + "₫";
            txtConNo.Text = (Convert.ToDouble(txtTongTien.Text.Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", "")) - hd.DaThanhToan).ToString("C0", vietnamCulture);


        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtThanhToan, "");
            if (txtThanhToan.Text == "")
            {
                i++;
                errorProvider1.SetError(txtThanhToan, "Vui lòng nhập số tiền thanh toán");

            }
            if (txtThanhToan.Text != "")
            {
                if (!double.TryParse(txtThanhToan.Text, out double d))
                {
                    i++;
                    errorProvider1.SetError(txtThanhToan, "Chi so dien phải bằng số");
                }
            }
            if (i == 0) { return true; }
            return false;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (checkHopLe())
            {
                double thanhToan;

                // Định dạng giá trị nhập vào từ txtThanhToan.Text
                if (double.TryParse(txtThanhToan.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out thanhToan))
                {
                    HoaDon hd = QLBLL.Instance.GetHoaDonById(this.IdHd);
                    ChiTietThanhToanHoaDon ct = new ChiTietThanhToanHoaDon();

                    ct.MaHoaDon = hd.MaHoaDon;
                    ct.MaChiTietThanhToanHoaDon = QLBLL.Instance.TaoIdChiTietThanhToanHoaDon();

                    ct.NgayThanhToan = NgayThanhToan.Value.ToString("yyyy-MM-dd");
                    ct.TienThanhToan = thanhToan;
                    ct.TonTai = true;

                    // Cập nhật số tiền đã thanh toán
                    hd.DaThanhToan += thanhToan;
                    QLBLL.Instance.UpdateHoaDonBLL(hd);
                    CultureInfo vietnamCulture = new CultureInfo("vi-VN");
                    // Tính số tiền còn nợ mới
                   
                    double conNoMoi1 = (Convert.ToDouble(txtTongTien.Text.Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", "")) - hd.DaThanhToan);
                    // Cập nhật giá trị cho txtConNo
                    txtConNo.Text = conNoMoi1.ToString("#,##0") + "₫";

                    QLBLL.Instance.AddChiTietThanhToanHoaDonBll(ct);

                    if (conNoMoi1 == 0)
                    {
                        MessageBox.Show("Đã trả đủ tiền", "Thông báo");
                    }
                    if (conNoMoi1 < 0)
                    {
                        MessageBox.Show("Bạn đã nhập thừa tiền", "Thông báo");
                    }

                    loader(null);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập số tiền thanh toán hợp lệ", "Lỗi");
                }
            }
        }
   
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtThanhToan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
