using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    
    public partial class Dichvu : Form
    {
        private int borderSize = 2;
        private Size formSize;
        CultureInfo vietnamCulture = new CultureInfo("vi-VN");
        public Dichvu()
        {
            InitializeComponent();
            LoadForm(null);
   
        }
        private void LoadForm(string txtTim)
        {
            dgvDichVu.Rows.Clear();
            QLBLL.Instance.customDGV(dgvDichVu);
            int i = 0;
            foreach(DichVu viewDichVu in QLBLL.Instance.DgvDichVu(txtTim))
            {
                dgvDichVu.Rows.Add(viewDichVu.MaDichVu,++i,viewDichVu.TenDichVu,viewDichVu.GiaDichVu.ToString("#,##0") + "₫");
            }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvDichVu.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLL.Instance.dgvIcons_CellPainting1(dgvDichVu, e, Sua, Xoa));
        
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

        private void Service_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            AdjustForm();
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

       

        private void iconButton5_Click(object sender, EventArgs e)
        {
            SuaDichVu suaDichVu = new SuaDichVu(null,LoadForm); ;
            suaDichVu.ShowDialog();
        }

      
        private void btnThemPhong_Click_1(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new SuaDichVu(null, LoadForm), panelDV);
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            string id = dgvDichVu.CurrentRow.Cells[0].Value.ToString();
            QLBLL.Instance.openChildForm1(new SuaDichVu(id,LoadForm), panelDV);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadForm(txtTim.Text);
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            string id = dgvDichVu.CurrentRow.Cells[0].Value.ToString();
            if(id != "000" && id != "001")
            {
                QLBLL.Instance.DelChiTietDichVuByIdDichVu(id);
                QLBLL.Instance.DelDichVu(id);
                MessageBox.Show("Xóa dịch vụ thành công", "Thông báo");
                LoadForm(null);
            }
            else
            {
                MessageBox.Show("Đây là dịch vụ cố định!! Không thể xóa");
            }
        }

        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDichVu.Columns[e.ColumnIndex].Name == "btnSua")
            {
                string id = dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
                QLBLL.Instance.openChildForm1(new SuaDichVu(id, LoadForm), panelDV);
            }
            else
            {
                string id = dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (id != "000" && id != "001")
                {
                    QLBLL.Instance.DelChiTietDichVuByIdDichVu(id);
                    QLBLL.Instance.DelDichVu(id);
                    dgvDichVu.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Xóa dịch vụ thành công", "Thông báo");
                    LoadForm(null);
                }
                else
                {
                    MessageBox.Show("Đây là dịch vụ cố định!! Không thể xóa");
                }
            }
        }

        private void dgvDichVu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvDichVu.Columns[e.ColumnIndex].Name == "btnSua")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Chỉnh sửa";
                    }
                }
            }
            if (dgvDichVu.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Xóa";
                    }
                }
            }
        }
    }
}
