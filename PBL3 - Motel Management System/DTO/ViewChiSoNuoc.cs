using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.DTO
{
    internal class ViewChiSoNuoc
    {
        public string MaChiTietSuDungDichVu { get; set; }
        public int Stt { get; set; }
        public string DayTro { get; set; }
        public string PhongTro { get; set; }
        public double ChiSoCu { get; set; }
        public double ChiSoMoi { get; set; }
        public double DaDung { get; set; }
        public string NgayLap { get; set; }
        public string ThangSuDung { get; set; }
        public bool TinhTrang { get; set; }
    }
}
