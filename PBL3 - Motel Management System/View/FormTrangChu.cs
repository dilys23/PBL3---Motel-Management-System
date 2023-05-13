using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL3___Motel_Management_System.View
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
            LoadForm();
        }
        private void LoadForm()
        {
            QLBLL qLBLL = new QLBLL();
            dgvTinhTrang.RowCount = 0;
            dgvSoLuong.RowCount = 0;
            qLBLL.customDGV(dgvTinhTrang);
            qLBLL.customDGV(dgvSoLuong);
            int i = 0;
            foreach (string idp in qLBLL.DgvPhongTro(null))
            {
                PhongTro pt = qLBLL.GetPhongTroByIdPhong(idp);
                string TinhTrang;
                HopDong hd = qLBLL.GetHopDongByIdPhong(pt.MaPhongTro);
                if (hd == null) TinhTrang = "Còn trống";
                else if (hd.TinhTrang == true) TinhTrang = "Đã cho thuê";
                else TinhTrang = "Đã cọc";
                dgvTinhTrang.Rows.Add(pt.MaPhongTro, ++i, qLBLL.GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro, pt.TenPhongTro, TinhTrang);
            }
            List<string> phongTroList = qLBLL.DgvPhongTro(null);
            Dictionary<string, int> tinhTrangCounts = new Dictionary<string, int>();
            foreach (string idp in phongTroList)
            {
                PhongTro pt = qLBLL.GetPhongTroByIdPhong(idp);
                string tinhTrang;
                HopDong hd = qLBLL.GetHopDongByIdPhong(pt.MaPhongTro);
                if (hd == null) tinhTrang = "Còn trống";
                else if (hd.TinhTrang == true) tinhTrang = "Đã cho thuê";
                else tinhTrang = "Đang cọc";

                // Kiểm tra nếu tình trạng đã có trong Dictionary, tăng số lượng phòng lên 1
                if (tinhTrangCounts.ContainsKey(tinhTrang))
                {
                    tinhTrangCounts[tinhTrang]++;
                }
                else
                {
                    // Nếu tình trạng chưa có trong Dictionary, thêm mới và đặt số lượng phòng là 1
                    tinhTrangCounts.Add(tinhTrang, 1);
                }

            }
            foreach (var kvp in tinhTrangCounts)
            {
                dgvSoLuong.Rows.Add(kvp.Key, kvp.Value);
            }
            DrawPieChart();

        }
        private void DrawPieChart()
        {
            List<string> tinhTrangList = new List<string>();
            List<int> soLuongList = new List<int>();

            foreach (DataGridViewRow row in dgvSoLuong.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string tinhTrang = row.Cells[0].Value.ToString();
                    int soLuong = Convert.ToInt32(row.Cells[1].Value.ToString());
                    tinhTrangList.Add(tinhTrang);
                    soLuongList.Add(soLuong);
                }
            }
            // Xóa các series hiện có trong biểu đồ
            TinhTrang.Series.Clear();

            // Tạo series mới và thêm data points
            var series = new Series("Tình trạng");
            series.ChartType = SeriesChartType.Pie;
            series["PieLabelStyle"] = "Disabled"; // Tắt hiển thị nhãn trên mỗi phần tử

            for (int i = 0; i < tinhTrangList.Count; i++)
            {
                series.Points.AddXY(tinhTrangList[i], soLuongList[i]);
            }

            // Thêm series vào biểu đồ
            TinhTrang.Series.Add(series);
        }
    }
}
