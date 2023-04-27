using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.DTO
{
    internal class ViewDay
    {

        public string MaDayTro { get; set; }
        public int Stt { get; set; }
        public string TenDayTro { get; set; }
        public string TenDuong { get; set; } 
        public string TenHuyen { get; set; }
        public string TenThanhPho { get; set; }
        public int SoPhong { get; set; }
        public byte[] HinhAnh { get; set; }
    }
}
