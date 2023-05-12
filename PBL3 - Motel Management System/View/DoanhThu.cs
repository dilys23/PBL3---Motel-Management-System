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

        private void btnTim_Click(object sender, EventArgs e)
        {
           // string daytro = ((ViewCbb)cbbDayTro.SelectedItem).key;
            string thang = dtpThang.Value.ToString("MM-yyyy");
            DateTime date = DateTime.ParseExact(thang, "MM-yyyy", CultureInfo.InvariantCulture);
            int nam = date.Year;
            LoadForm(thang);
            ThongKe(date);
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
            ThongKe(date);
            //BDCot(thang,nam.ToString());
            //BDDuong(nam.ToString());

        }
        public void ThongKe(DateTime thangnam)
        {
            QLBLL qLBLL = new QLBLL();
            ChartCot.Series[0].XValueMember = "MaDayTro";
            ChartCot.Series[0].YValueMembers = "TongTien";
            foreach (DayTro dt in qLBLL.GetAllDayTroBll())
            {
                ChartCot.DataSource = qLBLL.ThongKe(dt.MaDayTro, thangnam);
                
                //   ChartCot.ChartAreas[0].AxisX.IntervalType= DateTimeIntervalType.
                ChartCot.ChartAreas[0].AxisX.Title = "Dãy trọ";
                ChartCot.ChartAreas[0].AxisY.Title = "Tổng tiền";
            }
        }
        //public void BDDuong(string nam)
        //{
           
        //    ChartDuong.Series.Clear();
        //    QLBLL qLBLL = new QLBLL();
        //    List<DayTro> list = qLBLL.GetAllDayTroBll();
        //    foreach(DayTro dt in list)
        //    {
        //        Series series = ChartDuong.Series.Add(dt.TenDayTro);
        //        series.ChartType =SeriesChartType.Line;

        //        for(int  month=1; month <= 12; month++)
        //        {
        //            //double Tongtien = qLBLL.GetTongTien(dt.MaDayTro,month.ToString(), nam);
        //            //series.Points.AddXY(month, Tongtien);   
        //        }

        //    }
        //    ChartDuong.ChartAreas[0].AxisX.Interval = 1;
        //    ChartDuong.ChartAreas[0].AxisX.Minimum = 1;
        //    ChartDuong.ChartAreas[0].AxisX.Maximum = 12;
        //    ChartDuong.ChartAreas[0].AxisX.Title = "Tháng";
        //    ChartDuong.ChartAreas[0].AxisY.Title = "Tổng tiền";
        //}
        ////loop rows 
        //public void BDCot(string thang,string nam)
        //{

        //    ChartCot.Series.Clear();
        //    QLBLL qLBLL = new QLBLL();
        //    List<DayTro> list = qLBLL.GetAllDayTroBll();
            
        //    ChartCot.Titles.Add(new Title("Bieu do cot", Docking.Top, new Font("Times New Roman", 16, FontStyle.Bold), Color.Firebrick));
        //    ChartCot.Series.Add("Tên Dãy trọ");
        //    ChartCot.Series["Tên Dãy trọ"].ChartType = SeriesChartType.Column;
        //    ChartCot.Series["Tên Dãy trọ"].XValueType = ChartValueType.String;
        //    foreach(DayTro dt in list)
        //    {
        //      //  double tongtien = qLBLL.GetTongTien(dt.MaDayTro, thang, nam);
        //    //    ChartCot.Series["Tên Dãy trọ"].Points.AddXY(dt.TenDayTro, tongtien);
        //        ChartCot.Series[0]["PixelPointWidth"] = "30";
        //    }
        //    if (ChartCot.ChartAreas.Count == 0)
        //    {
        //        ChartArea area = new ChartArea();
        //        ChartCot.ChartAreas.Add(area);
        //        area.AxisX.CustomLabels.Clear();
        //        area.AxisX.Interval = 0.5;
        //        area.AxisX.IsMarginVisible = true;
        //        area.AxisX.Minimum = 0;
        //        area.AxisX.Maximum = list.Count + 1;
        //        //area.AxisX.Title = "Dãy trọ";
        //        area.AxisY.Title = "Tổng tiền";
        //    }

        //}

     

    }
}
