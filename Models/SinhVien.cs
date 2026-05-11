using System;
using System.Text.RegularExpressions;
namespace DoAnCSharp.Models
{
    class SinhVien
    {
        private int maSinhVien;
        public int MaSinhVien 
        {
            get
            {
                return maSinhVien;
            }
            set
            {
                if (value > 0)
                {
                    maSinhVien = value;
                }
            }
        }

        private string tenSinhVien;
        public string TenSinhVien
        {
            get
            {
                return tenSinhVien;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    tenSinhVien = value;
                }
            }
        }

        private Tinh queQuan;
        public Tinh QueQuan
        {
            get
            {
                return queQuan;
            }
            set
            {
                if (value != null)
                {
                    queQuan = value;
                }
            }
        }
        private bool gioiTinh;
        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }
            set
            {
                if (value != null)
                {
                    gioiTinh = value;
                }
            }
        }
        private float diemMon1;
        public float DiemMon1
        {
            get
            {
                return diemMon1;
            }
            set
            {
                if (value > 0)
                {
                    diemMon1 = value;
                }
            }
        }
        private float diemMon2;
        public float DiemMon2
        {
            get
            {
                return diemMon2;
            }
            set
            {
                if (value > 0)
                {
                    diemMon2 = value;
                }
            }
        }
        private float diemMon3;
        public float DiemMon3
        {
            get
            {
                return diemMon3;
            }
            set
            {
                if (value > 0)
                {
                    diemMon3 = value;
                }
            }
        }
        private float diemMon4;
        public float DiemMon4
        {
            get
            {
                return diemMon4;
            }
            set
            {
                if (value > 0)
                {
                    diemMon4 = value;
                }
            }
        }
        //Constructor rỗng và constructor chuẩn
        public SinhVien()
        {
        }
        public SinhVien(int maSinhVien, string tenSinhVien, )
        //toString
        public override string ToString()
        {
            return $"Tỉnh: {tenTinh}, Mã tỉnh: {maTinh} ";
        }
        //Hashcode và Equals
        public override int GetHashCode()
        {
            return HashCode.Combine(maTinh, tenTinh);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            if (this == obj)
                return true;
            Tinh other = (Tinh)obj;
            return this.maTinh == other.MaTinh && this.tenTinh == other.TenTinh;
        }
    }
}
