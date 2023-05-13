using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3___Motel_Management_System.View;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using PBL3___Motel_Management_System.DAL;

namespace PBL3___Motel_Management_System.View
{
    public partial class Thietbi : Form
    {
        private int borderSize = 2;
        private Size formSize;
        public Thietbi()
        {
            InitializeComponent();
            LoadForm(null);
        }
        private void LoadForm(string txtTim)
        {
            dgvThietBi.RowCount = 0;
            this.dgvThietBi.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvThietBi.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvThietBi.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvThietBi.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvThietBi.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            this.dgvThietBi.RowTemplate.Height = 35;
            this.dgvThietBi.RowTemplate.MinimumHeight = 20;
            int i = 0;
            foreach (ThietBi viewThietBi in QLBLL.Instance.DgvThietBi(txtTim))
            {
                dgvThietBi.Rows.Add(viewThietBi.MaThietBi, ++i, viewThietBi.TenThietBi, viewThietBi.GiaThietBi);
            }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBL3\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL3\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvThietBi.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLL.Instance.dgvIcons_CellPainting1(dgvThietBi, e, Sua, Xoa));
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;

            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right

            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          

                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }
        //Private methods
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            string id = dgvThietBi.CurrentRow.Cells[0].Value.ToString();
            QLBLL.Instance.openChildForm1(new ThemThietBi(id, LoadForm), panelTB);
            
        }
        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new ThemThietBi(null,LoadForm), panelTB);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            LoadForm(txtTim.Text);
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            string idThietBi = dgvThietBi.CurrentRow.Cells[0].Value.ToString();
            QLBLL.Instance.DelChiTietThietBiByIdThietBi(idThietBi);
            QLBLL.Instance.DelThietBiBll(idThietBi);
            MessageBox.Show("Xóa thiết bị thành công", "Thông báo");
            LoadForm(null);
        }

        private void btnBaoHong_Click(object sender, EventArgs e)
        {

        }

        private void dgvThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvThietBi.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
                if (columnName == "btnSua")
                {
                    // Lấy mã dịch vụ tương ứng với hàng đã được nhấp
                    string id = dgvThietBi.Rows[e.RowIndex].Cells[0].Value.ToString();
                    QLBLL.Instance.openChildForm1(new ThemThietBi(id, LoadForm), panelTB);
                }
                else if (columnName == "btnXoa")
                {
                    string idThietBi = dgvThietBi.Rows[e.RowIndex].Cells[0].Value.ToString();
                    QLBLL.Instance.DelChiTietThietBiByIdThietBi(idThietBi);
                    QLBLL.Instance.DelThietBiBll(idThietBi);
                    MessageBox.Show("Xóa thiết bị thành công", "Thông báo");
                    LoadForm(null);
                }
            }
        }
    }
}
