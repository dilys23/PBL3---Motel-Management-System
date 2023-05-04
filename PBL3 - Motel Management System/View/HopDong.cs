using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
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

namespace PBL3___Motel_Management_System
{
    public partial class Hopdong : Form
    {
        public Hopdong()
        {
            InitializeComponent();
           
            LoadForm(null);
            SetFontAndColors();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void SetFontAndColors1()
        {
            this.dgvHD.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvHD.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvHD.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvHD.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvHD.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            DataGridViewRow row = this.dgvHD.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
        }
        private void SetFontAndColors()
        {
            this.dgvHD.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvHD.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvHD.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvHD.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvHD.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            DataGridViewRow row = this.dgvHD.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
        }

        TrangChu tc = new TrangChu();
       
        private void LoadForm(string txtTim)
        {
            if (dgvHD.Columns["btnChiTiet"] == null)
            {
                DataGridViewButtonColumn btnChiTiet = new DataGridViewButtonColumn();
                {
                    btnChiTiet.HeaderText = "";
                    btnChiTiet.Name = "btnChiTiet";
                    btnChiTiet.Text = "Chi Tiết";
                    btnChiTiet.UseColumnTextForButtonValue = true;
                    this.dgvHD.Columns.Add(btnChiTiet);

                }
            }
            if (dgvHD.Columns["btnGiaHan"] == null)
            {
                DataGridViewButtonColumn btnGiaHan = new DataGridViewButtonColumn();
                {
                    btnGiaHan.HeaderText = "";
                    btnGiaHan.Name = "btnGiaHan";
                    btnGiaHan.Text = "Gia Hạn";
                    btnGiaHan.UseColumnTextForButtonValue = true;
                    this.dgvHD.Columns.Add(btnGiaHan);

                }
            }


            ///  string imagePath = @"E:\PBL3_MAIN\Icons\icons8-customer-20.png";

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
               new DataColumn{ColumnName = "Mã HD",DataType =  typeof(string)},
                new DataColumn{ColumnName = "STT",DataType =  typeof(int)},
                new DataColumn{ColumnName = "Tên Khách Hàng",DataType =  typeof(string)},
                new DataColumn{ColumnName = "Tên Phòng Trọ",DataType =  typeof(string)},
                new DataColumn{ColumnName = "Tên Dãy Trọ",DataType =  typeof(string)},
                new DataColumn{ColumnName = "Ngày bắt đầu",DataType =  typeof(string)},
                new DataColumn{ColumnName = "Ngày kết thúc",DataType =  typeof(string)},
                new DataColumn{ColumnName = "Tiền Cọc",DataType =  typeof(double)},

        });

            QLBLL qLBLL = new QLBLL();

            foreach (DgvHopDong hd in qLBLL.DgvHopDong())
            {
                dt.Rows.Add(hd.MaHopDong, hd.Stt, hd.TenKhachHang, hd.TenPhongTro, hd.TenDayTro, hd.NgayBatDau, hd.NgayKetThuc, hd.TienCoc);

            }

            dgvHD.CellContentClick += DgvDichVu_CellContentClick;
            // dgvDichVu.CellPainting += grid_CellPainting;
            dgvHD.DataSource = dt;
            dgvHD.Columns["Mã HD"].Visible = false;

        }
        private void DgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvHD.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
                if (columnName == "btnChitiet")
                {
                    // Lấy mã dịch vụ tương ứng với hàng đã được nhấp
                   // string id = dgvHD.Rows[e.RowIndex].Cells["Mã Thiết bị"].Value.ToString();


                   // tc.openChildForm1(new SuaThietBI(id, LoadForm), );
                }
                else if (columnName == "btnXoa")
                {
                    // Lấy mã dịch vụ tương ứng với hàng đã được nhấp
                    // string maDichVu = dgvDichVu.Rows[e.RowIndex].Cells["Mã dịch vụ"].Value.ToString();

                    // Xóa dịch vụ từ CSDL của bạn sử dụng mã dịch vụ tương ứng

                    // Cập nhật lại DataGridView sau khi đã xóa
                }
            }
        }





        private void btnThem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
