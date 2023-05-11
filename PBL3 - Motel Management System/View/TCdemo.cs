using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PBL3___Motel_Management_System.View
{
    public partial class TCdemo : Form
    {
        public TCdemo()
        {
            InitializeComponent();
            LoadForm();
            LoadForm1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadForm()
        {
           DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn{ColumnName = "MaPhongTro",DataType = typeof(string)},
                new DataColumn{ColumnName = "STT",DataType = typeof(int)},
                  new DataColumn{ColumnName = "Tên Dãy trọ",DataType = typeof(string)},
                new DataColumn{ColumnName = "Tên phòng trọ",DataType = typeof(string)},
                 new DataColumn{ColumnName = "Tình trạng",DataType = typeof(string)},
                });
            QLBLL qLBLL = new QLBLL();
            foreach (ViewPhongTro pt in qLBLL.DgvPhongTro(null))
            {
                string TinhTrang;
                HopDong hd = qLBLL.GetHopDongByIdPhong(pt.MaPhongTro);
                if (hd == null) TinhTrang = "Còn trống";
                else if (hd.TinhTrang == true) TinhTrang = "Đã cho thuê";
                else TinhTrang = "Đã cọc";
                dt.Rows.Add(pt.MaPhongTro, pt.Stt, qLBLL.GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro, pt.TenPhongTro, TinhTrang);

            }
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
        }
        private void LoadForm1()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
        new DataColumn{ColumnName = "Tình trạng", DataType = typeof(string)},
        new DataColumn{ColumnName = "Số lượng phòng", DataType = typeof(int)}
            });

            QLBLL qLBLL = new QLBLL();
            List<ViewPhongTro> phongTroList = qLBLL.DgvPhongTro(null);

            // Tạo một Dictionary để lưu trữ số lượng phòng theo tình trạng
            Dictionary<string, int> tinhTrangCounts = new Dictionary<string, int>();

            foreach (ViewPhongTro pt in phongTroList)
            {
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

            // Tạo các dòng trong bảng mới từ Dictionary
            foreach (var kvp in tinhTrangCounts)
            {
                dt.Rows.Add(kvp.Key, kvp.Value);
            }

            dataGridView2.DataSource = dt;
            DrawPieChart();
        }
        private void DrawPieChart()
        {
            // Lấy dữ liệu từ bảng
            DataTable dt = (DataTable)dataGridView2.DataSource;
            List<string> tinhTrangList = new List<string>();
            List<int> soLuongList = new List<int>();

            foreach (DataRow row in dt.Rows)
            {
                string tinhTrang = row["Tình trạng"].ToString();
                int soLuong = Convert.ToInt32(row["Số lượng phòng"]);

                tinhTrangList.Add(tinhTrang);
                soLuongList.Add(soLuong);
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
