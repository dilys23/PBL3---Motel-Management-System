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
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class Demo : Form
    {
        private _SuKien sk;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private string IdPhong;
        private Panel panel;
        public Demo(_SuKien sk,string idPhong,Panel panel)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.IdPhong=idPhong;
            this.sk = sk;
            this.panel = panel;
            //DateTime ngayHienTai = DateTime.Now;
            //HopDong hd = QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong);
            //if (hd != null)
            //{
            //    DateTime ngayketthuc = DateTime.Parse(hd.NgayKetThuc);
            //    TimeSpan khoangthoigian = ngayketthuc - ngayHienTai;
            //    if (khoangthoigian.TotalDays < 0)
            //    {
            //        btnTra_Click(btnTra, EventArgs.Empty);
            //        LoadForm(null);
            //    }
            //}
            
        }
      
        public void LoadForm(string txt)
        {
            Button btn = new Button();
            DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(IdPhong);
            btn.Name = dt.MaDayTro;
            this.sk(btn, EventArgs.Empty);
        }
        public void SetBtnName(string btnName)
        {
            btnChiTiet.Name = btnName;
            btnChoThue.Name = btnName;
            btnChiTiet.Name = btnName;
            btnTra.Name = btnName;
        }
        public void SetColorPanel2( Color c )
        {
            panel2.BackColor = c;
        }
        public void SetPanelKhach(Label lbl)
        {
            panelTenKhach.Controls.Add(lbl);
        }
        public void SetPanelTenPhongTro(Label lbl)
        {
            lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Image image1 = Image.FromFile("D:\\PBL\\PBL3_MAIN\\PBL3 - Motel Management System\\Icons\\icons8-home-30.png" + "    ");
            lbl.Image = image1;
            lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl.TabIndex = 0;
            lbl.Size = new System.Drawing.Size(110, 50);
            panelTenPhongTro.Controls.Add(lbl);
        }
        private void btnCoc_Click_1(object sender, EventArgs e)
        {
            if (QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong) == null)
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = IdPhong;
                 QLBLLChung.Instance.openChildForm1(new CocPhong(tp, LoadForm), panel);
            }
            else
            {
                MessageBox.Show("Phòng hiện tại không thể cọc", "Thông báo");
            }
        }
        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            if(QLBLLChung.Instance.PhongDaHetHan(IdPhong))
            {
                MessageBox.Show("Phòng này đã quá hạn hợp đồng. Vui lòng gia hạn hoặc trả phòng", "Thông báo", MessageBoxButtons.OK);
            }
            QLBLLChung.Instance.openChildForm1(new ChiTietPT(sk,IdPhong), panel);
        }

        private void btnChoThue_Click(object sender, EventArgs e)
        {
            if (QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong) == null)
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaHopDong = QLBLLHopDong.Instance.TaoIdHopDong();
                tp.hopDong.MaPhongTro = IdPhong;
                QLBLLChung.Instance.openChildForm1(new ThemKhach(tp, LoadForm), panel);
            }
            else if(QLBLLPhongTro.Instance.PhongDaCocByIdPhong(IdPhong))
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong = QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong);
                QLBLLChung.Instance.openChildForm1(new ThemKhach(tp, LoadForm), panel);
            }
            else
            {
                MessageBox.Show("Phòng hiện tại đã được cho thuê", "Thông báo");
            }
        }
        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            if(QLBLLPhongTro.Instance.TinhTrangPhongById(IdPhong)==true || QLBLLPhongTro.Instance.PhongDaCocByIdPhong(IdPhong)==true)
            {
                MessageBox.Show("Phòng hiện không thể xóa", "Thông báo");
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa ","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(kq == DialogResult.OK)
                {
                    //qLBLL.DelCHiTietThietBiByIdPhongBLL(IdPhong);
                    QLBLLPhongTro.Instance.DelPhongTroBLL(IdPhong);
                    MessageBox.Show("Xóa phòng trọ thành công", "Thông báo");
                    this.Close();
                    // LoadForm(null);
                }
               
            }
        }
        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(IdPhong);
            QLBLLChung.Instance.openChildForm1(new ThemPhong(dt.MaDayTro,IdPhong,LoadForm,null), panel);
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có thực sự muốn hoàn trả phòng ", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (kq == DialogResult.OK)
            {
                HopDong hd = QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong);
                DialogResult kq1 = MessageBox.Show("Phòng có được trả đúng kì hạn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if((kq1 == DialogResult.Yes))
                {
<<<<<<< HEAD
                    MessageBox.Show("Hoàn trả phòng đúng với thời gian hợp đồng, trả lại tiền cọc cho khách thuê : " + hd.TienCoc.ToString("#,##0") + "₫");
                    hd.TienCoc = 0;
                    QLBLLHopDong.Instance.UpdateHopDongBLL(hd);
=======
                    MessageBox.Show("Vui lòng hoàn lại tiền cọc cho khách hàng: "+ QLBLLChung.Instance.ChuyenDoiSangKieuTien(hd.TienCoc),"Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã thu tiền cọc của khách hàng: "+ QLBLLChung.Instance.ChuyenDoiSangKieuTien(hd.TienCoc), "Thông báo");
>>>>>>> 8551cb7d5e930f3d211e9e0bd340661d1f4d9f4b
                }
                QLBLLHopDong.Instance.DelHopDong(hd.MaHopDong);
                QLBLLChiTietSuDungDichVu.Instance.DelChiTietSuDungDichVuByIdPhong(IdPhong);
                foreach (ChiTietDichVu ct in QLBLLChiTietDichVu.Instance.GetChiTietDichVuByIdPhong(IdPhong))
                {
                    QLBLLChiTietDichVu.Instance.DelChiTietDichVu(ct.MaChiTietDichVu);
                }
                foreach (string tv in QLBLLThanhVienTrongPhong.Instance.GetIDThanhvienbyIDPhong(IdPhong))
                {
                    QLBLLThanhVienTrongPhong.Instance.DelThanhVienBLL(tv);
                }
                foreach(Nguoi nguoi in QLBLLNguoi.Instance.GetNguoiByIdPhong(IdPhong))
                {
                    QLBLLNguoi.Instance.DelNguoiBll(nguoi.MaNguoi);
                }
                foreach(string hoadon in QLBLLHoadon.Instance.GetHoaDonByIdPhong(IdPhong))
                {
                    QLBLLHoadon.Instance.DelHoaDonBll(hoadon);
                }
                
                MessageBox.Show("Hoàn trả phòng thành công", "Thông báo");
                this.Close();
                LoadForm(null);
            }
        }
    }
}
