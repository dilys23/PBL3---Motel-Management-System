using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class TrangChuKhach : Form
    {
#pragma warning disable CS0169 // The field 'TrangChuKhach.tp' is never used
        private ThuePhong tp;
#pragma warning restore CS0169 // The field 'TrangChuKhach.tp' is never used
#pragma warning disable CS0169 // The field 'TrangChuKhach.loader' is never used
        private Loader loader;
#pragma warning restore CS0169 // The field 'TrangChuKhach.loader' is never used
        private int borderSize = 2;
        private Size formSize;
        private string matk;
        private string idPhong;
        public TrangChuKhach(string matk)
        {
            InitializeComponent();
            this.Padding = new Padding(borderSize);//Border size
            this.BackColor = Color.FromArgb(217, 247, 249);
            this.matk= matk;
            
        }
        
       
        
        private void TrangChuKhach_Load(object sender, EventArgs e)
        {
            formSize = this.ClientSize;
            QLBLL.Instance.openChildForm1(new panelKhach(matk), panelDesktop);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        
        //Overridden methods
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

        private void CollapseMenu()
        {
            if (this.paneMenu.Width > 200) //Collapse menu
            {
                paneMenu.Width = 100;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in paneMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            { //Expand menu
                paneMenu.Width = 230;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in paneMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "  " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        //Event methods
        private void TrangChuKhach_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        

        
        


        
#pragma warning disable CS0414 // The field 'TrangChuKhach.activeForm' is assigned but its value is never used
        private Form activeForm = null;
#pragma warning restore CS0414 // The field 'TrangChuKhach.activeForm' is assigned but its value is never used

        private void btnMaximized_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                //formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                //this.Size = formSize;
            }

        }
       
        private void btnMinimized_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {

            CollapseMenu();
        }

        private void panelTitle_MouseDown_1(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       // TrangChu tc = new TrangChu();
        private void btnHopDong_Click(object sender, EventArgs e)
        {
            idPhong = QLBLL.Instance.GetPhongTroByMaTaiKhoan(matk).MaPhongTro;
            ThuePhong tp = new ThuePhong();
            if (QLBLL.Instance.GetHopDongByIdPhong(idPhong)!=null)
            {
                HopDong hopDong = QLBLL.Instance.GetHopDongByIdPhong(idPhong);
                tp.hopDong.MaHopDong = hopDong.MaHopDong;
                ChitietHopDong ct = new ChitietHopDong(tp, null);
                ct.btnXacNhan.Visible = false;
                QLBLL.Instance.openChildForm1(ct, panelDesktop);
            }
            else
            {
                tp.hopDong.MaPhongTro = idPhong;
                ChitietHopDong ct = new ChitietHopDong(tp, null);
                ct.btnXacNhan.Visible = false;
                QLBLL.Instance.openChildForm1(ct, panelDesktop);
            }
            
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            idPhong = QLBLL.Instance.GetPhongTroByMaTaiKhoan(matk).MaPhongTro;
            ThemPhong tp = new ThemPhong(null,idPhong,null,null);
            tp.btnLuu.Visible = false;tp.txtDienTich.Enabled = false;
            tp.btnThemAnh.Visible = false;tp.txtGiaTien.Enabled = false;
            tp.iconButton1.Visible = false;tp.txtTenPhong.Enabled = false;
            tp.label9.Visible= false;tp.txtToiDa.Enabled= false;
            QLBLL.Instance.openChildForm1(tp,panelDesktop);
        }

        private void btnDien_Click(object sender, EventArgs e)
        {
            idPhong = QLBLL.Instance.GetPhongTroByMaTaiKhoan(matk).MaPhongTro;

            ChitietDienPhong ct = new ChitietDienPhong(idPhong);
            QLBLL.Instance.openChildForm1(ct, panelDesktop);
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            idPhong = QLBLL.Instance.GetPhongTroByMaTaiKhoan(matk).MaPhongTro;
            ChitietNuocPhong ct = new ChitietNuocPhong(idPhong);
            QLBLL.Instance.openChildForm1(ct, panelDesktop);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            idPhong = QLBLL.Instance.GetPhongTroByMaTaiKhoan(matk).MaPhongTro;
            HoaDonPhong ct = new HoaDonPhong(idPhong);
            QLBLL.Instance.openChildForm1(ct, panelDesktop);
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            panelKhach ct = new panelKhach(matk);
            QLBLL.Instance.openChildForm1(ct, panelDesktop);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Dangnhap dn =new Dangnhap();
            dn.ShowDialog();
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            idPhong = QLBLL.Instance.GetPhongTroByMaTaiKhoan(matk).MaPhongTro;
            //QLBLL.Instance.openChildForm1(new TaiKhoanPhong(idPhong), panelDesktop);
            QLBLL.Instance.openChildForm1(new DoiMK(idPhong,null,LoadForm), panelDesktop);
        }
        public void LoadForm(string t)
        {
            QLBLL.Instance.openChildForm1(new panelKhach(matk), panelDesktop);
        }
        private void btnThietbi_Click(object sender, EventArgs e)
        {
            idPhong = QLBLL.Instance.GetPhongTroByMaTaiKhoan(matk).MaPhongTro;
            ChitietTB ct = new ChitietTB(idPhong);
            ct.btnThemThietbi.Visible = false;
            QLBLL.Instance.openChildForm1(ct, panelDesktop);
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            idPhong = QLBLL.Instance.GetPhongTroByMaTaiKhoan(matk).MaPhongTro;
            ChitietDV ct = new ChitietDV(idPhong);
            ct.btnThemDichVu.Visible = false;
            ct.dgvDichVu.Columns[4].Visible = false;
            QLBLL.Instance.openChildForm1(ct, panelDesktop);
        }
    }
}
