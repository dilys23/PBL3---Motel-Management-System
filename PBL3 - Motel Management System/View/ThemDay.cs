using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    
    public partial class ThemDay : Form
    {
        private string IdDay;
        private _SuKien suKien;
        private Loader loader;
        public ThemDay(string idDay, Loader loader, _SuKien suKien)
        {
            InitializeComponent();
            this.suKien = suKien;
            this.IdDay = idDay;
            this.loader = loader;
            if(IdDay!=null )
            {
                SetGUI();
            }
        }
        public void SetGUI()
        {
            QLBLL qLBLL = new QLBLL();
            DayTro day = qLBLL.GetDayByIdDay(IdDay);
            txtTenDay.Text = day.TenDayTro.ToString();
            txtTenHuyen.Text = day.TenHuyen.ToString();
            txtTenDuong.Text = day.TenDuong.ToString();
            txtTenThanhPho.Text = day.TenThanhPho.ToString();
            if (day.HinhAnh != null)
            {
                pictureDayTro.Image = ChuyenDoiAnh.Base64ToImage(day.HinhAnh);
            }
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {
            //paneDesktop.Controls.Add(this);
        }
        TrangChu tc = new TrangChu();
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Boolean kiemTraThemDay()
        {
            int i = 0;
            errorProvider1.SetError(txtTenHuyen, "");
            errorProvider1.SetError(txtTenDay, "");
            errorProvider1.SetError(txtTenDuong, "");
            errorProvider1.SetError(txtTenThanhPho, "");
            if(txtTenDay.Text == "")
            {
                errorProvider1.SetError(txtTenDay, "Vui lòng nhập tên dãy");
                i++;
                
            }
            if (txtTenHuyen.Text == "")
            {
                errorProvider1.SetError(txtTenHuyen, "Vui lòng nhập tên huyện");
                i++;

            }
            if (txtTenDuong.Text == "")
            {
                errorProvider1.SetError(txtTenDuong, "Vui lòng nhập tên đường");
                i++;

            }
            if (txtTenThanhPho.Text == "")
            {
                errorProvider1.SetError(txtTenThanhPho, "Vui lòng nhập tên thành phố");
                i++;

            }
            if (i==0) return true;
            else return false;

        }
        private void btnThemDay_Click(object sender, EventArgs e)
        {
            if(kiemTraThemDay())
            {
                QLBLL qLBLL = new QLBLL();
                
                if (IdDay!=null)
                {
                    DayTro day = qLBLL.GetDayByIdDay(IdDay);
                    day.MaDayTro = IdDay;
                    day.TenDayTro = txtTenDay.Text;
                    day.TenDuong = txtTenDuong.Text;
                    day.TenHuyen = txtTenHuyen.Text;
                    day.TenThanhPho = txtTenThanhPho.Text;
                    if (pictureDayTro.Image != null)
                    {
                        day.HinhAnh = ChuyenDoiAnh.ImageToBase64(pictureDayTro.Image, pictureDayTro.Image.RawFormat);
                    }
                    day.TonTai = true;
                    qLBLL.SuaDayBll(day);
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                    Button btn = new Button();
                    btn.Name = IdDay;
                    suKien(btn, EventArgs.Empty);
                    loader(null);
                    this.Close();
                }
                else
                {
                    DayTro dt = new DayTro();
                    dt.MaDayTro = qLBLL.TaoIdDayTro();
                    dt.TenDayTro = txtTenDay.Text;
                    dt.TenDuong = txtTenDuong.Text;
                    dt.TenHuyen = txtTenHuyen.Text;
                    dt.TenThanhPho = txtTenThanhPho.Text;
                    dt.MaChuTro = "1";
                    if (pictureDayTro.Image != null)
                    {
                        dt.HinhAnh = ChuyenDoiAnh.ImageToBase64(pictureDayTro.Image, pictureDayTro.Image.RawFormat);
                    }
                    dt.TonTai = true;
                    qLBLL.AddDayTroBll(dt);
                    MessageBox.Show("Bạn đã thêm dãy thành công", "Thông báo");
                    Button btn = new Button();
                    btn.Name = dt.MaDayTro;
                    suKien(btn, EventArgs.Empty);
                    loader(null);
                    this.Close();
                }
               
               
                

            }
        }
        string imgLocation = "";
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " ipg files(*.jpg)|*.jpg|jpg files(*.png)|*.png|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureDayTro.ImageLocation = imgLocation;
            }

        }

        private void pctKhach_Click(object sender, EventArgs e)
        {

        }
    }
}
