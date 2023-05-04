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
            SetFontAndColors();
        }

        TrangChu tc = new TrangChu();
        private void SetFontAndColors()
        {
            this.dgvChiSoDien.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvChiSoDien.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvChiSoDien.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvChiSoDien.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            this.dgvChiSoDien.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            DataGridViewRow row = this.dgvChiSoDien.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
        }
        private void ChisoDien_Load(object sender, EventArgs e)
        {

        }
        private void LoadForm(string txt)
        {
            dgvChiSoDien.Rows.Clear();
            if (dgvChiSoDien.Columns["btnSua"] == null)
            {
                DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
                {
                    btnSua.HeaderText = "";
                    btnSua.Name = "btnSua";
                    btnSua.Text = "Sửa";
                    btnSua.UseColumnTextForButtonValue = true;
                    btnSua.DisplayIndex = 0;
                    this.dgvChiSoDien.Columns.Add(btnSua);

                }
            }
            if (dgvChiSoDien.Columns["btnXoa"] == null)
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                {
                    btnXoa.HeaderText = "";
                    btnXoa.Name = "btnXoa";
                    btnXoa.Text = "Xóa";
                    btnXoa.UseColumnTextForButtonValue = true;
                    btnXoa.DisplayIndex = 1;
                    this.dgvChiSoDien.Columns.Add(btnXoa);

                }
            }
            QLBLL qLBLL = new QLBLL();
            if(txt==null)
            {

            int i = 0;
            foreach(ChiTietSuDungDichVu dv in qLBLL.GetAllChiTietSuDungDichVuBll())
            {
                ChiTietDichVu ctdv = qLBLL.GetChiTietDichVuById(dv.MaCHiTietDichVu);
                if(ctdv.MaDichVu == "001")
                {
                   ViewChiSoDien view = new ViewChiSoDien
                   {
                       MaChiTietSuDungDichVu = dv.MaChiTietSuDungDichVu,
                       Stt = ++i,
                       DayTro = qLBLL.GetDayTroByIdPhong(ctdv.MaPhongTro).TenDayTro,
                       PhongTro = qLBLL.GetPhongTroByIdPhong(ctdv.MaPhongTro).TenPhongTro,
                       ChiSoCu = dv.ChiSoCu,
                       ChiSoMoi = dv.ChiSoMoi,
                       DaDung = dv.ChiSoMoi-dv.ChiSoCu,
                       NgayLap = dv.NgayLap,
                       ThangSuDung = dv.ThoiGian,
                       TinhTrang = dv.TinhTrang
                       
                   };
                    string tinhTrang = (view.TinhTrang) ? "Đã xác thực" : "Chưa xác thực";

                    dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu,view.Stt,view.DayTro,view.PhongTro,view.ChiSoCu,view.ChiSoMoi,view.DaDung
                        ,view.NgayLap,view.ThangSuDung, tinhTrang);
                }
            }
            }
            else
            {
                string ThangSuDung = dtpThangSuDung.Value.ToString("MM-yyyy");
                string IdDay = ((ViewCbb)cbbDayTro.SelectedItem).IdDayTro;
                string IdPhong = ((ViewCbb)cbbPhongTro.SelectedItem).IdDayTro;
                string IdTinhTrang = ((ViewCbb)cbbTinhTrang.SelectedItem).IdDayTro;
                int i = 0;
                foreach (ChiTietSuDungDichVu dv in qLBLL.GetChiTietSuDungDichVuTimKiem(ThangSuDung,IdDay,IdPhong, IdTinhTrang))
                {
                    ChiTietDichVu ctdv = qLBLL.GetChiTietDichVuById(dv.MaCHiTietDichVu);
                    if (ctdv.MaDichVu == "001")
                    {
                        ViewChiSoDien view = new ViewChiSoDien
                        {
                            MaChiTietSuDungDichVu = dv.MaChiTietSuDungDichVu,
                            Stt = ++i,
                            DayTro = qLBLL.GetDayTroByIdPhong(ctdv.MaPhongTro).TenDayTro,
                            PhongTro = qLBLL.GetPhongTroByIdPhong(ctdv.MaPhongTro).TenPhongTro,
                            ChiSoCu = dv.ChiSoCu,
                            ChiSoMoi = dv.ChiSoMoi,
                            DaDung = dv.ChiSoMoi-dv.ChiSoCu,
                            NgayLap = dv.NgayLap,
                            ThangSuDung = dv.ThoiGian,
                            TinhTrang = dv.TinhTrang

                        };
                        string tinhTrang = (view.TinhTrang) ? "Đã xác thực" : "Chưa xác thực";

                        dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu, view.Stt, view.DayTro, view.PhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                            , view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }

            dgvChiSoDien.CellContentClick += DgvChisoDien_CellContentClick;
        }
        private void DgvChisoDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvChiSoDien.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
                if (columnName == "btnSua")
                {
                    if (dgvChiSoDien.Rows[e.RowIndex].Cells[7].Value.ToString() == "Xác thực")
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
                    // Lấy mã dịch vụ tương ứng với hàng đã được nhấp
                    // string maDichVu = dgvDichVu.Rows[e.RowIndex].Cells["Mã dịch vụ"].Value.ToString();
                    if (dgvChiSoDien.CurrentRow.Cells[7].Value.ToString() == "Chưa xác thực")
                    {
                        
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn đã được xác thực!! Không thể xóa", "Thông báo");
                    }
                }
            }
        }
        public void Setcbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.Items.Add(new ViewCbb { IdDayTro = "0", TenDayTro = "All" });
            cbbTinhTrang.Items.Add(new ViewCbb { IdDayTro = "1", TenDayTro = "Đã xác thực" });
            cbbTinhTrang.Items.Add(new ViewCbb { IdDayTro = "2", TenDayTro = "Chưa xác thực" });
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
            cbbPhongTro.Items.Add(new ViewCbb { IdDayTro="0", TenDayTro="All" });
            string id = ((ViewCbb)cbbDayTro.SelectedItem).IdDayTro;
            if (id == "0")
            {
                
                foreach (PhongTro pt in qLBLL.GetAllPhongTro())
                {
                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro = pt.MaPhongTro, TenDayTro = pt.TenPhongTro });
                }
            }
            else
            {
                foreach(ViewPhongTro pt in qLBLL.GetAllPhongTroByIdDay(id))
                {
                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro=pt.MaPhongTro,TenDayTro=pt.TenPhongTro });
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

        private void cbbPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadForm("");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaCSDien(), panelChisoDien);
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
            tc.openChildForm1(new SuaCSDien(), panelChisoDien);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
