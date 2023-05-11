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
namespace PBL3___Motel_Management_System
{
    public partial class Hoadon : Form
    {
       // Hopdong thd = new Hopdong();
        public Hoadon()
        {
            InitializeComponent();
            SetCbb();
            LoadForm(null);

        }
        TrangChu tc= new TrangChu();
        Dichvu dv = new Dichvu();
    
     
        private void LoadForm(string txt)
        {
            dgvHoaDon.Rows.Clear();
            this.dgvHoaDon.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvHoaDon.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvHoaDon.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvHoaDon.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            this.dgvHoaDon.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            this.dgvHoaDon.RowTemplate.Height = 35;
            this.dgvHoaDon.RowTemplate.MinimumHeight = 20;

            if (dgvHoaDon.Columns["btnSua"] == null)
            {
                DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
                {
                    btnSua.HeaderText = "";
                    btnSua.Name = "btnSua";
                    //btnSua.Text = "Sửa";
                    btnSua.UseColumnTextForButtonValue = true;
                    btnSua.DisplayIndex = 0;
                    this.dgvHoaDon.Columns.Add(btnSua);

                }
            }
            if (dgvHoaDon.Columns["btnXoa"] == null)
            {
                DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
                {
                    btnXoa.HeaderText = "";
                    btnXoa.Name = "btnXoa";
                   // btnXoa.Text = "Xóa";
                    btnXoa.UseColumnTextForButtonValue = true;
                    btnXoa.DisplayIndex = 1;
                    this.dgvHoaDon.Columns.Add(btnXoa);

                }
            }
           
            QLBLL qLBLL = new QLBLL();
            if(txt == null)
            {

            int i= 0;
            foreach(HoaDon hd in qLBLL.GetAllHoaDonBll())
            {
                PhongTro pt = qLBLL.GetPhongTroByIdPhong(hd.MaPhongTro);
                DayTro dt = qLBLL.GetDayTroByIdPhong(hd.MaPhongTro);
                string TinhTrang = (hd.TinhTrang) ? "Xác thực" : "Chưa xác thực";
                dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro, hd.NgayTao, hd.ThangChiTra, hd.TongTien, TinhTrang, hd.DaThanhToan, hd.TongTien - hd.DaThanhToan);
            }
            }
            else
            {
                string ThangSuDung = dtpThangSuDung.Value.ToString("MM-yyyy");
                string IdDay = ((ViewCbb)cbbDayTro.SelectedItem).key;
                string IdPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                string IdTinhTrang = ((ViewCbb)cbbTinhTrang.SelectedItem).key;
                int i = 0;
                foreach(HoaDon hd in qLBLL.GetHoaDonTimKiem(ThangSuDung,IdDay,IdPhong,IdTinhTrang))
                {
                    PhongTro pt = qLBLL.GetPhongTroByIdPhong(hd.MaPhongTro);
                    DayTro dt = qLBLL.GetDayTroByIdPhong(hd.MaPhongTro);
                    string TinhTrang = (hd.TinhTrang) ? "Xác thực" : "Chưa xác thực";
                    dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro, hd.NgayTao, hd.ThangChiTra, hd.TongTien, TinhTrang, hd.DaThanhToan, hd.TongTien - hd.DaThanhToan);
                }
            }
           
