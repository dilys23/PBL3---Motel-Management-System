﻿using LiveCharts;
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
            //ResizeColumn();
        }
        public void LoadForm(string thang)
        {
            dgvDoanhThu.Rows.Clear();
            int i = 0;
            if(thang==null)
            {
                foreach (HoaDon hoadon in QLBLLHoadon.Instance.GetAllHoaDonBll())
                {
                    //HoaDon hoadon = QLBLL.Instance.GetHoaDonById(hd);
                    if (hoadon.TinhTrang == true)
                    {
                        PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByMaHoaDon(hoadon.MaHoaDon);
                        DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(pt.MaPhongTro);
                        if (hoadon.DaThanhToan != 0)
                        { dgvDoanhThu.Rows.Add(hoadon.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro, hoadon.DaThanhToan); }
                    }

                }
            }
            else
            {
                foreach (string hd in QLBLLHoadon.Instance.GetHoaDonByThangChiTra(thang))
                {
                    HoaDon hoadon = QLBLLHoadon.Instance.GetHoaDonById(hd);
                    if (hoadon.TinhTrang == true)
                    {
                        PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByMaHoaDon(hoadon.MaHoaDon);
                        DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(pt.MaPhongTro);
                        if (hoadon.DaThanhToan != 0)
                        { dgvDoanhThu.Rows.Add(hoadon.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro, hoadon.DaThanhToan); }
                    }
                }
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
            ThongKeTheoThang(nam.ToString());
        }
        public void ResizeColumn()
        {
            dgvDoanhThu.Columns["STT"].Width = 50;
            dgvDoanhThu.Columns["DayTro"].Width = 240;
            dgvDoanhThu.Columns["PhongTro"].Width = 80;
            dgvDoanhThu.Columns["DaThanhToan"].Width = 80;
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
            LoadForm(null);
            ThongKe(thang);
            ThongKeTheoThang(nam.ToString());

        }
        public void ThongKe(string thang)
        {
            ChartCot.Series[0].XValueMember = "TenDayTro";
            ChartCot.Series[0].YValueMembers = "TongTien";
            //List<object> data = new List<object>(); 
            ChartCot.DataSource = QLBLLChung.Instance.ThongKe(thang);
            ChartCot.ChartAreas[0].AxisX.Title = "Dãy trọ";
            ChartCot.ChartAreas[0].AxisY.Title = "Tổng tiền";
            ChartCot.DataBind();

        }
        public void ThongKeTheoThang(string nam)
        {    
            var thongke = QLBLLChung.Instance.ThongKeTongTienTheoThang(nam);
            ChartDuong.Series[0].XValueMember = "Key";
            ChartDuong.Series[0].YValueMembers = "Value";
            ChartDuong.DataSource = thongke;
            ChartDuong.ChartAreas[0].AxisX.Title = "Tháng";
            ChartDuong.ChartAreas[0].AxisY.Title = "Tổng tiền";
            ChartDuong.DataBind();
        }
    }
}
