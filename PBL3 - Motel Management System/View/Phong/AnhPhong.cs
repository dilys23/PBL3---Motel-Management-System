using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace PBL3___Motel_Management_System.View.Phong
{
    public partial class AnhPhong : Form
    {
        private string idPhong;
        private List<string> idChiTietAnh = new List<string>();
        
        public AnhPhong(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
        }
        public void LoadForm(string txt)
        {
            panelAnh.Controls.Clear();
            panelAnh.AutoScroll = false;
            panelAnh.HorizontalScroll.Visible = false;
            panelAnh.HorizontalScroll.Maximum = 0;
            panelAnh.AutoScroll = true;
            foreach (ChiTietAnhPhong ct in QLBLLChiTietAnhPhong.Instance.GetChiTietAnhPhongByIdPhong(idPhong))
            {
                PictureBox pct = new PictureBox();
                pct.Name = ct.MaChiTietAnhPhong;
                pct.Image = QLBLLChung.Instance.Base64ToImage(ct.Anh);
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                pct.Size = new Size(300,300);
                pct.MouseClick += event1;
                pct.Paint += paint;
                panelAnh.Controls.Add(pct);


            }

        }
        private void event1(object sender, MouseEventArgs e)
        {
            PictureBox pct = (PictureBox)sender;
            if ((Color)pct.Tag == Color.Red)
            {
                pct.Tag = Color.Blue;
                idChiTietAnh.Add(pct.Name);
            }
            else
            {
                pct.Tag = Color.Red;
                idChiTietAnh.Remove(pct.Name);
            }
            pct.Refresh();
        }
        private void paint (object sender, PaintEventArgs e)
        {
            PictureBox pct = (PictureBox)sender;
            if (pct.Tag == null) { pct.Tag = Color.Red; }
            ControlPaint.DrawBorder(e.Graphics, pct.ClientRectangle, (Color)pct.Tag, ButtonBorderStyle.Solid);
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            ChiTietAnhPhong ct = new ChiTietAnhPhong();
            ct.MaChiTietAnhPhong = QLBLLChiTietAnhPhong.Instance.TaoIdChiTietAnhPhong();
            ct.MaPhongTro = idPhong;
            ct.TonTai = true;
            ThemAnh ta = new ThemAnh(LoadForm, ct);
            ta.ShowDialog();
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            if (idChiTietAnh.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn Ảnh cần xóa", "Thông báo");
            }
            else
            {
                foreach (string id in idChiTietAnh )
            {
                QLBLLChiTietAnhPhong.Instance.DelChiTietAnhPhong(id);
                
            }
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadForm(null);
            }
           
                
            

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
