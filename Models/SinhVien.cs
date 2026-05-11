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
                if (gioiTinh != value)
                {
                    gioiTinh = value;
                }
            }
        }
        private DateTime ngaySinh;
        public DateTime getNgaySinh()
        {
            return ngaySinh;
        }
        public void setNgaySinh(DateTime inputDate)
        {
            
            if (inputDate >= DateTime.MinValue)
            {
                this.ngaySinh = inputDate;
            }
            else
            {
                Console.WriteLine("Ngày không hợp lệ hoặc đang để trống.");
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
        public SinhVien(int maSinhVien, string tenSinhVien,Tinh queQuan, DateTime ngaySinh,bool gioiTinh, float diemMon1, float diemMon2, float diemMon3 ,float diemMon4)
        {
            this.maSinhVien = maSinhVien;
            this.tenSinhVien =tenSinhVien;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diemMon1 = diemMon1;
            this.diemMon2 = diemMon2;
            this.diemMon3 = diemMon3;
            this.DiemMon4 = diemMon4;
        } 
        //toString
        public override string ToString()
        {
            return $"MSSV: {maSinhVien}, Họ và tên: {tenSinhVien}\nQuên quán: {queQuan}\nNgày sinh: {ngaySinh}]\tGiới tính: {gioiTinh}\n Điểm môn 1: {diemMon1}\n Điểm môn 2: {diemMon2}\n Điểm môn 3: {diemMon3}\n Điểm môn 3: {diemMon3}";
        }
        //Hashcode và Equals
        public override int GetHashCode()
        {
            return HashCode.Combine(maSinhVien, tenSinhVien);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            if (this == obj)
                return true;
            SinhVien other = (SinhVien)obj;
            return this.maSinhVien == other.maSinhVien;
        }
    }
}
