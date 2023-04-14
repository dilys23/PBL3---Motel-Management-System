using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    public partial class Phong : Form
    {
        
       
        public Phong()
        {
            InitializeComponent();
            //this.paneDesktop = paneDesktop;
            LoadForm(null);
         
        }
        public void LoadForm(string txt)
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "MaPhongTro",DataType = typeof(string)},
                new DataColumn{ColumnName = "STT",DataType = typeof(int)},
                new DataColumn{ColumnName = "Tên phòng trọ",DataType = typeof(string)},
                new DataColumn{ColumnName = "Giá tiền",DataType = typeof(double)},
                new DataColumn{ColumnName = "Diện tích",DataType = typeof(double)},
                new DataColumn{ColumnName = "Tình trạng",DataType = typeof(bool)},
                new DataColumn{ColumnName = "Số người hiện có",DataType = typeof(int)},
                new DataColumn{ColumnName = "Số người tối đa",DataType = typeof(string)},

            });
            QLBLL qLBLL = new QLBLL();
            int i = 0;
            foreach(ViewPhongTro pt in qLBLL.DgvPhongTro(txt))
            {
                dt.Rows.Add(pt.MaPhongTro,pt.Stt,pt.TenPhongTro,pt.GiaTien,pt.DienTich,pt.TinhTrang,pt.SoNguoiHienCo,pt.SoNguoiToiDa);
            }
            
            dgvPhongTro.DataSource = dt;
            dgvPhongTro.Columns[0].Visible = false;
        }
        private void SetCbb()
        {

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            ThemPhong themPhong = new ThemPhong("123");
            themPhong.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            SuaPhong themSuaph = new SuaPhong();
            themSuaph.ShowDialog();
        }
        //private Form activeForm = null;
        TrangChu tc = new TrangChu();

        private void btnThemday_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemKhach(), panelPhong);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ChitietPhong(), panelPhong);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new SuaPhong(), panelPhong);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }

