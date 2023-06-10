using Bunifu.UI.WinForms.Helpers.Transitions;
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
using System.Web;
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
        CultureInfo vietnamCulture = new CultureInfo("vi-VN");
        public void LoadForm(string thang)
        {
            dgvDoanhThu.Rows.Clear();
            int i = 0;
            if(thang==null)
            {
                foreach (PhongTro pt in QLBLLPhongTro.Instance.GetAllPhongTro())
                {
                        DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(pt.MaPhongTro);
                        dgvDoanhThu.Rows.Add(0, ++i, dt.TenDayTro, pt.TenPhongTro, QLBLLHoadon.Instance.GetDoanhThuChoPhong(pt.MaPhongTro).ToString("C0", vietnamCulture)); 
                }
            }
            else
            {
                foreach (PhongTro pt in QLBLLPhongTro.Instance.GetAllPhongTro())
                {
                    DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(pt.MaPhongTro);
                    dgvDoanhThu.Rows.Add(0, ++i, dt.TenDayTro, pt.TenPhongTro, QLBLLHoadon.Instance.GetDoanhThuChoPhongByThangCt(pt.MaPhongTro, thang).ToString("C0", vietnamCulture));
                }
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            // string daytro = ((ViewCbb)cbbDayTro.SelectedItem).key;
            int index = comboBox1.SelectedIndex;
            int index1 = comboBox2.SelectedIndex;
            string thang = dtpThang.Value.ToString("MM-yyyy");
            DateTime date = DateTime.ParseExact(thang, "MM-yyyy", CultureInfo.InvariantCulture);
            int nam = date.Year;

            if (index == 0)
            {
                SetPhong();
                ThongKeTheoPhong();
            }
            else
            {
                int tong = QLBLLChung.Instance.TinhTongThanhVien();
                label2.Text = "     Dãy trọ có " + tong + " thành viên  ";
                ThongKeThanhVien();
            }
            if (index1==0)
            {
                LoadForm(thang);
                label1.Text = "     Doanh thu của tháng "+thang.ToString()+ " là: ";
                textBox1.Text = Doanhthu().ToString("C0", vietnamCulture);
                ThongKe(thang);
            }    
            else
            {
                LoadForm(null);
                label1.Text = "     Doanh thu của năm " + nam.ToString() + " là: ";
                textBox1.Text = Doanhthu().ToString("C0", vietnamCulture);
                ThongKeTheoThang(nam.ToString());
            } 
            
            
        }
        private void panel2_SizeChanged(object sender, EventArgs e)
        {
           
            var dgvWidth = panel2.Width / 2 - 10;
            var dgvHeight = panel2.Height / 2 - 10;
            dgvDoanhThu.Size = new Size(dgvWidth, dgvHeight);
            ChartDuong.Size = new Size(Math.Max(0, dgvWidth),Math.Max(0, dgvHeight));
            ChartCot.Size = new Size(Math.Max(0, dgvWidth), Math.Max(0, dgvHeight));
            ChartDuong.Location = new Point(dgvWidth + 10, 5);
            dgvDoanhThu.Location = new Point(5, dgvHeight + 10);
            ChartCot.Location = new Point(dgvWidth + 10, dgvHeight + 10);
        }

        public void SetPhong()
        {
            Dictionary<string, int> thongKe = QLBLLPhongTro.Instance.ThongKeTinhTrangPhongTro();
            int slPhongCoc = thongKe["Đã cọc"];
            int slPhongChoThue = thongKe["Cho thuê"];
            int slPhongTrong = thongKe["Còn trống"];
            List<string> icons = new List<string>() { "✔", "✖", "▲" };

            string noiDungLabel = $"     Dãy trọ có \n";
            noiDungLabel += $" {icons[0]}{slPhongCoc} phòng đã cọc  \n";
            noiDungLabel += $" {icons[1]}{slPhongChoThue} phòng cho thuê            \n";
            noiDungLabel += $" {icons[2]}{slPhongTrong} phòng còn trống    ";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Text = noiDungLabel;
        }


        public double Doanhthu()
        {
            double sum=0;
            foreach(DataGridViewRow dr in dgvDoanhThu.Rows)
            {
               
                sum += Convert.ToDouble(dr.Cells[4].Value.ToString().Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", ""));
            }
            return sum;
        }
        private void DoanhThu_Load(object sender, EventArgs e)
        {
            string thang = dtpThang.Value.ToString("MM-yyyy");
            DateTime date = DateTime.ParseExact(thang, "MM-yyyy", CultureInfo.InvariantCulture);
            int nam = date.Year;
            LoadForm(null);
            ThongKeTheoThang(nam.ToString());
            label1.Text = "     Doanh thu năm " + nam.ToString() + " là: ";
            textBox1.Text = Doanhthu().ToString("C0", vietnamCulture);
            ThongKeTheoPhong();SetPhong();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;

        }
        public void ThongKe(string thang)
        {
            ChartCot.Series[0].XValueMember = "TenDayTro";
            ChartCot.Series[0].YValueMembers = "TongTien";
            ChartCot.Series[0].Name = "Dãy trọ";
            ChartCot.DataSource = QLBLLChung.Instance.ThongKe(thang);
           
            ChartCot.ChartAreas[0].AxisX.Title = "Dãy trọ";
            ChartCot.ChartAreas[0].AxisY.Title = "Tổng tiền";
            ChartCot.DataBind();

        }
        public void ThongKeTheoThang(string nam)
        {    
            var thongke = QLBLLChung.Instance.ThongKeTongTienTheoThang(nam);
            ChartCot.Series[0].XValueMember = "Key";
            ChartCot.Series[0].YValueMembers = "Value";
            ChartCot.DataSource = thongke;
            ChartCot.Series[0].Name = "Tháng";
            ChartCot.ChartAreas[0].AxisX.Title = "Tháng";
            ChartCot.ChartAreas[0].AxisY.Title = "Tổng tiền";
            ChartCot.DataBind();
        }
        public void ThongKeTheoPhong()
        {
            var thongke = QLBLLPhongTro.Instance.ThongKeTinhTrangPhongTro();
            ChartDuong.Series[0].XValueMember = "Key";
            ChartDuong.Series[0].YValueMembers = "Value";
            ChartDuong.DataSource = thongke;
            ChartDuong.Series[0].Name = "Tình trạng";
            ChartDuong.ChartAreas[0].AxisX.Title = "Tình trạng";
            ChartDuong.ChartAreas[0].AxisY.Title = "Số lượng";
            ChartDuong.DataBind();
        }
        public void ThongKeThanhVien()
        {
            var thongke = QLBLLChung.Instance.ThongKeThanhVien();
            ChartDuong.Series[0].XValueMember = "Key";
            ChartDuong.Series[0].YValueMembers = "Value";
            ChartDuong.DataSource = thongke;
            ChartDuong.Series[0].Name = "Dãy trọ";
            ChartDuong.ChartAreas[0].AxisX.Title = "Dãy trọ";
            ChartDuong.ChartAreas[0].AxisY.Title = "Số lượng thành viên";
            ChartDuong.DataBind();
        }
    
    }
}
