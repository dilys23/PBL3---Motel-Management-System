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
            SetFontAndColors();
            LoadForm(null);
        }
        private void SetFontAndColors()
        {
            this.dgvThietBi.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvThietBi.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvThietBi.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvThietBi.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            this.dgvThietBi.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            DataGridViewRow row = this.dgvThietBi.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
        }
        public void LoadForm(string txt)
        {
            dgvThietBi.RowCount = 0;
            int i = 0;
            foreach (string idCttb in QLBLL.Instance.GetAllIdCHiTietThietBiByIdPhong(idPhong))
            {
                ChiTietThietBi cttb = QLBLL.Instance.GetChiTietThietBiById(idCttb);
                ThietBi tb = QLBLL.Instance.GetTBByIdTB(cttb.MaThietBi);
                CultureInfo vietnamCulture = new CultureInfo("vi-VN");
                dgvThietBi.Rows.Add(tb.MaThietBi, ++i, tb.TenThietBi, tb.GiaThietBi.ToString("C0", vietnamCulture), cttb.SoLuong);
            }
        }
        private void btnThemThietbi_Click(object sender, EventArgs e)
        {
            ThuePhong tp= new ThuePhong();
            tp.hopDong.MaPhongTro = idPhong;
            QLBLL.Instance.openChildForm1(new ThemThietBiPhong(tp, LoadForm), panelThem);
        }
    }
}
