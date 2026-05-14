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
        public List<SinhVien> DsSinhVien
        {
            get
            {
                return dsSinhVien;
            }
            set
            {
                if (value != null)
                {
                    dsSinhVien = value;
                }
            }
        }
        //Constructor
        public QLSVModel(List<SinhVien> dsSinhVien)
        {
            this.dsSinhVien = dsSinhVien;
        }
        public QLSVModel()
        {
        }
        //Ham chuc nang


    }
    
}
