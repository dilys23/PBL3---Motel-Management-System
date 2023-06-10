using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
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
#pragma warning disable CS0414 // The field 'DemoPhong.defaultBtn' is assigned but its value is never used
        private Button defaultBtn = null;
#pragma warning restore CS0414 // The field 'DemoPhong.defaultBtn' is assigned but its value is never used
        private Button ClickBtn = null;
        public DemoPhong()
        {
            InitializeComponent();
            LoadForm(null);
            SetCbb();
        }
        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbTinhTrang.Items.Clear();
            cbbDayTro.Items.AddRange(QLBLLChung.Instance.GetCbbDayTro().ToArray());
            cbbTinhTrang.Items.AddRange(QLBLLChung.Instance.GetCbbTinhTrangPhong().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
        }
        public void LoadForm(string txt)
        {      
            panelBtnDay.Controls.Clear();
            panelPhong.AutoScroll = false;
            panelPhong.HorizontalScroll.Visible = false;
            panelPhong.HorizontalScroll.Maximum = 0;
            panelPhong.AutoScroll = true;
            Button defaultBtn = null;
            foreach(DayTro dt in QLBLLDayTro.Instance.GetAllDayTroBll())
            {
                ToolTip tp = new ToolTip();
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.DarkOrange;
                this.btnThemPhong.IconChar = FontAwesome.Sharp.IconChar.FileArrowUp;
                this.btnThemPhong.IconFont = FontAwesome.Sharp.IconFont.Auto;
                this.btnThemPhong.IconSize = 25;
                btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                btn.Size = new System.Drawing.Size(80, 50);
                btn.TabIndex = 21;
                btn.Text = dt.TenDayTro;
                btn.Name = dt.MaDayTro;
                tp.SetToolTip(btn, btn.Text);
                btn.Click += new EventHandler(SuKien);
                panelBtnDay.Controls.Add(btn);
                if(defaultBtn == null)
                {
                    defaultBtn = btn;
                    ClickBtn = btn;
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
            btnThemPhong.Visible = true;
            Button btn = sender as Button;
            ClickBtn = btn;
            panelPhong.Controls.Clear();
            DayTro dt = QLBLLDayTro.Instance.GetDayTroById(btn.Name);
            string DiaChi = "    " + dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            lblDiaChi.Text = DiaChi;
            foreach(PhongTro pt in QLBLLPhongTro.Instance.GetPhongTroByIdDay(btn.Name))
            {
                Demo p = new Demo(SuKien,pt.MaPhongTro,panelChinh); 
                p.TopLevel = false;
                p.Visible = true;
                p.Name = pt.MaPhongTro;
                Label lbl1 = new Label();
                lbl1.Text  = pt.TenPhongTro;
                p.SetPanelTenPhongTro(lbl1);
                if (QLBLLPhongTro.Instance.TinhTrangPhongById(pt.MaPhongTro)) //54, 179, 205
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(205))))));
                }
                if(QLBLLPhongTro.Instance.PhongDaCocByIdPhong(pt.MaPhongTro))
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234))))));
                }
                foreach (Nguoi nguoi in QLBLLNguoi.Instance.GetNguoiByIdPhong(pt.MaPhongTro))
                {
                    p.SetPanelKhach(QLBLLNguoi.Instance.GetLabelByNguoi(nguoi));
                }

                if (QLBLLChung.Instance.CanhBaoTraPhong(pt.MaPhongTro))
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(153))))));
                   
                }
                if(QLBLLChung.Instance.PhongDaHetHan(pt.MaPhongTro)) // 
                {
                    
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(99)))), ((int)(((byte)(88))))));
                }
                p.SetBtnName(pt.MaPhongTro);
                 panelPhong.Controls.Add(p);
            }
            panelPhong.Invalidate();
        }
        private void btnThemPhong_Click_1(object sender, EventArgs e)
        {
            if(ClickBtn != null)
            {
                DayTro dt = QLBLLDayTro.Instance.GetDayTroById(ClickBtn.Name);
                QLBLLChung.Instance.openChildForm1(new ThemPhong(dt.MaDayTro,null,LoadForm, SuKien), panelChinh);
            }         
        }

        private void btnThemday_Click(object sender, EventArgs e)
        {
            QLBLLChung.Instance.openChildForm1(new ThemDay(null,LoadForm,SuKien), panelChinh);
        }

        private void btnSuaDay_Click(object sender, EventArgs e)
        {
            
            if (ClickBtn != null)
            {
                DayTro dt = QLBLLDayTro.Instance.GetDayTroById(ClickBtn.Name);
                QLBLLChung.Instance.openChildForm1(new ThemDay(dt.MaDayTro, LoadForm, SuKien), panelChinh);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string idDay = ((ViewCbb)(cbbDayTro.SelectedItem)).key;
            string idTinhTrang = ((ViewCbb)(cbbTinhTrang.SelectedItem)).key;
            panelPhong.Controls.Clear();
            if(idDay != "-1")
            {
                lblDiaChi.Text = QLBLLDayTro.Instance.GetDiaChiByIdDay(idDay);
            }
            else
            {
                lblDiaChi.Text = "";
                btnThemPhong.Visible = false;
            }
            foreach (PhongTro pt in QLBLLPhongTro.Instance.PhongTroTimKiem(idDay,idTinhTrang,txtTimKiem.Text))
            {
                Demo p = new Demo(SuKien, pt.MaPhongTro, panelChinh);
                p.TopLevel = false;
                p.Visible = true;
                p.Name = pt.MaPhongTro;
                Label lbl1 = new Label();
                lbl1.Text  = pt.TenPhongTro;
                p.SetPanelTenPhongTro(lbl1);
                if (QLBLLPhongTro.Instance.TinhTrangPhongById(pt.MaPhongTro)) //54, 179, 205
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(205))))));
                }
                if (QLBLLPhongTro.Instance.PhongDaCocByIdPhong(pt.MaPhongTro))
                {
                    p.SetColorPanel2(Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(230)))), ((int)(((byte)(234))))));
                }
                foreach (Nguoi nguoi in QLBLLNguoi.Instance.GetNguoiByIdPhong(pt.MaPhongTro))
                {
                    p.SetPanelKhach(QLBLLNguoi.Instance.GetLabelByNguoi(nguoi));
                }
                p.SetBtnName(pt.MaPhongTro);
                panelPhong.Controls.Add(p);
            }
            panelPhong.Invalidate();

        }
        private void btnXoaDay_Click_1(object sender, EventArgs e)
        {
            if (ClickBtn != null)
            {
                
                if(QLBLLDayTro.Instance.CheckDay(ClickBtn.Name)==false)
                {
                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        QLBLLDayTro.Instance.DelDayTroBll(ClickBtn.Name);
                        LoadForm(null);
                    }              
                }
                else
                {
                    MessageBox.Show("Dãy có phòng đang thuê không được xóa ");
                } 
            }
        }
    }
}
