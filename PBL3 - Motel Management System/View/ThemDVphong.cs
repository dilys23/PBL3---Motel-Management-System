using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ThemDVphong : Form
    {
        private ThuePhong tp;
        public ThemDVphong(ThuePhong tp)
        {
            InitializeComponent();
            this.tp = tp;
            LoadForm();
        }
        private DataTable ViewData()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "Mã d?ch v?",DataType =  typeof(string)},
                new DataColumn{ColumnName = "STT",DataType =  typeof(int)},
                new DataColumn{ColumnName = "Tên d?ch v?",DataType =  typeof(string)},
                new DataColumn{ColumnName = "Giá d?ch v?",DataType =  typeof(double)},
            });
            return dt;
        }

        public void LoadForm()
        {



            dgvXoaDichVu.Columns[0].Visible = false;
            QLBLL qLBLL = new QLBLL();
            foreach (ViewDichVu viewDichVu in qLBLL.DgvDichVu(null))
            {
                dgvThemDichVu.Rows.Add(viewDichVu.MaDichVu, viewDichVu.Stt, viewDichVu.TenDichVu, viewDichVu.GiaDichVu);
            }

            dgvThemDichVu.Columns[0].Visible = false;

        }
        private void panelThemHD_Paint(object sender, PaintEventArgs e)
        {

        }
        TrangChu tc = new TrangChu();

        private void iconButton4_Click(object sender, EventArgs e)
        {


            List<string> dsdv = new List<string>();
            foreach (DataGridViewRow dr in dgvXoaDichVu.Rows)
            {
                if (dr.Cells[0].Value!=null) dsdv.Add(dr.Cells[0].Value.ToString());

            }
            tp.DsDichVu = dsdv;
            tc.openChildForm1(new ThemHopDong(tp), panelThemHD);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvThemDichVu.CurrentRow;
            ViewDichVu v = new ViewDichVu();
            if (row.Cells[0].Value != null)
            {
                v.MaDichVu = row.Cells[0].Value.ToString();
                v.TenDichVu = row.Cells[2].Value.ToString();
                v.GiaDichVu = Convert.ToDouble(row.Cells[3].Value.ToString());
                v.Stt = 0;
                dgvThemDichVu.Rows.RemoveAt(dgvThemDichVu.CurrentRow.Index);
                dgvXoaDichVu.Rows.Add(v.MaDichVu, 0, v.TenDichVu, v.GiaDichVu);
                for(int i=0;i<dgvXoaDichVu.Rows.Count;i++)
                {
                    dgvXoaDichVu.Rows[i].Cells[1].Value = i+1;
                }
                for(int i=0; i<dgvThemDichVu.Rows.Count;i++)
                {
                    
                    dgvThemDichVu.Rows[i].Cells[1].Value = i+1;
                }


            }
            else
            {
                MessageBox.Show("Danh sách dịch vụ dã trống", "Thông báo");
            }
        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvXoaDichVu.CurrentRow;
            ViewDichVu v = new ViewDichVu();
            if (row.Cells[0].Value != null)
            {
                v.MaDichVu = row.Cells[0].Value.ToString();
                v.TenDichVu = row.Cells[2].Value.ToString();
                v.GiaDichVu = Convert.ToDouble(row.Cells[3].Value.ToString());
                v.Stt = 0;
                dgvXoaDichVu.Rows.RemoveAt(dgvXoaDichVu.CurrentRow.Index);
                dgvThemDichVu.Rows.Add(v.MaDichVu, 0, v.TenDichVu, v.GiaDichVu);
                for (int i = 0; i<dgvXoaDichVu.Rows.Count; i++)
                {
                    dgvXoaDichVu.Rows[i].Cells[1].Value = i+1;
                }
                for (int i = 0; i<dgvThemDichVu.Rows.Count; i++)
                {
                    dgvThemDichVu.Rows[i].Cells[1].Value = i + 1;
                }

            }
            else
            {
                MessageBox.Show("Danh sách dịch vụ dã trống", "Thông báo");
            }
        }
    }
}
