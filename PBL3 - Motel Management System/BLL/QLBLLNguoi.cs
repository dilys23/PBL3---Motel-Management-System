using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLNguoi
    {
        private static QLBLLNguoi _instance;
        public static QLBLLNguoi Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLNguoi();
                return _instance;
            }
            private set { }
        }
        private QLBLLNguoi()
        {

        }
        public string TaoIdNguoi()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (Nguoi ng in QLDAL.Instance.GetAllNguoiTaoID())
                {
                    if (ng.MaNguoi == id) status = true;
                }
            }
            return id;
        }
        public string GetIdNguoiByTaiKhoan(string idTaiKhoan)
        {
            return QLDAL.Instance.GetIdNguoiByTaiKhoanDal(idTaiKhoan);
        }
        public void UpdateNguoiBLL(Nguoi nguoi)
        {
            QLDAL.Instance.UpdateNguoiDAL(nguoi);
        }
        public void AddNguoiBll(Nguoi n)
        {
            QLDAL.Instance.AddNguoiDal(n);
        }
        public List<string> GetIdNguoiByIdPhong(string id)
        {
            return QLDAL.Instance.GetIdNguoiByIdPhongDal(id);
        }
        public List<Nguoi> GetNguoiByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetNguoiByIdPhongDal(idPhong);
        }
        public Nguoi GetNguoiByIdNguoi(string IdNguoi)
        {
            return QLDAL.Instance.GetNguoiByIdNguoiDal(IdNguoi);
        }
        public void DelNguoiBll(string id)
        {
            QLDAL.Instance.DelNguoiDal(id);
        }
        public Nguoi GetNguoiByMaHopDong(string MaHd)
        {
            return QLDAL.Instance.GetNguoiByIdHopDong(MaHd);
        }
        public Label GetLabelByNguoi(Nguoi nguoi)
        {
            Label lbl = new Label();
            lbl.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            lbl.AutoSize = true;
            lbl.Name = nguoi.MaNguoi;
            lbl.Text = "   " + nguoi.Ten;
            lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Image image1 = Image.FromFile("D:\\PBL\\PBL3_MAIN\\PBL3 - Motel Management System\\Icons\\icons8-customer-20.png" + "    ");
            lbl.Image = image1;
            lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lbl.TabIndex = 0;
            lbl.Size = new System.Drawing.Size(50, 80);
            lbl.Visible = true;
            return lbl;
        }
        public Nguoi GetNguoiByMaTaiKhoan(string matk)
        {
            return QLDAL.Instance.GetNguoiByMaTaiKhoan(matk);
        }
    }
}
