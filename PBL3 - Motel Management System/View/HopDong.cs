using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
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
        private string id;
        public Hopdong()
        {
            InitializeComponent();
           
            LoadForm(null);
         
        }
       

        TrangChu tc = new TrangChu();
        Dichvu dv = new Dichvu();
       
        private void LoadForm(string txtTim)
        {
            dgvHD.Rows.Clear();
            dgvHD.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgvHD.DefaultCellStyle.ForeColor = Color.Blue;
            dgvHD.DefaultCellStyle.BackColor = Color.Beige;
            dgvHD.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvHD.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgvHD.RowTemplate.Height = 35;
            dgvHD.RowTemplate.MinimumHeight = 20;
            QLBLL qLBLL = new QLBLL();

            foreach (DgvHopDong hd in qLBLL.DgvHopDong())
            {
                dgvHD.Rows.Add(hd.MaHopDong, hd.Stt, hd.TenKhachHang, hd.TenPhongTro, hd.TenDayTro, hd.NgayBatDau, hd.NgayKetThuc, hd.TienCoc);

            }

            //dgvHD.CellContentClick += DgvDichVu_CellContentClick;
            var Sua = System.Drawing.Image.FromFile(@"C:\Users\HP VICTUS\Downloads\icons8-more-details-20.png");
            var Xoa = System.Drawing.Image.FromFile(@"C:\Users\HP VICTUS\Downloads\icons8-time-25.png");
            dgvHD.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => dv.dgvIcons_CellPainting1(dgvHD, e, Sua, Xoa));
      
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
        
        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvHD.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
                if (columnName == "btnSua")
                {
                    string id = dgvHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                  //  tc.openChildForm1(new ChitietHopDong(id, LoadForm), panelHopDong);
                    ThuePhong tp = new ThuePhong();
                    tp.hopDong.MaPhongTro = id;
                    ChitietHopDong ct = new ChitietHopDong(tp, LoadForm);
                    tc.openChildForm1(ct, panelHopDong);
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

        private void dgvHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHD.Columns[e.ColumnIndex].Name == "btnSua")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Chi Tiết";
                    }
                }
            }
            if (dgvHD.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Gia Hạn";
                    }
                }
            }

        }
    }
}
