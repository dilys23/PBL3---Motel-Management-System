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
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace PBL3___Motel_Management_System.View.Phong
{
    public partial class AnhPhong : Form
    {
        private string idPhong;
        private string idChiTietAnh;
        public AnhPhong(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            
        }
        public void LoadForm()
        {
            pctdemo.Visible = false;
            foreach (ChiTietAnhPhong ct in QLBLLChiTietAnhPhong.Instance.GetChiTietAnhPhongByIdPhong(idPhong))
            {
                PictureBox pct = new PictureBox();
                pct.Name = ct.MaChiTietAnhPhong;
                pct.Image = QLBLLChung.Instance.Base64ToImage(ct.Anh);
                pct.SizeMode = PictureBoxSizeMode.StretchImage;
                pct.Size = new Size(300,400);
                pct.MouseClick += event1;
                pct.Paint += paint;
                panelAnh.Controls.Add(pct);


            }

        }
        private void event1(object sender, MouseEventArgs e)
        {
            PictureBox pct = sender as PictureBox;
            if ((Color)pct.Tag == Color.Red) { pct.Tag = Color.Blue; }
            else { pct.Tag = Color.Red; }
            pct.Refresh();
            if (idChiTietAnh != null )
            {
                idChiTietAnh = pct.Name;
            }
        }
        private void paint (object sender, PaintEventArgs e)
        {
            PictureBox pct = (PictureBox)sender;
            if (pct.Tag == null) { pct.Tag = Color.Red; }
            ControlPaint.DrawBorder(e.Graphics, pct.ClientRectangle, (Color)pct.Tag, ButtonBorderStyle.Solid);
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            PictureBox pctKhach = new PictureBox();
            pctKhach.Name = QLBLLChiTietAnhPhong.Instance.TaoIdChiTietAnhPhong();
            ChiTietAnhPhong ct = new ChiTietAnhPhong();
            ct.MaChiTietAnhPhong = pctKhach.Name;
            ct.MaPhongTro = this.idPhong;
            ct.TonTai = true;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " ipg files(*.jpg)|*.jpg|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
               string  imgLocation = dialog.FileName.ToString();
               pctKhach.ImageLocation = imgLocation;
                pctdemo.ImageLocation = imgLocation;
            }
           
            panelAnh.Controls.Add(pctKhach);
            pctKhach.MouseClick += event1;
            pctKhach.Paint += paint;
           // ct.Anh = QLBLLChung.Instance.ImageToBase64(pctdemo.Image, pctdemo.Image.RawFormat);
            //QLBLLChiTietAnhPhong.Instance.AddChiTietAnhPhong(ct);
        }

        private void btnXoaAnh_Click(object sender, EventArgs e)
        {
            ChiTietAnhPhong ct = new ChiTietAnhPhong();
            ct.Anh = QLBLLChung.Instance.ImageToBase64(pctdemo.Image, pctdemo.Image.RawFormat);
        }

    }
}
