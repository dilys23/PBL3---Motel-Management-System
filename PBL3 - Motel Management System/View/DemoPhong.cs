using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.Properties;
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
     public delegate void Loader1(String s);
    public delegate void _SuKien(object sender, EventArgs e);

    public partial class DemoPhong : Form
    {
        private Button defaultBtn = null;
        private string MaDayTro;
        public DemoPhong()
        {
            InitializeComponent();
            this.MaDayTro = MaDayTro;
            LoadForm(null);
            
        }
        public void LoadForm(string MaDayTro)
        {
            panelPhong.AutoScroll = false;
            panelPhong.HorizontalScroll.Visible = false;
            panelPhong.HorizontalScroll.Maximum = 0;
            panelPhong.AutoScroll = true;
            QLBLL qLBLL = new QLBLL();
            Button defaultBtn = null;

            foreach(DayTro dt in qLBLL.GetAllDayTroBll())
            {

                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.DarkOrange;
                this.btnThemPhong.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
                this.btnThemPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
                this.btnThemPhong.IconSize = 25;
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // "    " + btn.IconSize = 25;
                btn.Size = new System.Drawing.Size(80, 50);
                btn.TabIndex = 21;
                btn.Text = dt.TenDayTro;
                btn.Name = dt.MaDayTro;
                btn.Click += new EventHandler(SuKien);
                panelBtnDay.Controls.Add(btn);
                if(defaultBtn == null)
                {
                    defaultBtn = btn;
                }
                
            }
            if(defaultBtn != null)
            {
                 SuKien(defaultBtn, EventArgs.Empty);
            }
            



        }
        public System.Drawing.Image Image { get; set; }

        private void SuKien(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panelPhong.Controls.Clear();
            QLBLL qLBLL = new QLBLL();
            DayTro dt = qLBLL.GetDayTroById(btn.Name);
            string DiaChi = "    " + dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            lblDiaChi.Text = DiaChi;
            foreach(PhongTro pt in qLBLL.GetPhongTroByIdDay(btn.Name))
            {
                Demo p = new Demo(SuKien,pt.MaPhongTro); 
                p.TopLevel = false;
                p.Visible = true;
                p.Name = pt.MaPhongTro;
                Label lbl1 = new Label();

                //Label label1 = new Label();
               

                lbl1.Text  = pt.TenPhongTro;
                p.SetPanelTenPhongTro(lbl1);
                if (qLBLL.TinhTrangPhongById(pt.MaPhongTro)) //54, 179, 205
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(205))))));
                }
                if(qLBLL.PhongDaCocByIdPhong(pt.MaPhongTro))
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234))))));
                }
                foreach (Nguoi nguoi in qLBLL.GetNguoiByIdPhong(pt.MaPhongTro))
                {
                    Label lbl = new Label();
                    lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
                   lbl.AutoSize = true;
                    lbl.Name = nguoi.MaNguoi;
                    lbl.Text = "   " + nguoi.Ten;
                    lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    Image image1 = Image.FromFile("E:\\PBL3_MAIN\\Icons\\icons8-customer-20.png" + "    ");
                    lbl.Image = image1;
                    lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
                    // Set the size of the label to accommodate the bitmap size.
                    lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                    lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    lbl.TabIndex = 0;
                    // lbl.Size = new Size(50,50 );
                    lbl.Size = new System.Drawing.Size(50, 80);
                    // Initialize the label control's Image property.

                    lbl.Visible = true;
                    p.SetPanelKhach(lbl);
                }
                p.SetBtnName(pt.MaPhongTro);
                 panelPhong.Controls.Add(p);
            }
            panelPhong.Invalidate();
        }
        TrangChu tc = new TrangChu();
        

        private void btnThemPhong_Click_1(object sender, EventArgs e)
        {
           // tc.openChildForm1(new ThemPhong(), panelChinh);
            
        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }
       

        private void btnThemday_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemDay(LoadForm), panelChinh);
            panelBtnDay.Controls.Clear();
        }

        private void btnSuaDay_Click(object sender, EventArgs e)
        {
            //string idDay = btn.Name;
            //tc.openChildForm1(new SuaDay(LoadForm), panelChinh);
            //panelBtnDay.Controls.Clear();
        }
    }
}
