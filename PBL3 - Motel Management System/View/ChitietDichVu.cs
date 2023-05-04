using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietDichVu : Form
    {
        private string idPhong;
        public ChitietDichVu(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
        }
        public void LoadForm(string txt)
        {

            dgvDichVu.Rows.Clear();
            
           
            QLBLL qLBLL = new QLBLL();
            dgvDichVu.RowCount = 1;
             int  i = 1;
            foreach (string idDv in qLBLL.GetAllIdDichVuByIdPhong(this.idPhong))
            {
                DichVu dv = new DichVu();
                dv = qLBLL.GetDVByIdDV(idDv);
                dgvDichVu.Rows.Add(dv.MaDichVu, i++, dv.TenDichVu, dv.GiaDichVu);
            }
            //if (dgvDichVu.Columns["btnXoa"] == null)
            //{
            //    DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            //    {
            //        btnXoa.HeaderText = "";
            //        btnXoa.Name = "btnXoa";
            //        btnXoa.Text = "Xóa";
            //        btnXoa.UseColumnTextForButtonValue = true;
            //        btnXoa.DisplayIndex = 1;
            //        this.dgvDichVu.Columns.Add(btnXoa);

            //    }
            //}
        }
        TrangChu tc= new TrangChu();
        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvDichVu.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
               if (columnName == "btnXoa")
                {
                    // Lấy mã dịch vụ tương ứng với hàng đã được nhấp
                    // string maDichVu = dgvDichVu.Rows[e.RowIndex].Cells["Mã dịch vụ"].Value.ToString();
                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        string id = dgvDichVu.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
                        if (id != "000" && id != "001")
                        {
                            QLBLL qLBLL = new QLBLL();
                            qLBLL.DelChiTietDichVuByIdDichVu(id);
                            qLBLL.DelDichVu(id);
                            MessageBox.Show("Xóa dịch vụ thành công", "Thông báo");
                            LoadForm(null);
                        }
                        else
                        {
                            MessageBox.Show("Đây là dịch vụ cố định!! Không thể xóa");
                        }
                    }
                }
            }
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            ThuePhong tp = new ThuePhong();
            tp.hopDong.MaPhongTro = idPhong;
            tc.openChildForm1(new ThemDVphong(tp, LoadForm), panelThem);
        }
    }
}
