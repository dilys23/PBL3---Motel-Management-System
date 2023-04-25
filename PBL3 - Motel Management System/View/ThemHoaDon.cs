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
using System.Windows.Controls;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ThemHoaDon : Form
    {
        public ThemHoaDon()
        {
            InitializeComponent();
            SetCBB();
            LoadForm();
        }
        private void SetCBB()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
        }
        private void LoadForm()
        {

        }
        private void LoadDgv(string idPhong, string thang)
        {
            dgvDichVu.Rows.Clear();
            txtGiamGia.Text = "0";
            QLBLL qLBLL = new QLBLL();
            HopDong hd = qLBLL.GetHopDongByIdPhong(idPhong);
            DateTime dt1 = DateTime.ParseExact(hd.NgayBatDau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact(hd.NgayKetThuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dtStart = new DateTime(dt1.Year, dt1.Month, 1);
            DateTime dtEnd = new DateTime(dt2.Year, dt2.Month, 1);
            dtpThangThanhToan.MinDate = dtStart;
            dtpThangThanhToan.MaxDate = dtEnd;
            PhongTro pt = qLBLL.GetPhongTroByIdPhong(idPhong);
            txtTienPhong.Text = pt.GiaTien.ToString();
            int i = 0;
            bool status = false;
            foreach(ChiTietDichVu ctdv in qLBLL.GetChiTietDichVuByIdPhong(idPhong))
            {
                if(ctdv.MaDichVu != "001" && ctdv.MaDichVu != "000")
                {
                    DichVu dv = qLBLL.GetDichVuByIdDichVu(ctdv.MaDichVu);
                    dgvDichVu.Rows.Add(++i, dv.TenDichVu, dv.GiaDichVu, 0, 0, dv.GiaDichVu, "Chọn");
                }
                else if(!status)
                {
                    status = true;
                    List<ChiTietSuDungDichVu> list = qLBLL.GetChiTietSuDungDichVuTimKiem(thang, "0", idPhong, "1");
                    foreach(ChiTietSuDungDichVu dv in list)
                    {
                        ChiTietDichVu ct = qLBLL.GetChiTietDichVuById(dv.MaCHiTietDichVu);
                        DichVu dv1 = qLBLL.GetDichVuByIdDichVu(ct.MaDichVu);
                        dgvDichVu.Rows.Add(++i, dv1.TenDichVu, dv1.GiaDichVu, dv.ChiSoCu, dv.ChiSoMoi, (dv.ChiSoMoi-dv.ChiSoCu)*dv1.GiaDichVu, "Chọn");
                    }

                }
                

            }
            SetTxtTienDichVu();



        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // Lấy tháng và năm được chọn
            int month = dtpThangThanhToan.Value.Month;
            int year = dtpThangThanhToan.Value.Year;

            // Tạo ngày đầu tiên của tháng và năm được chọn
            DateTime date = new DateTime(year, month, 1);

            // Gán ngày đó cho DateTimePicker
            dtpThangThanhToan.Value = date;
            try
            {

            string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).IdDayTro;
            string thang = dtpThangThanhToan.Value.ToString("MM-yyyy");
            LoadDgv(idPhong, thang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dãy hiện tại chưa có phòng để cho thuê");
            }
        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPhongTro.Items.Clear();
            
            QLBLL qLBLL = new QLBLL();
            cbbPhongTro.Items.Clear();
            string id = ((ViewCbb)cbbDayTro.SelectedItem).IdDayTro;
            if (id == "0")
            {

                foreach (PhongTro pt in qLBLL.GetAllPhongTro())
                {
                    if(qLBLL.TinhTrangPhongById(pt.MaPhongTro))
                    {
                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro = pt.MaPhongTro, TenDayTro = pt.TenPhongTro });
                    }
                }
            }
            else
            {
                foreach (ViewPhongTro pt in qLBLL.GetAllPhongTroByIdDay(id))
                {
                    if(qLBLL.TinhTrangPhongById(pt.MaPhongTro))
                    {

                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro=pt.MaPhongTro, TenDayTro=pt.TenPhongTro });
                    }
                }
            }
            if (cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
        }

        private void cbbPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).IdDayTro;
            string thang = dtpThangThanhToan.Value.ToString("MM-yyyy");
            LoadDgv(idPhong, thang);
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            dgvDichVu.CurrentRow.Cells[6].Value = "Chọn";
            SetTxtTienDichVu();
        }
        private void SetTxtTienDichVu()
        {
            double TienDichVu = 0;
            foreach (DataGridViewRow dr in dgvDichVu.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    if (dr.Cells[6].Value.ToString()=="Chọn")
                    {
                        double tien = Convert.ToDouble(dr.Cells[5].Value.ToString());
                        TienDichVu += tien;
                    }
                }
            }
            txtTienDichVu.Text = TienDichVu.ToString();
            
            
            
        }
        private void btnBoChon_Click(object sender, EventArgs e)
        {
            dgvDichVu.CurrentRow.Cells[6].Value = "Hủy";
            SetTxtTienDichVu();
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
