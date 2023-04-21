using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietPhong : Form
    {
        private string idPhong;
        private Loader loader;
        public ChitietPhong(string idPhong, Loader loader)
        {
            InitializeComponent();
            this.idPhong=idPhong;
            LoadForm(null);
            this.loader=loader;
        }
        TrangChu tc = new TrangChu();
        private void LoadForm(string txt)
        {
            dgvThanhVien.RowCount = 1;
            dgvDichVu.RowCount = 1;
            dgvThietBi.RowCount = 1;
            
            QLBLL qLBLL = new QLBLL();
            int i = 1;
            dgvThanhVien.Columns[6].ValueType = typeof(Boolean);
            foreach(string idNguoi in qLBLL.GetIdNguoiByIdPhong(this.idPhong))
            {
                Nguoi nguoi = new Nguoi();
                nguoi = qLBLL.GetNguoiByIdNguoi(idNguoi);

                dgvThanhVien.Rows.Add(nguoi.MaNguoi, i++, nguoi.Ten, nguoi.Cccd, nguoi.Sdt, nguoi.Diachi, nguoi.NgaySinh, (nguoi.GioiTinh)?"Nam":"Nữ");
            }
            i=1;
            foreach(string idDv in qLBLL.GetAllIdDichVuByIdPhong(this.idPhong))
            {
                DichVu dv = new DichVu();
                dv = qLBLL.GetDVByIdDV(idDv);
                dgvDichVu.Rows.Add(dv.MaDichVu,i++,dv.TenDichVu,dv.GiaDichVu);
            }
            i=1;
            foreach(string idThietBi in qLBLL.GetAllIdThietBiByIdPhong(idPhong))
            {
                ThietBi tb = new ThietBi();
                tb = qLBLL.GetTBByIdTB(idThietBi);
                dgvThietBi.Rows.Add(tb.MaThietBi,i++,tb.TenThietBi,tb.GiaThietBi);
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            if(qLBLL.GetPhongTroByIdPhong(idPhong).TinhTrang == true)
            {

            if(qLBLL.GetIdNguoiByIdPhong(idPhong).Count() < qLBLL.GetPhongTroByIdPhong(idPhong).ToiDa)
            {
                string IdThanhVien = dgvThanhVien.Rows[0].Cells[0].Value.ToString();
                string IdPhong = qLBLL.GetIdPhongByIdNguoi(IdThanhVien);
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = idPhong;
                tc.openChildForm1(new ThemKhach(null,tp, LoadForm), panelChiTiet);
            }
            else
            {
                MessageBox.Show("Số lượng người đã tối đa");
            }
            }
            else
            {
                MessageBox.Show("Phòng chưa được cho thuê, không được thêm khách hàng", "Thông báo", MessageBoxButtons.OK); ;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string idKhach = dgvThanhVien.CurrentRow.Cells[0].Value.ToString(); 
            tc.openChildForm1(new ThemKhach(idKhach,null,LoadForm), panelChiTiet);
        }

        private void panPhong1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.loader(null);
            this.Close();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
           
            tc.openChildForm1(new ThemDVphong(idPhong,null,LoadForm),panelChiTiet);
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            string idDV = dgvDichVu.CurrentRow.Cells[0].Value.ToString();   
            tc.openChildForm1(new SuaDichVu(idDV,LoadForm), panelChiTiet);
        }
    }
    
}
