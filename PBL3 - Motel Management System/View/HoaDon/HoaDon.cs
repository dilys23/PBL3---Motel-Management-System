using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
namespace PBL3___Motel_Management_System
{
    public partial class Hoadon : Form
    {
        public Hoadon()
        {
            InitializeComponent();
            SetCbb();
            LoadForm(null);
        }
        private void LoadForm(string txt)
        {
            dgvHoaDon.Rows.Clear();
            QLBLLChung.Instance.customDGV(dgvHoaDon);
            if(txt == null)
            {
                int i= 0;
                foreach(HoaDon hd in QLBLLHoadon.Instance.GetAllHoaDonBll())
                {
                    PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(hd.MaPhongTro);
                    DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(hd.MaPhongTro);
                    string TinhTrang = (hd.TinhTrang) ? "Xác thực" : "Chưa xác thực";
                    double conNo = hd.TongTien - hd.DaThanhToan;
                    string conNo1= (conNo >= 0) ? conNo.ToString("#,##0") + "₫" : "0₫";
                    dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro, hd.NgayTao, hd.ThangChiTra, hd.TongTien.ToString("#,##0") + "₫", TinhTrang, hd.DaThanhToan.ToString("#,##0") + "₫", conNo1);
                }
            
            }
            else
            {
                string ThangSuDung = dtpThangSuDung.Value.ToString("MM-yyyy");
                string IdDay = ((ViewCbb)cbbDayTro.SelectedItem).key;
                string IdPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                string IdTinhTrang = ((ViewCbb)cbbTinhTrang.SelectedItem).key;
                int i = 0;
                foreach(HoaDon hd in QLBLLHoadon.Instance.GetHoaDonTimKiem(ThangSuDung,IdDay,IdPhong,IdTinhTrang))
                {
                    PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(hd.MaPhongTro);
                    DayTro dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(hd.MaPhongTro);
                    string TinhTrang = (hd.TinhTrang) ? "Xác thực" : "Chưa xác thực";
                    double conNo = hd.TongTien - hd.DaThanhToan;
                    string conNo1 = (conNo >= 0) ? conNo.ToString("#,##0") + "₫" : "0₫";
                    dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro, hd.NgayTao, hd.ThangChiTra, hd.TongTien.ToString("#,##0") + "₫", TinhTrang, hd.DaThanhToan.ToString("#,##0") + "₫", conNo1);

                    // dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, dt.TenDayTro, pt.TenPhongTro, hd.NgayTao, hd.ThangChiTra, hd.TongTien.ToString("#,##0") + "₫", TinhTrang, hd.DaThanhToan.ToString("#,##0") + "₫", (hd.TongTien - hd.DaThanhToan).ToString("#,##0") + "₫");
                }
            }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            var ChiTiet = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-history-20.png");
            dgvHoaDon.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLLChung.Instance.dgvIcons_CellPainting2(dgvHoaDon, e, Sua, Xoa, ChiTiet));
        }
        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            cbbDayTro.Items.AddRange(QLBLLChung.Instance.GetCbbDayTro().ToArray());
            cbbTinhTrang.Items.AddRange(QLBLLChung.Instance.GetCbbTinhTrang().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            QLBLLChung.Instance.openChildForm1(new XuatHoaDon(), panelHD);
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            QLBLLChung.Instance.openChildForm1(new ThemHoaDon(LoadForm,null), panelHD);
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() == "Xác thực")
            {
                MessageBox.Show("Hóa đơn hiện tại đã được xác thực nên không thể sửa!!Vui lòng bỏ xác thực trước khi sửa hóa đơn", "Thông báo");
            }    
            else
            {
                string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                QLBLLChung.Instance.openChildForm1(new ThemHoaDon(LoadForm, id), panelHD);
            }
        }
        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPhongTro.Items.Clear();
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            cbbPhongTro.Items.AddRange(QLBLLPhongTro.Instance.GetViewCbbPhongByDay(id).ToArray());
            if (cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadForm("");
        }

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() != "Xác thực")
            {
                string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                if (QLBLLHoadon.Instance.ChoPhepXacThucHoaDon(id))
                {
                    HoaDon hd = QLBLLHoadon.Instance.GetHoaDonById(id);
                    hd.TinhTrang = true;
                    QLBLLHoadon.Instance.UpdateHoaDonBLL(hd);
                    MessageBox.Show("Xác thực thành công", "Thông báo");
                    LoadForm(null);
                }
                else
                {
                    MessageBox.Show("Phòng này ở thời điểm bạn chọn đã có một chi tiết được xác thực", "Thông báo");
                }
            }
            else {
                MessageBox.Show("Hóa đơn hiện tại đã được xác thực", "Thông báo");
            
            }
        }
        private void btnBoXacThuc_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() != "Chưa xác thực")
            {
                if(Convert.ToDouble(dgvHoaDon.CurrentRow.Cells[8].Value.ToString())!= 0)
                {
                    MessageBox.Show("Hóa đơn hiện tại đã được thanh toán!/nKhông thể bỏ xác thực!", "Thông báo");
                }
                else
                {
                    HoaDon hd = QLBLLHoadon.Instance.GetHoaDonById(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                    hd.TinhTrang = false;
                    QLBLLHoadon.Instance.UpdateHoaDonBLL(hd);
                    MessageBox.Show("Bỏ xác thực thành công");
                    LoadForm(null);
                }
            }    
            else
            {
                MessageBox.Show("Hóa đơn hiện tại đã ở tình trạng chưa xác thực", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() == "Chưa xác thực")
            {
                QLBLLHoadon.Instance.DelHoaDonBll(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("Xóa hóa đơn thành công","Thông báo");
                LoadForm(null);
            }
            else
            {
                MessageBox.Show("Hóa đơn đã được xác thực!! Không thể xóa", "Thông báo");
            }

        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {           
              if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() == "Chưa xác thực")
                {
                    MessageBox.Show("Hóa đơn hiện tại chưa được xác thực nên không thể thanh toán!!Vui lòng bỏ xác thực trước khi Thanh toán", "Thông báo");
                }
              else
                  {
                CultureInfo vietnamCulture = new CultureInfo("vi-VN");
                double tongTien = (Convert.ToDouble(dgvHoaDon.CurrentRow.Cells[6].Value.ToString().Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", "")));
                double daThanhToan = (Convert.ToDouble(dgvHoaDon.CurrentRow.Cells[8].Value.ToString().Replace(vietnamCulture.NumberFormat.CurrencySymbol, "").Replace(".", "")));
                if (daThanhToan >= tongTien)
                {
                    MessageBox.Show("Đã thanh toán đủ tiền cho hóa đơn này", "Thông báo");
                }
                else
                {
                    string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                    QLBLLChung.Instance.openChildForm1(new ThanhToan(id, LoadForm), panelHD);
                }
            }
        }
        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvHoaDon.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
                if (columnName == "btnSua")
                {
                    if (dgvHoaDon.Rows[e.RowIndex].Cells[7].Value.ToString() == "Xác thực")
                    {
                        MessageBox.Show("Hóa đơn hiện tại đã được xác thực nên không thể sửa!!Vui lòng bỏ xác thực trước khi sửa hóa đơn", "Thông báo");
                    }
                    else
                    {
                        string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                        QLBLLChung.Instance.openChildForm1(new ThemHoaDon(LoadForm, id), panelHD);

                    }

                }
                else if (columnName == "btnXoa")
                {
                    if (dgvHoaDon.CurrentRow.Cells[7].Value.ToString() == "Chưa xác thực")
                    {
                        QLBLLHoadon.Instance.DelHoaDonBll(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show("Xóa hóa đơn thành công", "Thông báo");
                        LoadForm(null);
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn đã được xác thực!! Không thể xóa", "Thông báo");
                    }
                }
                else if (columnName == "btnChiTiet")
                {
                    
                    string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                    QLBLLChung.Instance.openChildForm1(new LichSuThanhToan(LoadForm, id), panelHD);
                }
            }
        }
    }
}
