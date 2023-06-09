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

namespace PBL3___Motel_Management_System.View.Phong
{
    public partial class ThemAnh : Form
    {
        private Loader loader;
        private ChiTietAnhPhong ct;
        public ThemAnh(Loader loader, ChiTietAnhPhong ct)
        {
            InitializeComponent();
            this.loader = loader;
            this.ct = ct;
            
        }
        
        private void btnLuuAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " ipg files(*.jpg)|*.jpg|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
               string imgLocation = dialog.FileName.ToString();
                pctAnh.ImageLocation = imgLocation;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ct.Anh = QLBLLChung.Instance.ImageToBase64(pctAnh.Image, pctAnh.Image.RawFormat);
            QLBLLChiTietAnhPhong.Instance.AddChiTietAnhPhong(ct);
            MessageBox.Show("Thêm ảnh Thành Công", "Thông báo");
            loader(null);
            this.Close();
        }
    }
}
