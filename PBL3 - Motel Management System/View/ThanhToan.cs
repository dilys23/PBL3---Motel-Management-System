using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            QLBLL qLBLL = new QLBLL();
            HoaDon hd = qLBLL.GetHoaDonById(idHd);
            PhongTro pt = qLBLL.GetPhongTroByMaHoaDon(idHd);
            txtTenPhong.Text = pt.TenPhongTro;
            txtTongTien.Text = hd.TongTien.ToString();
            txtConNo.Text = (Convert.ToDouble(txtTongTien.Text) - hd.DaThanhToan).ToString();

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
                double thanhToan = Convert.ToDouble(txtThanhToan.Text);

                QLBLL qLBLL = new QLBLL();
                HoaDon hd = qLBLL.GetHoaDonById(this.IdHd);

                // Cập nhật số tiền đã thanh toán
                hd.DaThanhToan += thanhToan;
                qLBLL.UpdateHoaDonBLL(hd);

                // Tính số tiền còn nợ mới
                double conNoMoi = Convert.ToDouble(txtTongTien.Text) - hd.DaThanhToan;

                // Cập nhật giá trị cho txtConNo
                txtConNo.Text = conNoMoi.ToString();

                if (conNoMoi == 0)
                {
                    MessageBox.Show("Đã trả đủ tiền", "Thông báo");
                }
                if (conNoMoi < 0)
                {
                    MessageBox.Show("Bạn đã nhập thừa tiền", "Thông báo");
                }

                loader(null);
                this.Close();
            }
        }
        private bool isMouseDown = false;
        private void txtThanhToan_MouseLeave_1(object sender, EventArgs e)
        {

            if (!isMouseDown)
            {
                isMouseDown = true;

                if (double.TryParse(txtThanhToan.Text, out double thanhToan))
                {
                    // Lấy số tiền còn nợ từ txtConNo
                    double conNoTruoc = Convert.ToDouble(txtConNo.Text);

                    // Tính số tiền còn lại (số tiền nợ mới)
                    double conNoMoi = conNoTruoc - thanhToan;

                    // Cập nhật giá trị cho txtConNo
                    txtConNo.Text = conNoMoi.ToString();

                    // Kiểm tra nếu số tiền còn lại là 0, hiển thị thông báo hoặc thực hiện các xử lý khác
                    if (conNoMoi == 0)
                    {
                        MessageBox.Show("Đã trả đủ tiền", "Thông báo");
                    }
                    if (conNoMoi < 0)
                    {
                        MessageBox.Show("Bạn đã nhập thừa tiền", "Thông báo");
                    }
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
    }
}
