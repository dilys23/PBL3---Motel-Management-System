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
            int i = 0;
                foreach (DichVu viewDichVu in QLBLL.Instance.DgvDichVu(null))
                {
                    if (viewDichVu.MaDichVu != "000" && viewDichVu.MaDichVu != "001")
                    {
                    if (tp.hopDong.MaHopDong != null && QLBLL.Instance.GetAllIdDichVuByIdPhong(tp.hopDong.MaPhongTro).Count == 0)
                    {
                        dgvThemDichVu.Rows.Add(viewDichVu.MaDichVu, ++i, viewDichVu.TenDichVu, viewDichVu.GiaDichVu);
                    }
                    else if (tp.hopDong.MaHopDong == null)
                    {
                        bool check = false;
                        foreach (string idDv in QLBLL.Instance.GetAllIdDichVuByIdPhong(tp.hopDong.MaPhongTro))
                        {
                            if (idDv != "000" && idDv != "001")
                            {
                                if (idDv == viewDichVu.MaDichVu)
                                {
                                    check = true;
                                    break;
                                }
                            }
                        }
                        if (!check)
                          {
                            dgvThemDichVu.Rows.Add(viewDichVu.MaDichVu, ++i, viewDichVu.TenDichVu, viewDichVu.GiaDichVu);
                          }
                       }
                    }
                    else
                    {
                        dgvDVcodinh.Rows.Add(viewDichVu.MaDichVu, ++i, viewDichVu.TenDichVu, viewDichVu.GiaDichVu);
                    }
                }
                foreach (string idDv in QLBLL.Instance.GetAllIdDichVuByIdPhong(tp.hopDong.MaPhongTro))
                {
                    if (idDv != "000" && idDv != "001")
                    {
                        DichVu dv = new DichVu();
                        dv = QLBLL.Instance.GetDVByIdDV(idDv);
                        dgvXoaDichVu.Rows.Add(dv.MaDichVu, i++, dv.TenDichVu, dv.GiaDichVu);
                    }
                }

            for (int j = 0; j<dgvXoaDichVu.Rows.Count; j++)
            {
                dgvXoaDichVu.Rows[j].Cells[1].Value = j+1;
            }
            for (int j = 0; j<dgvThemDichVu.Rows.Count; j++)
            {

                dgvThemDichVu.Rows[j].Cells[1].Value = j+1;
            }
            dgvThemDichVu.Columns[0].Visible = false;
            }
        
        private void panelThemHD_Paint(object sender, PaintEventArgs e)
        {

        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            
            if (tp.hopDong.MaHopDong != null)
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
                QLBLL.Instance.openChildForm1(new ThemThietBiPhong(tp, Back), panelThemDV);
            }
            else
            {
                List<string> dsdv = new List<string>();
                QLBLL.Instance.DelCHiTietDichVuByIdPhong(tp.hopDong.MaPhongTro);
                foreach (DataGridViewRow dr in dgvXoaDichVu.Rows)
                {
                    if (dr.Cells[0].Value != null)
                    {
                        ChiTietDichVu ctdv = new ChiTietDichVu();
                        ctdv.MaChiTietDichVu = QLBLL.Instance.TaoIdChiTietDichVu();
                        ctdv.MaPhongTro = tp.hopDong.MaPhongTro;
                        ctdv.MaDichVu = dr.Cells[0].Value.ToString();
                        ctdv.TonTai = true;
                        QLBLL.Instance.AddChiTietDichVuBll(ctdv);
                        dsdv.Add(dr.Cells[0].Value.ToString());
                    }
                }
                foreach (DataGridViewRow dr in dgvDVcodinh.Rows)
                {

                    if (dr.Cells[0].Value != null)
                    {
                        ChiTietDichVu ctdv = new ChiTietDichVu();
                        ctdv.MaChiTietDichVu = QLBLL.Instance.TaoIdChiTietDichVu();
                        ctdv.MaPhongTro = tp.hopDong.MaPhongTro;
                        ctdv.MaDichVu = dr.Cells[0].Value.ToString();
                        ctdv.TonTai = true;
                        QLBLL.Instance.AddChiTietDichVuBll(ctdv);
                        dsdv.Add(dr.Cells[0].Value.ToString());
                    }
                }
                tp.DsDichVu = dsdv;
                MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
                this.Close();
                this.loader(null);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvThemDichVu.CurrentRow;
            DichVu v = new DichVu();
            if (row.Cells[0].Value != null)
            {
                v.MaDichVu = row.Cells[0].Value.ToString();
                v.TenDichVu = row.Cells[2].Value.ToString();
                v.GiaDichVu = Convert.ToDouble(row.Cells[3].Value.ToString());
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
            DichVu v = new DichVu();
            if (row.Cells[0].Value != null)
            {
                v.MaDichVu = row.Cells[0].Value.ToString();
                v.TenDichVu = row.Cells[2].Value.ToString();
                v.GiaDichVu = Convert.ToDouble(row.Cells[3].Value.ToString());
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
