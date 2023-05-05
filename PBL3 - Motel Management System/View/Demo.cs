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

        }
        public void LoadForm(string txt)
        {
            Button btn = new Button();
            QLBLL qLBLL = new QLBLL();
            DayTro dt = qLBLL.GetDayTroByIdPhong(IdPhong);
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

            Image image1 = Image.FromFile("D:\\PBL3\\PBL3_Main\\PBL3 - Motel Management System\\Icons\\icons8-home-30.png" + "    ");
            lbl.Image = image1;
            lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // Set the size of the label to accommodate the bitmap size.
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl.TabIndex = 0;
            // lbl.Size = new Size(50,50 );
            lbl.Size = new System.Drawing.Size(110, 50);
            panelTenPhongTro.Controls.Add(lbl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;
        public void openChildForm1(Form childForm, System.Windows.Forms.Panel p)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            p.Controls.Add(childForm);
            p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        //TrangChu tc = new TrangChu();
      
        private void btnChiTiet_Click(object sender, EventArgs e)
        {

        }

        private void btnCoc_Click_1(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            if (qLBLL.GetHopDongByIdPhong(IdPhong) == null)
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = IdPhong;
                 openChildForm1(new CocPhong(tp, LoadForm), panel);
            }
            else
            {
                MessageBox.Show("Phòng hiện tại không thể cọc", "Thông báo");
            }
        }
        TrangChu tc = new TrangChu();

        private void btnChiTiet_Click_1(object sender, EventArgs e)
        {
            //ChitietPhongtro ct = new ChitietPhongtro();
            //ct.Show();
            //tc.openChildForm1(new ChitietPhongtro(), panel);
            openChildForm1(new ChiTietPT(IdPhong), panel);
        }

        private void btnChoThue_Click(object sender, EventArgs e)
        {
            //ThuePhong tp = new ThuePhong();
            //QLBLL qLBLL = new QLBLL();
            //tp.hopDong.MaHopDong = qLBLL.TaoIdHopDong();
            //tp.hopDong.MaPhongTro = dgvPhongTro.CurrentRow.Cells[0].Value.ToString();
            //tc.openChildForm1(new ThemKhach(tp, LoadForm), panelPhong);
            QLBLL qLBLL = new QLBLL();
            if (qLBLL.GetHopDongByIdPhong(IdPhong) == null)
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaHopDong = qLBLL.TaoIdHopDong();
                tp.hopDong.MaPhongTro = IdPhong;
                openChildForm1(new ThemKhach(tp, LoadForm), panel);
            }
            else if(qLBLL.PhongDaCocByIdPhong(IdPhong))
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong = qLBLL.GetHopDongByIdPhong(IdPhong);
                tc.openChildForm1(new ThemKhach(tp, LoadForm), panel);
            }
            else
            {
                MessageBox.Show("Phòng hiện tại đã được cho thuê", "Thông báo");
            }
        }

      

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            if(qLBLL.TinhTrangPhongById(IdPhong)==true || qLBLL.PhongDaCocByIdPhong(IdPhong)==true)
            {
                MessageBox.Show("Phòng hiện không thể xóa", "Thông báo");
            }
            else
            {
                DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa ","Cảnh báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(kq == DialogResult.OK)
                {
                    qLBLL.DelCHiTietThietBiByIdPhongBLL(IdPhong);
                    qLBLL.DelPhongTroBLL(IdPhong);
                    MessageBox.Show("Xóa phòng trọ thành công", "Thông báo");
                    this.Close();
                    // LoadForm(null);
                }
               
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
           tc.openChildForm1(new SuaPhong(IdPhong,LoadForm), panel);
        }
    }
}
