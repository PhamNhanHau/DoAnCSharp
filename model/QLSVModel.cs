using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
namespace DoAnCSharp.Models
{
    internal class QLSVModel
    {
        private List<SinhVien> dsSinhVien;
        private string chucNang;
        
        public string ChucNang
        {
            get { return chucNang; } 
            set { chucNang = value; }
        }
        private bool sql;
        public bool SQL
        {
            get { return sql; }
            set { sql = value; }
        }
        public List<SinhVien> DsSinhVien { get; set; } = new List<SinhVien>();
        //Constructor
        public QLSVModel(List<SinhVien> dsSinhVien)
        {
            this.dsSinhVien = dsSinhVien;
            this.chucNang = "";
            this.sql = false;
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
        public SinhVien getSinhVienTuMaSinhVien(int maSinhVien)
        {
            foreach (SinhVien sv in this.dsSinhVien)
            {
                if (sv.MaSinhVien == maSinhVien)
                {
                    return sv;
                }
            }
            return null;
        }
        public void kiemTraTrungMaSinhVien(int maSinhVien)
        {
            foreach (SinhVien sv in this.dsSinhVien)
            {
                if(maSinhVien == sv.MaSinhVien)
                {
                    throw new Exception("Mã sinh viên đã tồn tại");
                    break;
                }
            }
        }
    }
}