            var Sua = System.Drawing.Image.FromFile(@"D:\pblproject\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\pblproject\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvHoaDon.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => dv.dgvIcons_CellPainting1(dgvHoaDon, e,Sua, Xoa) );
        }
       

        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.Items.Add(new ViewCbb { key = "0", value = "All" });
            cbbTinhTrang.Items.Add(new ViewCbb {key = "1", value = "Đã xác thực" });
            cbbTinhTrang.Items.Add(new ViewCbb {key = "2", value = "Chưa xác thực" });
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new XuatHoaDon(), panelHD);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemHoaDon(LoadForm,null), panelHD);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() == "Xác thực")
            {
                MessageBox.Show("Hóa đơn hiện tại đã được xác thực nên không thể sửa!!Vui lòng bỏ xác thực trước khi sửa hóa đơn", "Thông báo");
            }    
            else
            {
                string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                tc.openChildForm1(new ThemHoaDon(LoadForm, id), panelHD);

            }

        }

        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            cbbPhongTro.Items.Clear();
            cbbPhongTro.Items.Add(new ViewCbb {key = "0", value = "All" });
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            if (id == "0")
            {

                foreach (PhongTro pt in qLBLL.GetAllPhongTro())
                {
                    cbbPhongTro.Items.Add(new ViewCbb {key = pt.MaPhongTro, value = pt.TenPhongTro });
                }
            }
            else
            {
                foreach (ViewPhongTro pt in qLBLL.GetAllPhongTroByIdDay(id))
                {
                    cbbPhongTro.Items.Add(new ViewCbb {key = pt.MaPhongTro, value = pt.TenPhongTro });
                }
            }
            if (cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadForm("");
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() != "Xác thực")
            {
                QLBLL qLBLL = new QLBLL();
                string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                HoaDon hd = qLBLL.GetHoaDonById(id);
                List<HoaDon> list = qLBLL.GetHoaDonTimKiem(hd.ThangChiTra, "0", hd.MaPhongTro, "1");
                if (list.Count == 0)
                {
                    hd.TinhTrang = true;
                    qLBLL.UpdateHoaDonBLL(hd);
                    MessageBox.Show("Xác thực thành công", "Thông báo");
                    LoadForm(null);
                }
                else
                {
                    MessageBox.Show("Phòng này ở thời điểm bạn chọn đã có một chi tiết được xác thực", "Thông báo");
                }

            }
            else {
                MessageBox.Show("Hóa đơn hiện tại đã được xác thực", "Thông báo");
            
            }

        }

        private void btnBoXacThuc_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() != "Chưa xác thực")
            {
                if(Convert.ToDouble(dgvHoaDon.CurrentRow.Cells[8].Value.ToString())!= 0)
                {
                    MessageBox.Show("Hóa đơn hiện tại đã được thanh toán!/nKhông thể bỏ xác thực!", "Thông báo");
                }
                else
                {
                    QLBLL qLBLL = new QLBLL();
                    HoaDon hd = qLBLL.GetHoaDonById(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                    hd.TinhTrang = false;
                    qLBLL.UpdateHoaDonBLL(hd);
                    MessageBox.Show("Bỏ xác thực thành công");
                    LoadForm(null);
                }
            }    
            else
            {
                MessageBox.Show("Hóa đơn hiện tại đã ở tình trạng chưa xác thực", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() == "Chưa xác thực")
            {
                QLBLL qLBLL = new QLBLL();
                qLBLL.DelHoaDonBll(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Xóa hóa đơn thành công","Thông báo");
                LoadForm(null);
            }
            else
            {
                MessageBox.Show("Hóa đơn đã được xác thực!! Không thể xóa", "Thông báo");
            }

        }

        private void dgvHoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvHoaDon.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
                if (columnName == "btnSua")
                {
                    if (dgvHoaDon.Rows[e.RowIndex].Cells[7].Value.ToString() == "Xác thực")
                    {
                        MessageBox.Show("Hóa đơn hiện tại đã được xác thực nên không thể sửa!!Vui lòng bỏ xác thực trước khi sửa hóa đơn", "Thông báo");
                    }
                    else
                    {
                        string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                        tc.openChildForm1(new ThemHoaDon(LoadForm, id), panelHD);

                    }

                }
                else if (columnName == "btnXoa")
                {
                    // Lấy mã dịch vụ tương ứng với hàng đã được nhấp
                    // string maDichVu = dgvDichVu.Rows[e.RowIndex].Cells["Mã dịch vụ"].Value.ToString();
                    if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() == "Chưa xác thực")
                    {
                        QLBLL qLBLL = new QLBLL();
                        qLBLL.DelHoaDonBll(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                        LoadForm(null);
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn đã được xác thực!! Không thể xóa", "Thông báo");
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}
