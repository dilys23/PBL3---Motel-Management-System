using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.DTO
{
    public class ThuePhong
    {
        public List<string> DsDichVu { get; set; }
        public List<string> DsThietBi { get; set; }
        public HopDong hopDong { get; set; }
        public ThuePhong() { 
            DsDichVu = new List<string>();
            DsThietBi = new List<string>(); 
            hopDong = new HopDong();
            hopDong.Nguoi = new Nguoi();
            hopDong.PhongTro = new PhongTro
            {
                DayTro = new DayTro()
            };


        }
    }
}
