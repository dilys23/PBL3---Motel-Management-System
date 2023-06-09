using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLTaiKhoan
    {
        private static QLBLLTaiKhoan _instance;
        public static QLBLLTaiKhoan Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLTaiKhoan();
                return _instance;
            }
            private set { }
        }
        private QLBLLTaiKhoan()
        {

        }
        public DAL.TaiKhoan GetIdTk(string taikhoan, string matkhau)
        {
            return QLDAL.Instance.GetIdTkDal(taikhoan, matkhau);
        }
        public List<DAL.TaiKhoan> GetAllTaiKhoan()
        {
            return QLDAL.Instance.GetAllTaiKhoan();
        }
        public string TaoIdTaiKhoan()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (DAL.TaiKhoan vt in QLDAL.Instance.GetAllTaiKhoan())
                {
                    if (vt.MaTaiKhoan == id) status = true;
                }
            }
            return id;
        }
        public DAL.TaiKhoan TaoTaiKhoanChoPhong(string idp)
        {
            PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(idp);
            DAL.TaiKhoan tk = new DAL.TaiKhoan()
            {
                MaTaiKhoan = TaoIdTaiKhoan(),
                TenTaiKhoan = "pt" + pt.MaPhongTro,
                MatKhau = MaHoaMatKhau(("pt" + pt.MaPhongTro)),
                TonTai = true
            };
            return tk;
        }
        public void AddTaiKhoan(DAL.TaiKhoan tk)
        {
            QLDAL.Instance.AddTaiKhoanDal(tk);
        }
        public DAL.TaiKhoan GetTaiKhoanByIdPhong(string idp)
        {
            return QLDAL.Instance.GetTaiKhoanByIdPhong(idp);
        }
        public DAL.TaiKhoan GetTaiKhoanByIdChuTro(string idChutro)
        {
            return QLDAL.Instance.GetTaiKhoanByIdChuTro(idChutro);
        }
        public void UpdateTaiKhoanPhong(DAL.TaiKhoan tk)
        {
            QLDAL.Instance.UpdateTaiKhoanPhong(tk);
        }
        public void UpdateTaiKhoanChutro(DAL.TaiKhoan tk)
        {
            QLDAL.Instance.UpdateTaiKhoanChutro(tk);
        }
        public DAL.TaiKhoan GetTaiKhoanByIdTaiKhoan(string matk)
        {
            return QLDAL.Instance.GetTaiKhoanByIdTaiKhoan(matk);
        }
        public string MaHoaMatKhau(string matKhau)
        {
            try
            {
                byte[] encData_byte = new byte[matKhau.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(matKhau);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Encode" + e.Message);
            }
        }
        public string GiaiMaMatKhau(string MatKhauMaHoa)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8Decode = encoder.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(MatKhauMaHoa);
            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            string result = new String(decoded_char);
            return result;
        }
    }
}
