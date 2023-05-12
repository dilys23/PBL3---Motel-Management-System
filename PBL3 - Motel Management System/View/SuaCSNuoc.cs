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

namespace PBL3___Motel_Management_System.View
{
    public partial class SuaCSNuoc : Form
    {
        private string IdCs;
        private Loader Loader;
        public SuaCSNuoc(string idCs, Loader loader)
        {
            InitializeComponent();
            this.IdCs = idCs;
            this.Loader = loader;
            QLBLL qLBLL = new QLBLL();
            ChiTietSuDungDichVu cs = qLBLL.GetChiTietSudungDichVuById(idCs);
            ChiTietDichVu ct = qLBLL.GetChiTietDichVuById(cs.MaCHiTietDichVu);
            PhongTro pt = qLBLL.GetPhongTroByIdPhong(ct.MaPhongTro);
            DayTro dt = qLBLL.GetDayByIdDay(pt.MaDayTro);
            txtDay.Text = dt.TenDayTro;
            txtPhong.Text = pt.TenPhongTro;
            txtCsCu.Text = cs.ChiSoCu.ToString();
            txtCsMoi.Text = cs.ChiSoMoi.ToString();
            dtThang.Value = DateTime.ParseExact(cs.NgayLap, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dtThangsudung.Value = DateTime.ParseExact(cs.ThoiGian, "MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtDay, "");
            errorProvider1.SetError(txtPhong, "");
            errorProvider1.SetError(txtCsMoi, "");
            errorProvider1.SetError(txtCsCu, "");
            errorProvider1.SetError(dtThang, "");
            if (txtDay.Text == "")
            {
                i++;
                errorProvider1.SetError(txtDay, "Vui lòng điền Day");
            }
            if (txtPhong.Text == "")
            {
                i++;
                errorProvider1.SetError(txtPhong, "Vui lòng điền Phong");
            }
            if (txtCsMoi.Text == "")
            {
                i++;
                errorProvider1.SetError(txtCsMoi, "Vui lòng điền chi so moi");
            }
            if (txtCsCu.Text == "")
            {
                i++;
                errorProvider1.SetError(txtCsCu, "Vui lòng điền chi so cu");
            }
            if (dtThang.Text == "")
            {
                i++;
                errorProvider1.SetError(dtThang, "Vui lòng điền Thang su dung");
            }

            if (txtCsCu.Text != "")
            {
                if (!double.TryParse(txtCsCu.Text, out double d))
                {
                    i++;
                    errorProvider1.SetError(txtCsCu, "Chi so phải bằng số");

                }
            }
            if (txtCsMoi.Text != "")
            {
                if (!double.TryParse(txtCsMoi.Text, out double d))
                {
                    i++;
                    errorProvider1.SetError(txtCsMoi, "Chi so phải bằng số");

                }
            }

            if (i == 0) return true;
            return false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkHopLe())
            {
                double csCu = Convert.ToDouble(txtCsCu.Text);
                double csMoi = Convert.ToDouble(txtCsMoi.Text);
                if (csCu > csMoi)
                {
                    MessageBox.Show("chỉ số cũ lớn hơn chỉ số mới", "Thông báo");
                    return;
                }
                else
                {
                    QLBLL qLBLL = new QLBLL();
                    ChiTietSuDungDichVu cs = qLBLL.GetChiTietSudungDichVuById(this.IdCs);
                    //cs.MaCHiTietDichVu = IdCs;
                    cs.ChiSoCu = Convert.ToDouble(txtCsCu.Text);
                    cs.ChiSoMoi = Convert.ToDouble(txtCsMoi.Text);
                    qLBLL.UpdateChiTietSuDungDichVu(cs);
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                    Loader(null);
                    this.Close();
                }

            }
        }
    }
}
