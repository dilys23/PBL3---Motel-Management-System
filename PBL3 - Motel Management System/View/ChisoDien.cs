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
using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChisoDien : Form
    {
        public ChisoDien()
        {
            InitializeComponent();
            LoadForm(null);
            Setcbb();
        }

        TrangChu tc = new TrangChu();
        Dichvu dv = new Dichvu();
        private void LoadForm(string txt)
        {
            dgvChiSoDien.Rows.Clear();
            tc.customDGV(dgvChiSoDien);
            QLBLL qLBLL = new QLBLL();
            int i = 0;
            if(txt==null)
            {
            foreach(ViewChiSo view in qLBLL.GetAllViewChiSo())
                {
                    if(qLBLL.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == "001")
                    {
                        string tinhTrang = (view.TinhTrang) ? "Đã xác thực" : "Chưa xác thực";
                        dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.TenDayTro, view.TenPhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        ,view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }
            else
            {
                string ThangSuDung = dtpThangSuDung.Value.ToString("MM-yyyy");
                string IdDay = ((ViewCbb)cbbDayTro.SelectedItem).key;
                string IdPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                string IdTinhTrang = ((ViewCbb)cbbTinhTrang.SelectedItem).key;
                foreach(ViewChiSo view in qLBLL.GetViewChiSoByTimKiem(ThangSuDung, IdDay, IdPhong, IdTinhTrang))
                {
                    if (qLBLL.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == "001")
                    {
                        string tinhTrang = (view.TinhTrang) ? "Đã xác thực" : "Chưa xác thực";
                        dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.TenDayTro, view.TenPhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        , view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBL3\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL3\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvChiSoDien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => dv.dgvIcons_CellPainting1(dgvChiSoDien, e, Sua, Xoa));
        }
        public void Setcbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.Items.Add(new ViewCbb { key = "-1", value = "All" });
            cbbTinhTrang.Items.Add(new ViewCbb {key = "1", value = "Đã xác thực" });
            cbbTinhTrang.Items.Add(new ViewCbb {key = "2", value = "Chưa xác thực" });
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemCSDien(LoadForm), panelChisoDien);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() != "Đã xác thực")
            {
                QLBLL qLBLL = new QLBLL();
                string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                ChiTietSuDungDichVu dv = qLBLL.GetChiTietSuDungDichVuByIdBLL(id);
                ChiTietDichVu ctdv = qLBLL.GetChiTietDichVuById(dv.MaCHiTietDichVu);
                List<ChiTietSuDungDichVu> list = qLBLL.GetChiTietSuDungDichVuTimKiem(dv.ThoiGian,"0",ctdv.MaPhongTro,"1");
                List<ChiTietSuDungDichVu> myList = new List<ChiTietSuDungDichVu>();
                foreach(ChiTietSuDungDichVu ct in list)
                {
                    if(qLBLL.GetChiTietDichVuById(ct.MaCHiTietDichVu).MaDichVu == "001") myList.Add(ct);
                }
                if(myList.Count == 0)
                {
                    dv.TinhTrang = true;
                    qLBLL.UpdateChiTietSuDungDichVu(dv);
                    MessageBox.Show("Xác thực thành công","Thông báo");
                    LoadForm(null);
                }

                else
                {
                    MessageBox.Show("Phòng hiện tại của bạn đã có một chi tiết được xác nhận!!!", "Thông báo");
                }

            } 
            else
            {
                MessageBox.Show("Dịch vụ hiện tại đã được xác thực", "Thông báo");
            }


        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            cbbPhongTro.Items.Clear();
            cbbPhongTro.Items.Add(new ViewCbb { key="-1", value="All" });
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            if (id == "-1")
            {
                foreach (PhongTro pt in qLBLL.GetAllPhongTro())
                {
                    cbbPhongTro.Items.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                }
            }
            else
            {
                foreach(string idp in qLBLL.GetAllPhongTroByIdDay(id))
                {
                    PhongTro pt = qLBLL.GetPhongTroByIdPhong(idp);
                    cbbPhongTro.Items.Add(new ViewCbb {key = pt.MaPhongTro, value = pt.TenPhongTro });
                }
            }
            if(cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Lấy tháng và năm được chọn
            int month = dtpThangSuDung.Value.Month;
            int year = dtpThangSuDung.Value.Year;

            // Tạo ngày đầu tiên của tháng và năm được chọn
            DateTime date = new DateTime(year, month, 1);

            // Gán ngày đó cho DateTimePicker
            dtpThangSuDung.Value = date;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadForm("");
        }
        private void btnHuyXacThuc_Click(object sender, EventArgs e)
        {
            if(dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() != "Đã xác thực")
            {
                MessageBox.Show("Dịch vụ hiện tại hiện đang chưa xác thực");
            }
            else
            {
                QLBLL qLBLL = new QLBLL();
                string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                ChiTietSuDungDichVu dv = qLBLL.GetChiTietSuDungDichVuByIdBLL(id);
                dv.TinhTrang = false;
                qLBLL.UpdateChiTietSuDungDichVu(dv);
                MessageBox.Show("Hủy bỏ xác thực thành công", "Thông báo");
                LoadForm(null);

            }
        }

        private void dgvChiSoDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                string columnName = dgvChiSoDien.Columns[e.ColumnIndex].Name;
                if (columnName == "btnSua")
                {
                    if (dgvChiSoDien.Rows[e.RowIndex].Cells[9].Value.ToString() == "Xác thực")
                    {
                        MessageBox.Show("Chỉ số hiện tại đã được xác thực nên không thể sửa!!Vui lòng bỏ xác thực trước khi sửa chỉ số", "Thông báo");
                    }
                    else
                    {
                        string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                        tc.openChildForm1(new SuaCSDien(), panelChisoDien);

                    }

                }
                else if (columnName == "btnXoa")
                {
                    if (dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() == "Chưa xác thực")
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn đã được xác thực!! Không thể xóa", "Thông báo");
                    }
                }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
