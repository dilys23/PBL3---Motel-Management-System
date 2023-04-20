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
    public partial class ThemThietBiPhong : Form
    {
        private ThuePhong tp;
        private Loader loader;

        public ThemThietBiPhong(ThuePhong tp, Loader loader)
        {
            InitializeComponent();
            this.tp = tp;
            LoadForm();
            this.loader  = loader;

        }
        public void LoadForm()
        {
            dgvTBThem.Columns[0].Visible = false;
            QLBLL qLBLL = new QLBLL();
            foreach (ViewThietBi viewThietBi in qLBLL.DgvThietBi(null))
            {
                dgvThietBi.Rows.Add(viewThietBi.MaThietBi, viewThietBi.Stt, viewThietBi.TenThietBi, viewThietBi.GiaThietBi);
            }

            dgvThietBi.Columns[0].Visible = false;

        }
        private void Back(string txt)
        {
            this.loader(null);
            this.Close();

        }

        TrangChu tc = new TrangChu();
        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvThietBi.CurrentRow;
            ViewThietBi v = new ViewThietBi();
            if (row.Cells[0].Value != null)
            {
                v.MaThietBi = row.Cells[0].Value.ToString();
                v.TenThietBi = row.Cells[2].Value.ToString();
                v.GiaThietBi = Convert.ToDouble(row.Cells[3].Value.ToString());
                v.Stt = 0;
                dgvThietBi.Rows.RemoveAt(dgvThietBi.CurrentRow.Index);
                dgvTBThem.Rows.Add(v.MaThietBi, 0, v.TenThietBi, v.GiaThietBi);
                for (int i = 0; i < dgvTBThem.Rows.Count; i++)
                {
                    dgvTBThem.Rows[i].Cells[1].Value = i + 1;

                }
                for (int i = 0;i < dgvThietBi.Rows.Count; i++)
                {
                    dgvThietBi.Rows[i].Cells[1].Value = i + 1;
                }    
            }
            else
            {
                MessageBox.Show("Danh sách Thiết Bị đã trống ", "Thông báo");
            } 
                
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvThietBi.CurrentRow;
            ViewThietBi v = new ViewThietBi();
            if (row.Cells[0].Value != null)
            {
                v.MaThietBi = row.Cells[0].Value.ToString();
                v.TenThietBi = row.Cells[2].Value.ToString();
                v.GiaThietBi = Convert.ToDouble(row.Cells[3].Value.ToString());
                v.Stt = 0;
                dgvThietBi.Rows.RemoveAt(dgvThietBi.CurrentRow.Index);
                dgvTBThem.Rows.Add(v.MaThietBi, 0, v.TenThietBi, v.GiaThietBi);
                for (int i = 0; i < dgvTBThem.Rows.Count; i++)
                {
                    dgvTBThem.Rows[i].Cells[1].Value = i + 1;

                }
                for (int i = 0; i < dgvThietBi.Rows.Count; i++)
                {
                    dgvThietBi.Rows[i].Cells[1].Value = i + 1;
                }
            }
            else
            {
                MessageBox.Show("Danh sách Thiết Bị đã trống ", "Thông báo");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            List<string> dstb = new List<string>();
            foreach (DataGridViewRow dr in dgvTBThem.Rows)
            {
                if (dr.Cells[0].Value != null) dstb.Add(dr.Cells[0].Value.ToString());

            }
            tp.DsThietBi = dstb;
            tc.openChildForm1(new ThemHopDong(tp, Back), panelThemHD);
        }
    }
}
