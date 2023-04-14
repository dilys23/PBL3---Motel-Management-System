using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.DTO
{
    internal class ViewPhongTro
    {
        public string MaPhongTro { get; set; }
        public int Stt { get; set; }
        public string TenPhongTro { get; set; }
        public double GiaTien { get; set; }
        public double DienTich { get; set; }
        public bool TinhTrang { get; set; }
        public int SoNguoiHienCo { get; set; }
        public int SoNguoiToiDa { get; set; }
    }
}
