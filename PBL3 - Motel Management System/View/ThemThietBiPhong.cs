using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
            int j = 0;
            foreach (ThietBi viewThietBi in qLBLL.DgvThietBi(null))
            {
                dgvThietBi.Rows.Add(viewThietBi.MaThietBi, ++j, viewThietBi.TenThietBi, viewThietBi.GiaThietBi);
            }

            dgvThietBi.Columns[0].Visible = false;
            List<ChiTietThietBi> list = new List<ChiTietThietBi>();
            list = qLBLL.GetChiTietThietBiByIdPhong(tp.hopDong.MaPhongTro);
            if (tp.hopDong.MaHopDong == null)
            {
                foreach (ChiTietThietBi cttb in list)
                {
                    for (int i = 0; i < dgvThietBi.Rows.Count; i++)
                    {
                        if (dgvThietBi.Rows[i].Cells[0].Value != null)
                        {
                            if (cttb.MaThietBi == dgvThietBi.Rows[i].Cells[0].Value.ToString())
                            {
                                ThietBi v = qLBLL.GetTBByIdTB(cttb.MaThietBi); 
                                dgvTBThem.Rows.Add(v.MaThietBi, 0, v.TenThietBi, v.GiaThietBi, cttb.SoLuong);
                            }
                        }
                    }
                }
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
               
                int i = 0;
                foreach (string idCttb in qLBLL.GetAllIdCHiTietThietBiByIdPhong(tp.hopDong.MaPhongTro))
                {
                    ChiTietThietBi cttb = qLBLL.GetChiTietThietBiById(idCttb);
                    ThietBi tb = qLBLL.GetTBByIdTB(cttb.MaThietBi);
                    dgvTBThem.Rows.Add(tb.MaThietBi, ++i, tb.TenThietBi, tb.GiaThietBi, cttb.SoLuong);
                }

            }

        }
        private void Back(string txt)
        {
            this.loader(null);
            this.Close();

        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemTB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvThietBi.CurrentRow;
            ThietBi v = new ThietBi();
            if (row.Cells[0].Value != null)
            {
                bool Status = false;
                v.MaThietBi = row.Cells[0].Value.ToString();
                v.TenThietBi = row.Cells[2].Value.ToString();
                v.GiaThietBi = Convert.ToDouble(row.Cells[3].Value.ToString());
                for(int i=0;i<dgvTBThem.Rows.Count;i++)
                {
                    if(dgvTBThem.Rows[i].Cells[0].Value != null)
                    {

                        if(dgvTBThem.Rows[i].Cells[0].Value.ToString() == v.MaThietBi)
                        {
                            int k = Convert.ToInt32(dgvTBThem.Rows[i].Cells[4].Value);
                            dgvTBThem.Rows[i].Cells[4].Value = k+1;
                            Status = true;
                        }    
                        
                    }
                }
                if(!Status)
                {
                        dgvTBThem.Rows.Add(v.MaThietBi, 0, v.TenThietBi, v.GiaThietBi, 1);
                }
                for (int i = 0; i < dgvTBThem.Rows.Count; i++)
                {
                    dgvTBThem.Rows[i].Cells[1].Value = i + 1;
                }
                
            }
             
                
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvTBThem.CurrentRow;
            ThietBi v = new ThietBi();
            if (row.Cells[0].Value != null)
            {
                v.MaThietBi = row.Cells[0].Value.ToString();
                v.TenThietBi = row.Cells[2].Value.ToString();
                v.GiaThietBi = Convert.ToDouble(row.Cells[3].Value.ToString());
                if(dgvTBThem.CurrentRow.Cells[4].Value != null)
                {

                if (Convert.ToInt32(dgvTBThem.CurrentRow.Cells[4].Value.ToString()) == 1)
                    { 

                dgvTBThem.Rows.RemoveAt(dgvTBThem.CurrentRow.Index);
                }
                    else
                    {
                        int k = Convert.ToInt32(dgvTBThem.CurrentRow.Cells[4].Value.ToString());
                        dgvTBThem.CurrentRow.Cells[4].Value = k-1;
                    }
                }
                
                for (int i = 0; i < dgvTBThem.Rows.Count; i++)
                {
                    dgvTBThem.Rows[i].Cells[1].Value = i + 1;

                }
                
            }
            else
            {
                MessageBox.Show("Danh sách Thiết Bị đã trống ", "Thông báo");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            qLBLL.DelCHiTietThietBiByIdPhongBLL(tp.hopDong.MaPhongTro);
            foreach (DataGridViewRow dr in dgvTBThem.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    ChiTietThietBi cttb = new ChiTietThietBi();
                    cttb.MaChiTietThietBi = qLBLL.TaoIdChiTietThietBi();
                    cttb.MaThietBi = dr.Cells[0].Value.ToString();
                    cttb.MaPhongTro = tp.hopDong.MaPhongTro;
                    cttb.SoLuong = Convert.ToInt32(dr.Cells[4].Value.ToString());
                    cttb.TonTai = true;
                    qLBLL.AddChiTietThietBiBll(cttb);
                }

            }
            if (tp.hopDong.MaHopDong != null)
            {
                qLBLL.openChildForm1(new ThemHopDong(tp, Back), panelThemHD);
            }
            else
            {   
                
                MessageBox.Show("Thay đổi thành công","Thông báo",MessageBoxButtons.OK);
                this.Close();
                this.loader(null);
            }
        }
    }
}
