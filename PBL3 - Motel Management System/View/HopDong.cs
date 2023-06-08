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
using System.Windows.Controls;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    public partial class Hopdong : Form
    {
        private string id;
        public Hopdong()
        {
            InitializeComponent();
            LoadForm(null);
            SetCbb();


        }
        CultureInfo vietnamCulture = new CultureInfo("vi-VN");
        private void LoadForm(string txtTim)
        {
            dgvHD.Rows.Clear();
            QLBLLChung.Instance.customDGV(dgvHD);
            if(txtTim == null)
            {
            foreach (DgvHopDong hd in QLBLLHopDong.Instance.DgvHopDong())
            {
                dgvHD.Rows.Add(hd.MaHopDong, hd.Stt, hd.TenKhachHang, hd.TenPhongTro, hd.TenDayTro, hd.NgayBatDau, hd.NgayKetThuc, hd.TienCoc.ToString("#,##0") + "₫");

            }
            }
            else
            {
                string idDay = ((ViewCbb)(cbbDayTro.SelectedItem)).key;
                string idPhong = ((ViewCbb)(cbbPhongTro.SelectedItem)).key;
                foreach(DgvHopDong hd in QLBLLHopDong.Instance.GetAllHopDongTimKiem(idDay,idPhong))
                {
                    dgvHD.Rows.Add(hd.MaHopDong, hd.Stt, hd.TenKhachHang, hd.TenPhongTro, hd.TenDayTro, hd.NgayBatDau, hd.NgayKetThuc, hd.TienCoc.ToString("#,##0") + "₫");

                }
            }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-more-details-20.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-time-25.png");
            dgvHD.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLLChung.Instance.dgvIcons_CellPainting1(dgvHD, e, Sua, Xoa));
        }
        private void SetCbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            cbbDayTro.Items.AddRange(QLBLLChung.Instance.GetCbbDayTro().ToArray());
            cbbDayTro.SelectedIndex = 0;
        }
        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgvHD.Columns[e.ColumnIndex].Name;
                if (columnName == "btnSua")
                {
                    string id = dgvHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ThuePhong tp = new ThuePhong();
                    tp.hopDong.MaHopDong = id;
                    ChitietHopDong ct = new ChitietHopDong(tp, LoadForm);
                    ct.btnXacNhan.Visible = false;
                    QLBLLChung.Instance.openChildForm1(ct, panelHopDong);
                }
                else if (columnName == "btnXoa")
                {
                    string id = dgvHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                    ThuePhong tp = new ThuePhong();
                    tp.hopDong.MaHopDong = id;
                    QLBLLChung.Instance.openChildForm1(new ThemHopDong(tp,LoadForm), panelHopDong);
                }
            }

        }
        private void dgvHD_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvHD.Columns[e.ColumnIndex].Name == "btnSua")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Chi Tiết";
                    }
                }
            }
            if (dgvHD.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvHD.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Gia Hạn";
                    }
                }
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadForm("");
        }
    }
}
