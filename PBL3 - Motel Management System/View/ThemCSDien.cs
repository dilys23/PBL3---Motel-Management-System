using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
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
    public partial class ThemCSDien : Form
    {
        private string IdSudungDV;
        private Loader loader;
        public ThemCSDien(string IdSudungDV, Loader loader)
        {
            InitializeComponent();
            SetCbb();
            this.IdSudungDV = IdSudungDV;
            this.loader=loader;
            if(IdSudungDV != null )
            {
                SetGUI();
            }
            
        }
       public void SetGUI()
        {
            ChiTietSuDungDichVu cs = QLBLL.Instance.GetChiTietSudungDichVuById(IdSudungDV);
            ChiTietDichVu ct = QLBLL.Instance.GetChiTietDichVuById(cs.MaCHiTietDichVu);
            PhongTro pt = QLBLL.Instance.GetPhongTroByIdPhong(ct.MaPhongTro);
            DayTro dt = QLBLL.Instance.GetDayByIdDay(pt.MaDayTro);
            cbbDayTro.Text = dt.TenDayTro;
            cbbPhongTro.Text = pt.TenPhongTro;
            txtChiSoCu.Text = cs.ChiSoCu.ToString();
            txtChiSoMoi.Text = cs.ChiSoMoi.ToString();
            dtpNgayLap.Value = DateTime.ParseExact(cs.NgayLap, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
            dtpThang.Value = DateTime.ParseExact(cs.ThoiGian, "MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }
        
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            cbbDayTro.Items.AddRange(QLBLL.Instance.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
            
        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPhongTro.Items.Clear();
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            cbbPhongTro.Items.AddRange(QLBLL.Instance.GetViewCbbPhongByDay(id).ToArray());
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
            if(cbbPhongTro.SelectedIndex == 0)
            {
                errorProvider1.SetError(cbbPhongTro, "Vui lòng chọn phòng trọ");
                status = false;
            }
            if(txtChiSoCu.Text == "")
            {
                errorProvider1.SetError(txtChiSoCu, "Vui lòng nhập chỉ số cũ");
                status = false;
            }
            if (txtChiSoMoi.Text == "")
            {
                errorProvider1.SetError(txtChiSoMoi, "Vui lòng nhập chỉ số mới");
                status = false;
            }
            if(txtChiSoCu.Text != "")
            {
                if(!double.TryParse(txtChiSoCu.Text, out double d))
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
            if (IdSudungDV != null)
            {
                if (CheckHopLe())
                {
                    double csCu = Convert.ToDouble(txtChiSoCu.Text);
                    double csMoi = Convert.ToDouble(txtChiSoMoi.Text);
                    if (csCu > csMoi)
                    {
                        MessageBox.Show("Chỉ số cũ lớn hơn chỉ số mới", "Thông báo");
                        return;
                    }
                    else
                    {
                        ChiTietSuDungDichVu cs = QLBLL.Instance.GetChiTietSudungDichVuById(this.IdSudungDV);
                        cs.ChiSoCu = Convert.ToDouble(txtChiSoCu.Text);
                        cs.ChiSoMoi = Convert.ToDouble(txtChiSoMoi.Text);
                        cs.TonTai = true;
                        QLBLL.Instance.UpdateChiTietSuDungDichVu(cs);
                        MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                        loader(null);
                        this.Close();
                    }
                }
            }
            else
            {
                if (CheckHopLe())
                {
                    string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                    ChiTietSuDungDichVu dv = new ChiTietSuDungDichVu
                    {
                        MaChiTietSuDungDichVu = QLBLL.Instance.TaoIdChiTietSuDungDichVu(),
                        MaCHiTietDichVu = QLBLL.Instance.GetIdCHiTietDichVuDienByIdPhong(idPhong),
                        ChiSoCu = Convert.ToDouble(txtChiSoCu.Text),
                        ChiSoMoi = Convert.ToDouble(txtChiSoMoi.Text),
                        ThoiGian = dtpThang.Value.ToString("MM-yyyy"),
                        TinhTrang = false,
                        TonTai = true,
                        NgayLap = dtpNgayLap.Value.ToString("dd-MM-yyyy"),
                    };
                    if (dv.ChiSoCu > dv.ChiSoMoi)
                    {
                        MessageBox.Show("Chỉ số cũ phải bé hơn hoặc bằng chỉ số mới", "Thông báo");
                    }
                    else
                    {
                        try
                        {
                            QLBLL.Instance.AddChiTietSuDungDichVuBLL(dv);
                            MessageBox.Show("thêm chỉ số thành công");
                            this.Close();
                            this.loader(null);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("không hợp lệ");
                        }

                    }
                }
            }
        }

        private void cbbPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbPhongTro.SelectedIndex != 0)
            {
                string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                HopDong hd = QLBLL.Instance.GetHopDongByIdPhong(idPhong);
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
