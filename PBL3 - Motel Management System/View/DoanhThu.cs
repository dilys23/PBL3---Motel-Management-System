using LiveCharts;
using LiveCharts.Charts;
using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL3___Motel_Management_System
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
            LoadForm(dtpThang.Value.ToString("MM-yyyy"));
            ResizeColumn();
            LoadForm2(dtpThang.Value.ToString("MM-yyyy"));
            
        }
        public void LoadForm(string thang)
        {
            dgvDoanhThu.Rows.Clear();
            QLBLL qLBLL = new QLBLL();
            
            int i = 0;
            foreach (string hd in qLBLL.GetHoaDonByThangChiTra(thang))
            {
                HoaDon hoadon = qLBLL.GetHoaDonById(hd);
                PhongTro pt = qLBLL.GetPhongTroByMaHoaDon(hoadon.MaHoaDon);
                DayTro dt = qLBLL.GetDayTroByIdPhong(pt.MaPhongTro);
                dgvDoanhThu.Rows.Add(hoadon.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro,hoadon.TongTien);
            }
        }
        public void LoadForm2(string thang)
        {
            dataGridView1.Rows.Clear();
            QLBLL qLBLL = new QLBLL();
            int i = 0;
          
                foreach(string hd in qLBLL.GetHoaDonByThangChiTra(thang))
                {
                    HoaDon hoadon = qLBLL.GetHoaDonById(hd);
                    PhongTro pt = qLBLL.GetPhongTroByMaHoaDon(hoadon.MaHoaDon);
                    DayTro daytro = qLBLL.GetDayTroByIdPhong(pt.MaPhongTro);              
                    dataGridView1.Rows.Add(hoadon.MaHoaDon, ++i, daytro.TenDayTro, qLBLL.GetTongTien(daytro.MaDayTro));
                }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           // string daytro = ((ViewCbb)cbbDayTro.SelectedItem).key;
            string thang = dtpThang.Value.ToString("MM-yyyy");
            DateTime date = DateTime.ParseExact(thang, "MM-yyyy", CultureInfo.InvariantCulture);
            int nam = date.Year;
            LoadForm(thang);
            ThongKe(thang);
            //   BDCot(nam.ToString());
         //   BDDuong(nam.ToString());

        }
        public void ResizeColumn()
        {
            dgvDoanhThu.Columns["STT"].Width = 50;
            dgvDoanhThu.Columns["DayTro"].Width = 240;
            dgvDoanhThu.Columns["PhongTro"].Width = 80;
            dgvDoanhThu.Columns["TongTien"].Width = 80;
        }

        private void panel2_SizeChanged(object sender, EventArgs e)
        {
           
            var dgvWidth = panel2.Width / 2 - 10;
            var dgvHeight = panel2.Height / 2 - 10;
            dgvDoanhThu.Size = new Size(dgvWidth, dgvHeight);
            ChartDuong.Size = new Size(dgvWidth, dgvHeight);
            ChartCot.Size = new Size(dgvWidth, dgvHeight);
            ChartDuong.Location = new Point(dgvWidth + 10, 5);
            dgvDoanhThu.Location = new Point(5, dgvHeight + 10);
            ChartCot.Location = new Point(dgvWidth + 10, dgvHeight + 10);
        }
        

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            string thang = dtpThang.Value.ToString("MM-yyyy");
            DateTime date = DateTime.ParseExact(thang, "MM-yyyy", CultureInfo.InvariantCulture);
            int nam = date.Year;
            LoadForm(thang);
            ThongKe(thang);
            //BDCot(thang,nam.ToString());
            //BDDuong(nam.ToString());

        }
        public void ThongKe(string thang)
        {
            QLBLL qLBLL = new QLBLL();
            ChartCot.Series[0].XValueMember = "TenDayTro";
            ChartCot.Series[0].YValueMembers = "TongTien";
            List<object> data = new List<object>(); 

            
                ChartCot.DataSource = qLBLL.ThongKe(thang);
                ChartCot.ChartAreas[0].AxisX.Title = "Dãy trọ";
                ChartCot.ChartAreas[0].AxisY.Title = "Tổng tiền";
            
            ChartCot.DataBind();
            
        }
       

    }
}
