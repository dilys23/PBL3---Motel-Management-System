﻿using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
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
 
    public delegate void _SuKien(object sender, EventArgs e);
    public partial class DemoPhong : Form
    {
       
        private Button defaultBtn = null;
        private string _buttonName;
        public DemoPhong()
        {
            InitializeComponent();
            LoadForm(null);
      
        }
        private void LoadForm(string a)
        {
            panelPhong.AutoScroll = false;
            panelPhong.HorizontalScroll.Visible = false;
            panelPhong.HorizontalScroll.Maximum = 0;
            panelPhong.AutoScroll = true;
            QLBLL qLBLL = new QLBLL();
            Button defaultBtn = null;

            foreach(DayTro dt in qLBLL.GetAllDayTroBll())
            {
                ToolTip tp= new ToolTip();
                Button btn = new Button();
                btn.Size = new Size(100, 50);
                btn.Location = new Point(50, 50);
                btn.Text = dt.TenDayTro;
                btn.Name = dt.MaDayTro;
                tp.SetToolTip(btn, btn.Text);
                btn.BackColor = Color.Orange;
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
        

        private void SuKien(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;         
            panelPhong.Controls.Clear();
            QLBLL qLBLL = new QLBLL();
            DayTro dt = qLBLL.GetDayTroById(btn.Name);
            string DiaChi = dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            lblDiaChi.Text = DiaChi;
            foreach(PhongTro pt in qLBLL.GetPhongTroByIdDay(btn.Name))
            {
                Demo p = new Demo(SuKien,pt.MaPhongTro); 
                p.TopLevel = false;
                p.Visible = true;
                p.Name = pt.MaPhongTro;
                Label lbl1 = new Label();
                lbl1.Text  = pt.TenPhongTro;
                p.SetPanelTenPhongTro(lbl1);
                if (qLBLL.TinhTrangPhongById(pt.MaPhongTro))
                {
                    p.SetColorPanel2(Color.CadetBlue);
                }
                if(qLBLL.PhongDaCocByIdPhong(pt.MaPhongTro))
                {
                    p.SetColorPanel2(Color.MediumAquamarine);
                }
                foreach (Nguoi nguoi in qLBLL.GetNguoiByIdPhong(pt.MaPhongTro))
                {
                    Label lbl = new Label();
                    lbl.Name = nguoi.MaNguoi;
                    lbl.Text = nguoi.Ten;
                    
                    lbl.Visible = true;
                    p.SetPanelKhach(lbl);
                }
                p.SetBtnName(pt.MaPhongTro);
                 panelPhong.Controls.Add(p);
            }
            panelPhong.Invalidate();
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void btnThemPhong_Click_1(object sender, EventArgs e)
        {
            
        }

        private void DemoPhong_Load(object sender, EventArgs e)
        {
          
        }
        TrangChu tc= new TrangChu();

        private void btnThemday_Click(object sender, EventArgs e)
        {

            tc.openChildForm1(new ThemDay(LoadForm), panelDemoPhong);
            panelBtnDay.Controls.Clear();
        }
        

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            if (btn != null)
            {          
                tc.openChildForm1(new SuaDay(btn.Name, LoadForm), panelDemoPhong);
                panelBtnDay.Controls.Clear();
            }
            else
            {
                MessageBox.Show("Day null", "Thong bao");
            }

           
        }
     
    }
}
