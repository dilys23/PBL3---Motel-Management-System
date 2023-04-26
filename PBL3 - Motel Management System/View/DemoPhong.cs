using PBL3___Motel_Management_System.BLL;
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
    public partial class DemoPhong : Form
    {
        public DemoPhong()
        {
            InitializeComponent();
            LoadForm();

        }
        private void LoadForm()
        {
            panelPhong.AutoScroll = false;
            panelPhong.HorizontalScroll.Visible = false;
            panelPhong.HorizontalScroll.Maximum = 0;
            panelPhong.AutoScroll = true;
            QLBLL qLBLL = new QLBLL();
            foreach(DayTro dt in qLBLL.GetAllDayTroBll())
            {
                Button btn = new Button();
                btn.Text = dt.TenDayTro;
                btn.Name = dt.MaDayTro;
                btn.Click += new EventHandler(SuKien);
                panelBtnDay.Controls.Add(btn);
            }
        }
        Random R = new Random();
        private void SuKien(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            panelPhong.Controls.Clear();
            QLBLL qLBLL = new QLBLL();
            foreach(PhongTro pt in qLBLL.GetPhongTroByIdDay(btn.Name))
            {
                Demo p = new Demo();
                int x = panelPhong.Width/10;
                p.TopLevel = false;
                p.Visible = true;
                p.Name = pt.MaPhongTro;
                p.Size = new Size(2*x, 2*x);
                Label lbl1 = new Label();
                lbl1.Text  = pt.TenPhongTro;
                p.SetPanelTenPhongTro(lbl1);
                foreach (Nguoi nguoi in qLBLL.GetNguoiByIdPhong(pt.MaPhongTro))
                {
                    
                    Label lbl = new Label();
                    lbl.Name = nguoi.MaNguoi;
                    lbl.Text = nguoi.Ten;
                    lbl.Visible = true;
                    p.SetPanelKhach(lbl);
                }
            panelPhong.Controls.Add(p);
            }
            panelPhong.Invalidate();
        }
    }
}
