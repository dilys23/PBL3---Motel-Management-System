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
    public partial class ChitietTB : Form
    {
        private string idPhong;
        public ChitietTB(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
        }
        public void LoadForm(string txt)
        {
            QLBLLChung.Instance.customDGV(dgvThietBi);
            dgvThietBi.RowCount = 0;
            int i = 0;
            foreach (string idCttb in QLBLLChiTietThietBi.Instance.GetAllIdCHiTietThietBiByIdPhong(idPhong))
            {
                ChiTietThietBi cttb = QLBLLChiTietThietBi.Instance.GetChiTietThietBiById(idCttb);
                ThietBi tb = QLBLLThietbi.Instance.GetTBByIdTB(cttb.MaThietBi);
                dgvThietBi.Rows.Add(tb.MaThietBi, ++i, tb.TenThietBi, tb.GiaThietBi.ToString("#,##0") + "₫", cttb.SoLuong);
            }
        }
        private void btnThemThietbi_Click(object sender, EventArgs e)
        {
            QLBLLChung.Instance.openChildForm1(new ThemThietBiPhong(idPhong, LoadForm), panelThem);
        }
    }
}
