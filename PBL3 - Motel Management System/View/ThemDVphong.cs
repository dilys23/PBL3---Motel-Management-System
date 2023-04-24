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
        private Loader loader;
        public ThemDVphong(ThuePhong tp, Loader loader)
        {
            InitializeComponent();
            this.tp = tp;
            LoadForm();
            this.loader=loader;
        }
        private void Back(string txt)
        {
            this.loader(null);
            this.Close();

        }
       

        public void LoadForm()
        {
            dgvXoaDichVu.Columns[0].Visible = false;
            QLBLL qLBLL = new QLBLL();
            int i = 0;
            foreach (ViewDichVu viewDichVu in qLBLL.DgvDichVu(null))
            {  if(viewDichVu.MaDichVu != "000" && viewDichVu.MaDichVu != "001")
                {

                dgvThemDichVu.Rows.Add(viewDichVu.MaDichVu, ++i, viewDichVu.TenDichVu, viewDichVu.GiaDichVu);
                }
                else
                {
                    dgvDVcodinh.Rows.Add(viewDichVu.MaDichVu, viewDichVu.Stt, viewDichVu.TenDichVu, viewDichVu.GiaDichVu);
                }
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
                if (dr.Cells[0].Value != null) dsdv.Add(dr.Cells[0].Value.ToString());

            }
            foreach (DataGridViewRow dr in dgvDVcodinh.Rows)
            {
                if (dr.Cells[0].Value != null) dsdv.Add(dr.Cells[0].Value.ToString());

            }
            tp.DsDichVu = dsdv;
            tc.openChildForm1(new ThemThietBiPhong(tp, Back), panelThemDV);
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
