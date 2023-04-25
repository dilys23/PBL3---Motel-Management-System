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
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.BLL;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietDay : Form
    {
        
        private string IdDay;
      
        public ChitietDay(string IdDay)
        {
            InitializeComponent();
            this.IdDay = IdDay;
            QLBLL qLBLL = new QLBLL();
            LoadForm(IdDay);
        }
        TrangChu tc = new TrangChu();
        private void LoadForm(string IdDay)
        {
            IdDay = this.IdDay;
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn{ColumnName = "Mã phòng",DataType = typeof(string)},
                new DataColumn{ColumnName = "STT",DataType = typeof(int)},
                new DataColumn{ColumnName = "Tên phòng",DataType = typeof(string)},
                new DataColumn{ColumnName = "Giá tiền",DataType = typeof(double)},
                new DataColumn{ColumnName = "Diện tích",DataType = typeof(double)},
                new DataColumn{ColumnName = "Tình trạng",DataType = typeof(bool)},
                new DataColumn{ColumnName = "Số người hiện có",DataType = typeof(int)},
                new DataColumn{ColumnName = "Số người tối đa",DataType = typeof(int)} ,
                new DataColumn{ColumnName = "Hình ảnh",DataType = typeof(Image)} 
            });
            QLBLL qLBLL = new QLBLL();
           
            
                foreach (ViewPhongTro vp in qLBLL.GetAllPhongTroByIdDay(IdDay))
                {
                Image image = null;
                if(vp.HinhAnh != null)
                {
                    image = ChuyenDoiAnh.Base64ToImage(vp.HinhAnh);
                }
                    dt.Rows.Add(vp.MaPhongTro, vp.Stt, vp.TenPhongTro, vp.GiaTien, vp.DienTich, vp.TinhTrang, vp.SoNguoiHienCo, vp.SoNguoiToiDa, image);
                }
         
            textBox1.Text = qLBLL.GetDayByIdDay(IdDay).TenDayTro.ToString();
            textBox2.Text = qLBLL.GetDayByIdDay(IdDay).TenDuong.ToString() + ',' + qLBLL.GetDayByIdDay(IdDay).TenHuyen.ToString() + ',' + qLBLL.GetDayByIdDay(IdDay).TenThanhPho.ToString();
            dgvPhong.DataSource = dt;
                dgvPhong.Columns[0].Visible = false;
            
          
        }
        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            tc.openChildForm1(new ThemPhong(IdDay,LoadForm), panelChitietDay);
         
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {



            if (dgvPhong.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng");
            }
            else
            {
              
                string IdPhong = dgvPhong.CurrentRow.Cells[0].Value.ToString();
            tc.openChildForm1(new SuaPhong(IdPhong,LoadForm), panelChitietDay);
            LoadForm(IdDay);
            }
            
        }

        private void ChitietDay_Load(object sender, EventArgs e)
        {
            LoadForm(IdDay);
        }

        private void dgvPhong_DoubleClick(object sender, EventArgs e)
        {
            string id = dgvPhong.CurrentRow.Cells[0].Value.ToString();
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
