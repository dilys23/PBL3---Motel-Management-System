using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietPhong : Form
    {
        private string idPhong;
        public ChitietPhong(string idPhong)
        {
            InitializeComponent();
            this.idPhong=idPhong;
            LoadForm();
        }
        TrangChu tc = new TrangChu();
        private void LoadForm()
        {
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
            tc.openChildForm1(new ThemKhach(null), panelChiTiet);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemKhach(null), panelChiTiet);
        }

        private void panPhong1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
