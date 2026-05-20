using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
namespace DoAnCSharp.Models
{
    internal class QLSVModel
    {
        private List<SinhVien> dsSinhVien;
        public List<SinhVien> DsSinhVien { get; set; } = new List<SinhVien>();
        //Constructor
        public QLSVModel(List<SinhVien> dsSinhVien)
        {
            this.dsSinhVien = dsSinhVien;
        }
        public QLSVModel()
        {
            this.dsSinhVien = new List<SinhVien>();
        }
        //Ham chuc nang
        public void themSinhVien(SinhVien sv) 
        { 
            this.dsSinhVien.Add(sv);
        }
    }
    
}
