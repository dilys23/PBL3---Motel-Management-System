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
using System.Windows.Controls.Primitives;
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
        public Demo(_SuKien sk,string idPhong)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.IdPhong=idPhong;
            this.sk = sk;

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
            panelTenPhongTro.Controls.Add(lbl);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCoc_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            if (qLBLL.GetHopDongByIdPhong(IdPhong) == null)
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = IdPhong;
                CocPhong cp = new CocPhong(tp, LoadForm);
                cp.Show();
            }
            else
            {
                MessageBox.Show("Phòng hiện tại không thể cọc", "Thông báo");
            }
        }
        TrangChu tc = new TrangChu();
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
           ChitietPT chitiet = new ChitietPT();
           //if(this.ParentForm != null)
           // {
           //     Form trangchu = this.ParentForm;
           //     tc.openChildForm1(chitiet, tc.panelDesktop);
           //     chitiet.Dock= DockStyle.Fill;
           // }
           chitiet.Show();
           
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;              
            SuaPhong sp = new SuaPhong(null,null);
            sp.Show();
        }
    }
}
