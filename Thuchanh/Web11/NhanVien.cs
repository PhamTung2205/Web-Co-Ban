using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web11
{
    
    public class NhanVien
    {
        public string hoten { get; set; }
        public int namsinh { get; set; }
        public string gioitinh { get; set; }
        
        public NhanVien(string Hoten,int Namsinh,string GioiTinh)
        {
            this.hoten = Hoten;
            this.namsinh = Namsinh;
            this.gioitinh = GioiTinh;
        }
    }
}