using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietDV : Form
    {
        private string idPhong;
        public ChitietDV(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
        }
        public void LoadForm(string txt)
        {
            try
            {
                dgvDichVu.Rows.Clear();
                QLBLLChung.Instance.customDGV(dgvDichVu);
                int i = 1;
                foreach (string idDv in QLBLLDichvu.Instance.GetAllIdDichVuByIdPhong(this.idPhong))
                {
                    DichVu dv = new DichVu();
                    dv = QLBLLDichvu.Instance.GetDVByIdDV(idDv);
                    dgvDichVu.Rows.Add(dv.MaDichVu, i++, dv.TenDichVu, dv.GiaDichVu.ToString("#,##0") + "₫");
                }
                var Xoa = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
                dgvDichVu.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLLChung.Instance.dgvIcons_CellPainting3(dgvDichVu, e, Xoa));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException?.Message);
                Console.WriteLine(ex.InnerException?.StackTrace);
            }
        }    
    
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            if(QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) && !QLBLLChung.Instance.PhongDaHetHan(idPhong))
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = idPhong; 
                QLBLLChung.Instance.openChildForm1(new ThemDVphong(tp, LoadForm), panelThem);
            }
            else if (!QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) && !QLBLLChung.Instance.PhongDaHetHan(idPhong))
            {
                MessageBox.Show("Phòng chưa được cho thuê!!Không được thêm dịch vụ","Thông báo",MessageBoxButtons.OK);
            }
            else if (QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) && QLBLLChung.Instance.PhongDaHetHan(idPhong))
            {
                MessageBox.Show("Phòng đã quá hạn hợp đồng. Không được thêm dịch vụ", "Thông báo", MessageBoxButtons.OK);
            }
        }

       
        
    }
}
