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

namespace PBL3___Motel_Management_System.View.KhachHang
{
    public partial class ChitietDienPhong : Form
    {
        private string idPhong;
        public ChitietDienPhong(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            if(idPhong != null )
            {
                SetGUI(null);
            }
        }
        public void SetGUI(string txt)
        {
            dgvChiSoDien.Rows.Clear();
            QLBLL.Instance.customDGV(dgvChiSoDien);
            int i = 0;
                string IdDay = QLBLL.Instance.GetDayTroByIdPhong(idPhong).MaDayTro;
                string ThangSuDung = dtpThangSuDung.Value.ToString("MM-yyyy");

                foreach (ViewChiSo view in QLBLL.Instance.GetViewChiSoByTimKiem(ThangSuDung, IdDay, idPhong, "1"))
                {
                    if (QLBLL.Instance.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == "001" && view.TinhTrang==true)
                    {
                        dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        , view.NgayLap, view.ThangSuDung);
                    }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SetGUI("");
        }
    }
}
