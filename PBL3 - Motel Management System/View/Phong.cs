using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    
    public partial class Phong : Form
    {
        
       
        public Phong()
        {
            InitializeComponent();
            LoadForm(null);
            SetCbb();

        }
        public void LoadForm(string txt)
        {
            
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "MaPhongTro",DataType = typeof(string)},
                new DataColumn{ColumnName = "STT",DataType = typeof(int)},
                new DataColumn{ColumnName = "Tên phòng trọ",DataType = typeof(string)},
                new DataColumn{ColumnName = "Giá tiền",DataType = typeof(double)},
                new DataColumn{ColumnName = "Diện tích",DataType = typeof(double)},
                new DataColumn{ColumnName = "Tình trạng",DataType = typeof(string)},
                new DataColumn{ColumnName = "Số người hiện có",DataType = typeof(int)},
                new DataColumn{ColumnName = "Số người tối đa",DataType = typeof(string)},
                new DataColumn{ColumnName = "Tên dãy",DataType = typeof(string)},
                new DataColumn{ColumnName = "Hình ảnh",DataType = typeof(Image)},

            });
            QLBLL qLBLL = new QLBLL();
            
            if(txt == null)
            {
            foreach(ViewPhongTro pt in qLBLL.DgvPhongTro(null))
            {
                    string TinhTrang;
                    HopDong hd = qLBLL.GetHopDongByIdPhong(pt.MaPhongTro);
                    if (hd == null) TinhTrang = "Còn trống";
                    else if (hd.TinhTrang == true) TinhTrang  = "Đã cho thuê";
                    else TinhTrang = "Đã cọc";
                    Image image = null;
                    if (pt.HinhAnh != null)
                    {
                         image = ChuyenDoiAnh.Base64ToImage(pt.HinhAnh);
                    }
                dt.Rows.Add(pt.MaPhongTro,pt.Stt,pt.TenPhongTro,pt.GiaTien,pt.DienTich, TinhTrang, pt.SoNguoiHienCo,pt.SoNguoiToiDa,qLBLL.GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro, image);
            }
            }
            else
            {
                string idDay = ((ViewCbb)(cbbDayTro.SelectedItem)).IdDayTro;
                string idTinhTrang = ((ViewCbb)(cbbTinhTrang.SelectedItem)).IdDayTro;
                
                foreach (ViewPhongTro pt in qLBLL.DgvPhongTroTimKiem(idDay, idTinhTrang, txtTimKiem.Text))
                {
                    string TinhTrang;
                    HopDong hd = qLBLL.GetHopDongByIdPhong(pt.MaPhongTro);
                    if (hd == null) TinhTrang = "Còn trống";
                    else if (hd.TinhTrang == true) TinhTrang  = "Đã cho thuê";
                    else TinhTrang = "Đã cọc";
                    dt.Rows.Add(pt.MaPhongTro, pt.Stt, pt.TenPhongTro, pt.GiaTien, pt.DienTich, TinhTrang, pt.SoNguoiHienCo, pt.SoNguoiToiDa,pt.TenDay);
                }
            }
            
            dgvPhongTro.DataSource = dt;
            dgvPhongTro.Columns[0].Visible = false;
        }
        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbTinhTrang.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.Items.AddRange(new ViewCbb[]
            {
                new ViewCbb{IdDayTro = "-1",TenDayTro = "All"},
                new ViewCbb{IdDayTro = "1",TenDayTro = "Đã cho thuê"},
                new ViewCbb{IdDayTro = "0",TenDayTro = "Còn trống"},
                new ViewCbb{IdDayTro = "2",TenDayTro = "Đã cọc"},
            }) ;
            cbbTinhTrang.SelectedIndex = 0;
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            //ThemPhong themPhong = new ThemPhong("123");
            //themPhong.ShowDialog();
        }
         
       
        TrangChu tc = new TrangChu();

        private void btnThemday_Click_1(object sender, EventArgs e)
        {
            if(dgvPhongTro.CurrentRow.Cells[5].Value.ToString()=="Còn trống")
            {
            ThuePhong tp = new ThuePhong();
            QLBLL qLBLL = new QLBLL() ;
            tp.hopDong.MaHopDong = qLBLL.TaoIdHopDong();
            tp.hopDong.MaPhongTro = dgvPhongTro.CurrentRow.Cells[0].Value.ToString();
            tc.openChildForm1(new ThemKhach(tp, LoadForm), panelPhong) ;
            }
            else if(dgvPhongTro.CurrentRow.Cells[5].Value.ToString()=="Đã cọc")
            {
                ThuePhong tp = new ThuePhong();
                QLBLL qLBLL= new QLBLL() ;
                tp.hopDong = qLBLL.GetHopDongByIdPhong(dgvPhongTro.CurrentRow.Cells[0].Value.ToString());
                tc.openChildForm1(new ThemKhach(tp, LoadForm), panelPhong);
            }
            else
            {
                MessageBox.Show("Phòng hiện tại đã cho thuê","Thông báo");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ChitietPhong(dgvPhongTro.CurrentRow.Cells[0].Value.ToString(), LoadForm), panelPhong);

        }

     
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadForm("");
            
        }

        private void panelPhong_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCoc_Click(object sender, EventArgs e)
        {
            if (dgvPhongTro.CurrentRow.Cells[5].Value.ToString()=="Còn trống")
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = dgvPhongTro.CurrentRow.Cells[0].Value.ToString();
                tc.openChildForm1(new CocPhong(tp,LoadForm), panelPhong);
            }
            else
            {
                MessageBox.Show("Phòng hiện tại không thể cọc", "Thông báo");
            }
        }

        private void dgvPhongTro_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPhongTro.CurrentRow.Cells[0].Value != null)
            {

                string id = dgvPhongTro.CurrentRow.Cells[0].Value.ToString();
                QLBLL qLBLL = new QLBLL();
                PhongTro pt = qLBLL.GetPhongTroByIdPhong(id);
                if (pt.HinhAnh!=null)
                {
                    Image image = ChuyenDoiAnh.Base64ToImage(pt.HinhAnh);
                    Anh anh = new Anh(image);
                    anh.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu ảnh");
                }
            }
        }
    }
    }

