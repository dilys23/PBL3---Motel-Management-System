using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ThemThietBiPhong : Form
    {
        private string idPhong;
        private Loader loader;
        CultureInfo vietnamCulture = new CultureInfo("vi-VN");
        public ThemThietBiPhong(string idPhong, Loader loader)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm();
            this.loader  = loader;

        }
        public void LoadForm()
        {   
            dgvTBThem.RowCount = 0;
            dgvThietBi.RowCount = 0;
            foreach (ThietBi viewThietBi in QLBLLThietbi.Instance.DgvThietBi(null))
            {
                dgvThietBi.Rows.Add(viewThietBi.MaThietBi, 1, viewThietBi.TenThietBi, viewThietBi.GiaThietBi.ToString("#,##0") + "₫");
            }
                int j = 0;
                foreach (string idCttb in QLBLLChiTietThietBi.Instance.GetAllIdCHiTietThietBiByIdPhong(idPhong))
                {
                    ChiTietThietBi cttb = QLBLLChiTietThietBi.Instance.GetChiTietThietBiById(idCttb);
                    ThietBi tb = QLBLLThietbi.Instance.GetTBByIdTB(cttb.MaThietBi);
                    dgvTBThem.Rows.Add(tb.MaThietBi, ++j, tb.TenThietBi, tb.GiaThietBi.ToString("#,##0") + "₫", cttb.SoLuong);
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
                v.GiaThietBi = (Convert.ToDouble(row.Cells[3].Value.ToString().Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", "")));
                for (int i=0;i<dgvTBThem.Rows.Count;i++)
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
                        dgvTBThem.Rows.Add(v.MaThietBi, 0, v.TenThietBi, v.GiaThietBi.ToString("C0") + "₫", 1);
                }
                for (int i = 0; i < dgvTBThem.Rows.Count; i++)
                {
                    dgvTBThem.Rows[i].Cells[1].Value = i + 1;
                }
                
            }
             
                
        }

        private void btnXoaTB_Click(object sender, EventArgs e)
        {
            if(dgvTBThem.RowCount > 0)
            {
                DataGridViewRow row = dgvTBThem.CurrentRow;
                ThietBi v = new ThietBi();
                if (row.Cells[0].Value != null)
                {
                    v.MaThietBi = row.Cells[0].Value.ToString();
                    v.TenThietBi = row.Cells[2].Value.ToString();
                    v.GiaThietBi = (Convert.ToDouble(row.Cells[3].Value.ToString().Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", "")));
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

            }
            else
            {
                MessageBox.Show("Danh sách Thiết Bị đã trống ", "Thông báo");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            List<ChiTietThietBi> list = new List<ChiTietThietBi>();
            foreach (DataGridViewRow dr in dgvTBThem.Rows)
            {
                if (dr.Cells[0].Value != null)
                {
                    list.Add(new ChiTietThietBi()
                    {
                        MaThietBi = dr.Cells[0].Value.ToString(),
                        SoLuong = Convert.ToInt32(dr.Cells[4].Value.ToString()),
                        MaPhongTro =idPhong
                    });
                }
            }
            QLBLLChiTietThietBi.Instance.ThayDoiThietBiPhong(list,idPhong);
            MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
            this.Close();
            this.loader(null);

        }
    }
}
