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
        private CultureInfo vietnamCulture = new CultureInfo("vi-VN");
        public ThanhToan(string idHd, Loader loader)
        {
            InitializeComponent();
            this.loader = loader;
            this.IdHd = idHd;
            HoaDon hd = QLBLLHoadon.Instance.GetHoaDonById(idHd);
            PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByMaHoaDon(idHd);
            txtTenPhong.Text = pt.TenPhongTro;
            // Định dạng số tiền theo tiền tệ VND
            txtTongTien.Text = QLBLLChung.Instance.ChuyenDoiSangKieuTien(hd.TongTien);
            txtConNo.Text = (QLBLLChung.Instance.ChuyenDoiTienSangDouble(txtTongTien.Text) - hd.DaThanhToan).ToString("C0", vietnamCulture);
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
                    HoaDon hd = QLBLLHoadon.Instance.GetHoaDonById(this.IdHd);
                    ChiTietThanhToanHoaDon ct = new ChiTietThanhToanHoaDon()
                    {
                        MaHoaDon = hd.MaHoaDon,
                        MaChiTietThanhToanHoaDon = QLBLLChiTietThanhToanHoaDon.Instance.TaoIdChiTietThanhToanHoaDon(),
                        NgayThanhToan = NgayThanhToan.Value.ToString("yyyy-MM-dd"),
                        TienThanhToan = thanhToan,
                        TonTai = true
                    };
                    // Cập nhật số tiền đã thanh toán
                   
                    double TongTien = QLBLLChung.Instance.ChuyenDoiTienSangDouble(txtTongTien.Text);
                    double conNoMoi1 = QLBLLChung.Instance.ChuyenDoiTienSangDouble(txtConNo.Text);
                    // Tính số tiền còn nợ mới
                    if (thanhToan < conNoMoi1)
                    {
                        conNoMoi1 = QLBLLChung.Instance.ChuyenDoiTienSangDouble(txtTongTien.Text) - hd.DaThanhToan;
                        // Cập nhật giá trị cho txtConNo
                        txtConNo.Text = QLBLLChung.Instance.ChuyenDoiSangKieuTien(conNoMoi1);
                        QLBLLChiTietThanhToanHoaDon.Instance.AddChiTietThanhToanHoaDonBll(ct);
                        if (conNoMoi1 == 0)
                        {
                            MessageBox.Show("Đã trả đủ tiền", "Thông báo");
                        }
                        hd.DaThanhToan += thanhToan;
                        QLBLLHoadon.Instance.UpdateHoaDonBLL(hd);

                    }
                    else 
                    {
                        hd.DaThanhToan += conNoMoi1;
                        QLBLLHoadon.Instance.UpdateHoaDonBLL(hd);
                        ct.TienThanhToan = conNoMoi1;
                        double tiendu = thanhToan - conNoMoi1 ;
                        string tienthua = "Tiền phòng còn dư của bạn là : " + QLBLLChung.Instance.ChuyenDoiSangKieuTien(tiendu);                       
                        MessageBox.Show(tienthua, "Thông báo");
                        conNoMoi1 = 0;
                        txtConNo.Text = QLBLLChung.Instance.ChuyenDoiSangKieuTien(conNoMoi1);
                        QLBLLChiTietThanhToanHoaDon.Instance.AddChiTietThanhToanHoaDonBll(ct);
                      
                    }
                    MessageBox.Show("Thanh toán Hóa Đơn thành công", "Thông báo");
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
        private void txtThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            QLBLLChung.Instance.ChiChoPhepNhapSo(sender, e);
        }
    }
}
