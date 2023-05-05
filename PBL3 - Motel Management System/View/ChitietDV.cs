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
    public partial class ChitietDV : Form
    {
        private string idPhong;
        public ChitietDV(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
            SetFontAndColors();
        }
        private void SetFontAndColors()
        {
            this.dgvDichVu.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvDichVu.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvDichVu.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvDichVu.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            this.dgvDichVu.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            DataGridViewRow row = this.dgvDichVu.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
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
           
        }
        TrangChu tc= new TrangChu();
        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                
                string columnName = dgvDichVu.Columns[e.ColumnIndex].Name;

               if (columnName == "btnXoa")
                {
                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        string id = dgvDichVu.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
                        if (id != "000" && id != "001")
                        {
                            QLBLL qLBLL = new QLBLL();
                            qLBLL.DelChiTietDichVuByIdDichVu(id);
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
