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
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.BLL;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietDay : Form
    {
       
        private string IdDay;
        public ChitietDay(string idDay)
        {
            InitializeComponent();
            this.IdDay = idDay;
            LoadForm(idDay);
        }
        TrangChu tc = new TrangChu();
        public void LoadForm(string idDay)
        {      
            DataTable dt = new DataTable();
            QLBLL qLBLL = new QLBLL();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "Mã phòng",DataType = typeof(string)},
                new DataColumn{ColumnName = "STT",DataType = typeof(int)},
                new DataColumn{ColumnName = "Tên phòng",DataType = typeof(string)},
                new DataColumn{ColumnName = "Giá tiền",DataType = typeof(double)},
                new DataColumn{ColumnName = "Diện tích",DataType = typeof(double)},
                new DataColumn{ColumnName = "Tình trạng",DataType = typeof(bool)},
                new DataColumn{ColumnName = "Số người hiện có",DataType = typeof(int)},
                new DataColumn{ColumnName = "Số người tối đa",DataType = typeof(int)}       
            });

            foreach (ViewPhongTro vp in qLBLL.GetAllPhongTroByIdDay(idDay))
            {
                dt.Rows.Add(vp.MaPhongTro, vp.Stt, vp.TenPhongTro, vp.GiaTien, vp.DienTich, vp.TinhTrang, vp.SoNguoiHienCo,vp.SoNguoiToiDa);
            }
            textBox1.Text= qLBLL.GetDayByIdDay(idDay).TenDayTro.ToString();
            textBox2.Text= qLBLL.GetDayByIdDay(idDay).TenDuong.ToString()+','+qLBLL.GetDayByIdDay(idDay).TenHuyen.ToString() + qLBLL.GetDayByIdDay(idDay).TenThanhPho.ToString() ;
            dgvPhong.DataSource = dt;
            dgvPhong.Columns[0].Visible = false;
        }
        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemPhong(IdDay), panelChitietDay);
            LoadForm(IdDay);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string IdPhong = dgvPhong.CurrentRow.Cells[0].Value.ToString();
            tc.openChildForm1(new SuaPhong(IdPhong), panelChitietDay);
        }
    }
}
