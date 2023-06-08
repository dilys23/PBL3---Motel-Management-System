using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChung
    {
        private static QLBLLChung _instance;
        public static QLBLLChung Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChung();
                return _instance;
            }
            private set { }
        }
        private QLBLLChung()
        {

        }
        public void customDGV(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgv.DefaultCellStyle.ForeColor = Color.Blue;
            dgv.DefaultCellStyle.BackColor = Color.Beige;
            dgv.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.RowTemplate.Height = 35;
            dgv.RowTemplate.MinimumHeight = 20;
        }
        public List<ViewCbb> GetCbbDayTro()
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            foreach (DayTro dt in QLDAL.Instance.GetAllDayTro())
            {
                list.Add(new ViewCbb { key = dt.MaDayTro, value = dt.TenDayTro });//ok
            }
            return list;
        }
        public List<ViewCbb> GetCbbTinhTrang()
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            list.Add(new ViewCbb { key = "1", value = "Đã xác thực" });
            list.Add(new ViewCbb { key = "2", value = "Chưa xác thực" });
            return list;
        }
        public List<ViewCbb> GetCbbTinhTrangPhong()
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            list.Add(new ViewCbb { key = "1", value = "Đã cho thuê" });
            list.Add(new ViewCbb { key = "0", value = "Còn trống" });
            list.Add(new ViewCbb { key = "2", value = "Đã cọc" });
            return list;
        }
        public List<object> ThongKe(string thang)
        {
            return QLDAL.Instance.ThongKe(thang);
        }
        public List<object> ThongKeTongTienTheoThang(string nam)
        {
            var thongKeData = QLDAL.Instance.ThongKeTongTienTheoThang(nam);
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            var chartData = thongKeData.Select(x => new { Key = months[int.Parse(x.Key.Substring(0, 2)) - 1], Value = x.Value }).ToList<object>();

            return chartData;
        }
        public void openChildForm1(Form childForm, System.Windows.Forms.Panel p)
        {
            // DemoForm.Instance.SetActiveForm(childForm);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            p.Controls.Add(childForm);
            p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void dgvIcons_CellPainting1(DataGridView dgv, DataGridViewCellPaintingEventArgs e, Image btSua, Image btXoa)
        {
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnSua" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnSua = btSua;
                var w = btnSua.Width;
                var h = btnSua.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnSua, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnXoa" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnXoa = btXoa;
                var w = btnXoa.Width;
                var h = btnXoa.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnXoa, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
        }
        public void dgvIcons_CellPainting2(DataGridView dgv, DataGridViewCellPaintingEventArgs e, Image btSua, Image btXoa, Image btChiTiet)
        {
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnSua" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnSua = btSua;
                var w = btnSua.Width;
                var h = btnSua.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnSua, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnXoa" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnXoa = btXoa;
                var w = btnXoa.Width;
                var h = btnXoa.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnXoa, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnChiTiet" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnChiTiet = btChiTiet;
                var w = btnChiTiet.Width;
                var h = btnChiTiet.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnChiTiet, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
        }
        public void TaoPanel(string a, Panel p)
        {
            Panel pn = new Panel();
            pn.Size = new Size(p.Width, p.Height);
            pn.BackColor = Color.FromArgb(226, 247, 249);
            pn.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
            Label lb = new Label();
            lb.Text = a;
            lb.AutoSize = true;
            lb.Font = new Font("arial", 12, FontStyle.Regular);
            lb.ForeColor = Color.Red;
            lb.TextAlign = ContentAlignment.TopLeft;
            lb.Location = new Point((pn.Width - lb.Width) / 3, (pn.Height - lb.Height) / 2);
            pn.Controls.Add(lb);
            p.Controls.Add(pn);

        }
        public void dgvIcons_CellPainting3(DataGridView dgv, DataGridViewCellPaintingEventArgs e, Image btXoa)
        {

            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnXoa" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnXoa = btXoa;
                var w = btnXoa.Width;
                var h = btnXoa.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnXoa, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
        }
    }
}
