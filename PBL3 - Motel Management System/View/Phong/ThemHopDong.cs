using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
namespace PBL3___Motel_Management_System
{
    public partial class ThemHopDong : Form
    {
        private ThuePhong tp;
        private Loader loader;
        public ThemHopDong(ThuePhong tp, Loader loader)
        {
            InitializeComponent();
            this.tp=tp;
            this.loader=loader;
            
            if(tp.hopDong.MaHopDong!=null)
            {
                SetGUI();
            }
            else
            {
                txtTienCoc.Text = tp.hopDong.TienCoc.ToString();
            }
        }
        public void SetGUI()
        {
            if (tp.hopDong.MaHopDong!=null && tp.hopDong.MaPhongTro==null)
            {
               
                HopDong hopdong = QLBLL.Instance.GetHopDongByMaHD(tp.hopDong.MaHopDong);
                dtpBatDau.Value = Convert.ToDateTime(hopdong.NgayBatDau);
                dtpKetThuc.Value = Convert.ToDateTime(hopdong.NgayKetThuc);
                txtTienCoc.Text =Convert.ToDouble(hopdong.TienCoc).ToString();
            }
        }
        private void Back(string txt)
        {
            this.loader(null);
            this.Close();
        }
        private void btnThemKhach_Click_1(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new ThemKhach(null,null, null), panelThemHD);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CheckHopLe()
        {
            var dateStart = dtpBatDau.Value;
            var dateEnd = dtpKetThuc.Value;
            var distance = dateEnd - dateStart;
            
            if(distance.Days < 30)
            {
                MessageBox.Show("Thời gian thuê phòng phải tối thiểu 30 ngày", "Thông báo");
                return false;
            }
            else
            {
                if(!double.TryParse(txtTienCoc.Text,out double i))
                {
                    MessageBox.Show("Vui lòng nhập số tại tiền cọc", "Thông báo");
                    return false;
                }
            }

            return true;
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if(tp.hopDong.MaHopDong!=null && tp.hopDong.MaPhongTro==null)
            {
                if (CheckHopLe())
                {
                    HopDong hopdong = QLBLL.Instance.GetHopDongByMaHD(tp.hopDong.MaHopDong);
                    hopdong.MaHopDong = tp.hopDong.MaHopDong;
                    string dateStart = dtpBatDau.Value.ToString("yyyy-MM-dd");
                    string dateEnd = dtpKetThuc.Value.ToString("yyyy-MM-dd");
                    hopdong.NgayBatDau = dateStart;
                    hopdong.NgayKetThuc = dateEnd;
                    hopdong.TienCoc = Convert.ToDouble(txtTienCoc.Text);
                    hopdong.TonTai = true;
                    QLBLL.Instance.UpdateHopDongBLL(hopdong);
                    MessageBox.Show("Gia hạn hợp đồng thành công");
                    loader(null);
                    this.Close();
                }
            }
            else
            {
                if (CheckHopLe())
                {
                    string dateStart = dtpBatDau.Value.ToString("yyyy-MM-dd");
                    string dateEnd = dtpKetThuc.Value.ToString("yyyy-MM-dd");
                    tp.hopDong.NgayBatDau = dateStart;
                    tp.hopDong.NgayKetThuc = dateEnd;
                    tp.hopDong.TienCoc = Convert.ToDouble(txtTienCoc.Text);
                    QLBLL.Instance.openChildForm1(new ChitietHopDong(tp, Back), panelThemHD);
                }
            }
        }
    }
}
