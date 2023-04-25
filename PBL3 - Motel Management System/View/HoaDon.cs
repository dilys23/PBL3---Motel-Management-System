using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
namespace PBL3___Motel_Management_System
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
            SetCbb();
            LoadForm(null);
        }
        TrangChu tc= new TrangChu();
        private void LoadForm(string txt)
        {
            dgvHoaDon.Rows.Clear();
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
                string IdDay = ((ViewCbb)cbbDayTro.SelectedItem).IdDayTro;
                string IdPhong = ((ViewCbb)cbbPhongTro.SelectedItem).IdDayTro;
                string IdTinhTrang = ((ViewCbb)cbbTinhTrang.SelectedItem).IdDayTro;
                int i = 0;
                foreach(HoaDon hd in qLBLL.GetHoaDonTimKiem(ThangSuDung,IdDay,IdPhong,IdTinhTrang))
                {
                    PhongTro pt = qLBLL.GetPhongTroByIdPhong(hd.MaPhongTro);
                    DayTro dt = qLBLL.GetDayTroByIdPhong(hd.MaPhongTro);
                    string TinhTrang = (hd.TinhTrang) ? "Xác thực" : "Chưa xác thực";
                    dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro, hd.NgayTao, hd.ThangChiTra, hd.TongTien, TinhTrang, hd.DaThanhToan, hd.TongTien - hd.DaThanhToan);
                }
            }
        }
        private void SetCbb()
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
        private void btnIn_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new XuatHoaDon(), panel2);
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemHoaDon(LoadForm,null), panel2);
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
                tc.openChildForm1(new ThemHoaDon(LoadForm, id), panel2);

            }

        }

        private void cbbPhongTro_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                foreach (ViewPhongTro pt in qLBLL.GetAllPhongTroByIdDay(id))
                {
                    cbbPhongTro.Items.Add(new ViewCbb { IdDayTro=pt.MaPhongTro, TenDayTro=pt.TenPhongTro });
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
    }
}
