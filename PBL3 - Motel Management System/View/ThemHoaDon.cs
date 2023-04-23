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
            QLBLL qLBLL = new QLBLL();
            HopDong hd = qLBLL.GetHopDongByIdPhong(idPhong);
            DateTime dt1 = DateTime.ParseExact(hd.NgayBatDau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dt2 = DateTime.ParseExact(hd.NgayKetThuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dtStart = new DateTime(dt1.Year, dt1.Month, 1);
            DateTime dtEnd = new DateTime(dt2.Year, dt2.Month, 1);
            dtpThangThanhToan.MinDate = dtStart;
            dtpThangThanhToan.MaxDate = dtEnd;


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
            string idPhong = ((ViewCbb)cbbPhongTro.SelectedItem).IdDayTro;
            string thang = dtpThangThanhToan.Value.ToString("MM-yyyy");
            LoadDgv(idPhong, thang);
        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            cbbPhongTro.Items.Clear();
            string id = ((ViewCbb)cbbDayTro.SelectedItem).IdDayTro;
            if (id == "0")
            {

                foreach (PhongTro pt in qLBLL.GetAllPhongTro())
                {
                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro = pt.MaPhongTro, TenDayTro = pt.TenPhongTro });
                }
            }
            else
            {
                foreach (ViewPhongTro pt in qLBLL.GetAllPhongTroByIdDay(id))
                {
                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro=pt.MaPhongTro, TenDayTro=pt.TenPhongTro });
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
    }
}
