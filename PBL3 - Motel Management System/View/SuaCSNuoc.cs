using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class SuaCSNuoc : Form
    {
        private string MaCT;
        private Loader loader;
        public SuaCSNuoc(string MaCT,Loader loader)
        {
            InitializeComponent();
            this.MaCT = MaCT;
            this.loader = loader;
            SetGUI();
        }
        public void SetGUI()
        {
            if (MaCT != null)
            {
                QLBLL qLBLL = new QLBLL();
                ChiTietSuDungDichVu ctdv = qLBLL.GetChiTietSuDungDichVuByIdBLL(MaCT);
                ChiTietDichVu chitiet = qLBLL.GetChiTietDichVuById(ctdv.MaCHiTietDichVu);
                txtDay.Text = qLBLL.GetDayTroByIdPhong(chitiet.MaPhongTro).TenDayTro;
                txtPhong.Text = qLBLL.GetPhongTroByIdPhong(chitiet.MaPhongTro).TenPhongTro;
                txtChiSoMoi.Text = Convert.ToDouble(ctdv.ChiSoMoi).ToString();
                txtChiSoCu.Text = Convert.ToDouble(ctdv.ChiSoCu).ToString();
                dtpThang.Value = Convert.ToDateTime(ctdv.ThoiGian);
                dtpNgayLap.Value = Convert.ToDateTime(ctdv.NgayLap);
            }
        }
        private bool CheckHopLe()
        {
            bool status = true;

            errorProvider1.SetError(txtChiSoMoi, "");

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

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckHopLe())
            {
                QLBLL qLBLL = new QLBLL();
                ChiTietSuDungDichVu ctdv = qLBLL.GetChiTietSuDungDichVuByIdBLL(MaCT);
                ChiTietDichVu chitiet = qLBLL.GetChiTietDichVuById(ctdv.MaCHiTietDichVu);
                ChiTietSuDungDichVu ctsd = new ChiTietSuDungDichVu
                {
                    MaChiTietSuDungDichVu = MaCT,
                    MaCHiTietDichVu = chitiet.MaChiTietDichVu,
                    ChiSoCu = Convert.ToDouble(txtChiSoCu.Text),
                    ChiSoMoi = Convert.ToDouble(txtChiSoMoi.Text),
                    ThoiGian = dtpThang.Value.ToString("MM-yyyy"),
                    TinhTrang = false,
                    NgayLap = dtpNgayLap.Value.ToString("dd-MM-yyyy")
                };
                if (ctsd.ChiSoCu > ctsd.ChiSoMoi)
                {
                    MessageBox.Show("Chỉ số cũ phải bé hơn hoặc bằng chỉ số mới", "Thông báo");

                }
                else
                {
                    try
                    {
                        qLBLL.UpdateChiTietSuDungDichVu(ctsd);
                        MessageBox.Show("Thay đổi chỉ số thành công");
                        this.Close();
                        this.loader(null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không hợp lệ");
                    }


                }
            }
        }
    }
}
