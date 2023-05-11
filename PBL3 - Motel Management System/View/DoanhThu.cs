using LiveCharts;
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
            
        }
        public void LoadForm(string thang)
        {
            dgvDoanhThu.Rows.Clear();
            QLBLL qLBLL = new QLBLL();
            
            int i = 0;
            foreach (string hd in qLBLL.GetHoaDonByThangChiTra(thang))
            {
                HoaDon hoadon = qLBLL.GetHoaDonById(hd);
                PhongTro pt = qLBLL.GetPhongTroByMaHD(hoadon.MaHoaDon);
                DayTro dt = qLBLL.GetDayTroByIdPhong(pt.MaPhongTro);
                dgvDoanhThu.Rows.Add(hoadon.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro,hoadon.TongTien);
            }
        
          
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           // string daytro = ((ViewCbb)cbbDayTro.SelectedItem).IdDayTro;
            string thang = dtpThang.Value.ToString("MM-yyyy");
            LoadForm(thang);


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

            ChartDuong.BackColor = Color.White;
            var series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.Color = Color.Blue;
            series.Points.AddXY(1, 2);
            series.Points.AddXY(2, 3);
            series.Points.AddXY(3, 1);
            series.Points.AddXY(4, 5);
            series.Points.AddXY(5, 4);
            //dgvDoanhThu.DataSource = new List<HoaDon>();
            //ChartDuong.AxisX.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Tháng",
            //    Labels = new[] { "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "T10", "T11", "T12" }
            //});
            //ChartDuong.AxisY.Add(new LiveCharts.Wpf.Axis
            //{
            //    Title = "Dãy",
            //    LabelFormatter = value => value.ToString("C")
            //});
            //ChartDuong.LegendLocation = LiveCharts.LegendLocation.Right;

        }

    }
}
