using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View.KhachHang
{
    public partial class panelKhach : Form
    {
        private string matk;
        public panelKhach(string matk)
        {
            InitializeComponent();
           // RoundPanel(pictureBox1, 10);
            RoundPanel(panel2, 10);
            this.matk = matk;
            if(this.matk != null )
            {
                SetGUI(null);
            }
        }

        private void RoundPanel(Panel panel, int cornerRadius)
        {
            RectangleF rect = new RectangleF(0, 0, panel.Width, panel.Height);
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.X, rect.Y + rect.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            panel.Region = new Region(path);
        }
        public void SetGUI(string key)
        {
            QLBLL.Instance.customDGV(dgvThanhVien);
            PhongTro pt = QLBLL.Instance.GetPhongTroByMaTaiKhoan(this.matk);
            label4.Text = pt.TenPhongTro;
            DayTro daytro = QLBLL.Instance.GetDayTroByIdPhong(pt.MaPhongTro);
            label5.Text = daytro.TenDayTro;
            string diachi = daytro.TenDuong + "," + daytro.TenHuyen + "," + daytro.TenThanhPho;
            label6.Text = diachi;
            //if (pt.HinhAnh != null)
            //{
            //    pictureBox1.Image = ChuyenDoiAnh.Base64ToImage(pt.HinhAnh);
            //}
            if (QLBLL.Instance.GetHopDongByIdPhong(pt.MaPhongTro) != null)
            {
                dgvThanhVien.Rows.Clear();
                dgvThanhVien.Columns[8].ValueType = typeof(Image);
                dgvThanhVien.RowCount = 0;
                int i = 1;
                foreach (string idNguoi in QLBLL.Instance.GetIdNguoiByIdPhong(pt.MaPhongTro))
                {
                    Nguoi nguoi = new Nguoi();
                    if (key == null)
                    { 
                        nguoi = QLBLL.Instance.GetNguoiByIdNguoi(idNguoi);
                        Image image = null;
                        if (nguoi.HinhAnh != null)
                        {
                            image = ChuyenDoiAnh.Base64ToImage(nguoi.HinhAnh);
                        }
                        dgvThanhVien.Rows.Add(nguoi.MaNguoi, i++, nguoi.Ten, nguoi.Cccd, nguoi.Sdt, nguoi.Diachi, nguoi.NgaySinh, (nguoi.GioiTinh) ? "Nam" : "Nữ", image);
                    }
                    else
                    {
                        nguoi = QLBLL.Instance.GetNguoiByIdNguoi(idNguoi);
                        Image image = null;
                        if(nguoi.Ten.StartsWith(key) || nguoi.Ten.ToLower().StartsWith(key.ToLower()))
                        {
                            if (nguoi.HinhAnh != null)
                            {
                                image = ChuyenDoiAnh.Base64ToImage(nguoi.HinhAnh);
                            }
                            dgvThanhVien.Rows.Add(nguoi.MaNguoi, i++, nguoi.Ten, nguoi.Cccd, nguoi.Sdt, nguoi.Diachi, nguoi.NgaySinh, (nguoi.GioiTinh) ? "Nam" : "Nữ", image);
                        }
                        
                    }
                  
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetGUI(textBox1.Text);      
        }

        private void dgvThanhVien_DoubleClick(object sender, EventArgs e)
        {
               if (dgvThanhVien.CurrentRow.Cells[0].Value != null)
            {
                ThuePhong tp = new ThuePhong();
                string id = dgvThanhVien.CurrentRow.Cells[0].Value.ToString();
                tp.hopDong.MaNguoi = id;
                ThemKhach tk = new ThemKhach(tp, SetGUI);
                QLBLL.Instance.openChildForm1(tk, panel3);
                tk.btnLuu.Visible= false;
                tk.btnThemAnh.Visible= false;
                tk.txtCccd.Enabled = false;
                tk.txtDiaChi.Enabled = false;
                tk.dtpNgaySinh.Enabled = false;
                tk.txtSdt.Enabled = false;
                tk.txtTen.Enabled = false;
                tk.rdbtnNam.Enabled = false;
                tk.rdbtnNu.Enabled = false;
            }
        }
    }
}
