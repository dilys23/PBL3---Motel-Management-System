using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ThemCSNuoc : Form
    {
        private Loader loader;
        public ThemCSNuoc(Loader loader)
        {
            InitializeComponent();
            SetCbb();
            this.loader = loader;
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            cbbPhongTro.Items.Clear();
            cbbPhongTro.Items.Add(new ViewCbb { key = "-1", value = "All" });
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            if (id == "0")
            {

                foreach (PhongTro pt in qLBLL.GetAllPhongTro())
                {
                    if(qLBLL.TinhTrangPhongById(pt.MaPhongTro))
                    {

                    cbbPhongTro.Items.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            else
            {
                foreach (string idp in qLBLL.GetAllPhongTroByIdDay(id))
                {
                    PhongTro pt = qLBLL.GetPhongTroByIdPhong(idp);
                    if(qLBLL.TinhTrangPhongById(pt.MaPhongTro))
                    {

                    cbbPhongTro.Items.Add(new ViewCbb {key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            if (cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
        }
        private bool CheckHopLe()
        {
            bool status = true;
            errorProvider1.SetError(cbbPhongTro, "");
            errorProvider1.SetError(txtChiSoCu, "");
            errorProvider1.SetError(txtChiSoMoi, "");
            if (cbbPhongTro.SelectedIndex == 0)
            {
                errorProvider1.SetError(cbbPhongTro, "Vui lòng chọn phòng trọ");
                status = false;
            }
            if (txtChiSoCu.Text == "")
            {
                errorProvider1.SetError(txtChiSoCu, "Vui lòng nhập chỉ số cũ");
                status = false;
            }
            if (txtChiSoMoi.Text == "")
            {
                errorProvider1.SetError(txtChiSoMoi, "Vui lòng nhập chỉ số mới");
                status = false;
            }
            if (txtChiSoCu.Text != "")
            {
                if (!double.TryParse(txtChiSoCu.Text, out double d))
                {
                    errorProvider1.SetError(txtChiSoMoi, "Chỉ số cũ phải là một số");
                    status = false;
                }
            }
            if (txtChiSoMoi.Text != "")
            {
                if (!double.TryParse(txtChiSoMoi.Text, out double d))
                {
                    errorProvider1.SetError(txtChiSoMoi, "Chỉ số mới phải là một số");
                    status = false;
                }
            }

            return status;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (CheckHopLe())
            {
                QLBLL qLBLL = new QLBLL();
                string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                ChiTietSuDungDichVu dv = new ChiTietSuDungDichVu
                {
                    MaChiTietSuDungDichVu = qLBLL.TaoIdChiTietSuDungDichVu(),
                    MaCHiTietDichVu = qLBLL.GetIdCHiTietDichVuNuocByIdPhong(idPhong),
                    ChiSoCu = Convert.ToDouble(txtChiSoCu.Text),
                    ChiSoMoi = Convert.ToDouble(txtChiSoMoi.Text),
                    ThoiGian = dtpThang.Value.ToString("MM-yyyy"),
                    TinhTrang = false,
                    TonTai = true,
                    NgayLap = dtpNgayLap.Value.ToString("dd-MM-yyyy")
                };
                if (dv.ChiSoCu > dv.ChiSoMoi)
                {
                    MessageBox.Show("Chỉ số cũ phải bé hơn hoặc bằng chỉ số mới", "Thông báo");
                }
                else
                {
#pragma warning disable CS0168 // Variable is declared but never used
                    try
                    {

                        qLBLL.AddChiTietSuDungDichVuBLL(dv);
                        MessageBox.Show("Thêm chỉ số thành công");
                        this.Close();
                        this.loader(null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không hợp lệ");
                    }
#pragma warning restore CS0168 // Variable is declared but never used
                    

                    
                }

            }
        }

        private void cbbPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPhongTro.SelectedIndex != 0)
            {
                string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                QLBLL qLBLL = new QLBLL();
                HopDong hd = qLBLL.GetHopDongByIdPhong(idPhong);
                DateTime dt1 = DateTime.ParseExact(hd.NgayBatDau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dt2 = DateTime.ParseExact(hd.NgayKetThuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dtStart = new DateTime(dt1.Year, dt1.Month, 1);
                DateTime dtEnd = new DateTime(dt2.Year, dt2.Month, 1);
                dtpThang.MinDate = dtStart;
                dtpThang.MaxDate = dtEnd;
            }
        }
    }
}
