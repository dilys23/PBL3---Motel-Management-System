using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DTO;
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
    public delegate void Loader(String s);
    
    public partial class Daytro : Form
    {
        public Daytro()
        {
            InitializeComponent();
            LoadForm(null);
        }
        TrangChu tc = new TrangChu();   
        public void LoadForm(String txtTim)
        {
            cbbDayTro.Items.Clear();
            SetCbbDayTro();
            DataTable dt = new DataTable();
            QLBLL qLBLL = new QLBLL();  
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "IdDay",DataType = typeof(string)},
                new DataColumn{ColumnName = "STT",DataType = typeof(int)},
                new DataColumn{ColumnName = "Tên dãy trọ",DataType = typeof(string)},
                new DataColumn{ColumnName = "Tên đường",DataType = typeof(string)},
                new DataColumn{ColumnName = "Tên huyện",DataType = typeof(string)},
                new DataColumn{ColumnName = "Tên thành phố",DataType = typeof(string)},
                new DataColumn{ColumnName = "Số phòng hiện có",DataType = typeof(int)},
            });
            
            foreach(ViewDay vd in qLBLL.DgvDayTro(txtTim))
            {
                dt.Rows.Add(vd.MaDayTro,vd.Stt,vd.TenDayTro,vd.TenDuong,vd.TenHuyen,vd.TenThanhPho,vd.SoPhong);
            }

            dtgDayTro.DataSource = dt;
            dtgDayTro.Columns[0].Visible = false;
        }

        public void SetCbbDayTro()
        {
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.Items.Add("All");
            cbbTinhTrang.Items.Add("Đã cho thuê");
            cbbTinhTrang.Items.Add("Trống");
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string idDay = dtgDayTro.CurrentRow.Cells[0].Value.ToString();
            tc.openChildForm1(new ThemPhong(idDay), panelDay);
        }

        private void btnThemday_Click(object sender, EventArgs e)
        {
            
            tc.openChildForm1(new ThemDay(LoadForm), panelDay);
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaPhong(), panelDay);
            
        }

        private void Daytro_Load(object sender, EventArgs e)
        {

        }

        private void btnSuaday_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaDay(), panelDay);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadForm(txtTenDay.Text);
        }
    }
}
