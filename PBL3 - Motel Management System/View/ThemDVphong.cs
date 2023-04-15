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
        private Nguoi nguoi;
        public ThemDVphong(Nguoi nguoi)
        {
            InitializeComponent();
            this.nguoi = nguoi;
            LoadForm();
        }
        private DataTable ViewData()
        {
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "Mã dịch vụ",DataType =  typeof(string)},
                new DataColumn{ColumnName = "STT",DataType =  typeof(int)},
                new DataColumn{ColumnName = "Tên dịch vụ",DataType =  typeof(string)},
                new DataColumn{ColumnName = "Giá dịch vụ",DataType =  typeof(double)},
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
            tc.openChildForm1(new ThemHopDong(), panelThemHD);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvThemDichVu.CurrentRow;
            ViewDichVu v = new ViewDichVu();
            if(row.Cells[0].Value != null)
            {
            v.MaDichVu = row.Cells[0].Value.ToString();
            v.TenDichVu = row.Cells[2].Value.ToString();
            v.GiaDichVu = Convert.ToDouble(row.Cells[3].Value.ToString());
            v.Stt = 0;
            int i = 0;
            int k = 0;
            foreach (DataGridViewRow dr in dgvThemDichVu.Rows)
            {
                if(dr != null)
                {
                    dgvThemDichVu.Rows[k].Cells[1].Value = i.ToString();
                    k++;
                    i++;
                }
            }
            dgvThemDichVu.Rows.RemoveAt(dgvThemDichVu.CurrentRow.Index);

            int g = dgvXoaDichVu.Rows.Count;
                

            dgvXoaDichVu.Rows.Add(v.MaDichVu,g++,v.TenDichVu,v.GiaDichVu);
                
            }
            else
            {
                MessageBox.Show("Danh sách dịch vụ đã trống", "Thông báo");
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
                int i = 0;
                int k = 0;
                foreach (DataGridViewRow dr in dgvXoaDichVu.Rows)
                {
                    if (dr != null)
                    {
                        dgvXoaDichVu.Rows[k].Cells[1].Value = i.ToString();
                        k++;
                        i++;
                    }
                }
                
                dgvXoaDichVu.Rows.RemoveAt(dgvXoaDichVu.CurrentRow.Index);
                int g = dgvThemDichVu.Rows.Count;
                dgvThemDichVu.Rows.Add(v.MaDichVu,g++, v.TenDichVu, v.GiaDichVu);
                
            }
            else
            {
                MessageBox.Show("Danh sách dịch vụ đã trống", "Thông báo");
            }
        }
    }
}
