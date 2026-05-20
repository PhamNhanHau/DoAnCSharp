using System;
using System.Text.RegularExpressions;
namespace DoAnCSharp.Models
{
    public class SinhVien
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

        private float diemThuongXuyen1;
        public float DiemThuongXuyen1
        {
            get
            {
                return diemThuongXuyen1;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    diemThuongXuyen1 = value;
                }
            }
        }
        private float diemThuongXuyen2;
        public float DiemThuongXuyen2
        {
            get
            {
                return diemThuongXuyen2;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    diemThuongXuyen2 = value;
                }
            }
        }
        private float diemThuongXuyen3;
        public float DiemThuongXuyen3
        {
            get
            {
                return diemThuongXuyen3;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    diemThuongXuyen3 = value;
                }
            }
        }
        private float diemGiuaKi;
        public float DiemGiuaKi
        {
            get
            {
                return diemGiuaKi;
            }
            set
            {
                if (value >= 0 && value <=10)
                {
                    diemGiuaKi = value;
                }
            }
        }
        private float diemCuoiKi;
        public float DiemCuoiKi
        {
            get
            {
                return diemCuoiKi;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    diemCuoiKi = value;
                }
            }
        }
        //Constructor rỗng và constructor chuẩn
        public SinhVien()
        {
        }
        public SinhVien(int maSinhVien, string tenSinhVien,Tinh queQuan, DateTime ngaySinh,bool gioiTinh, float diemThuongXuyen1, float diemThuongXuyen2, float diemThuongXuyen3, float diemGiuaKi, float diemCuoiKi)
        {
            this.maSinhVien = maSinhVien;
            this.tenSinhVien =tenSinhVien;
            this.queQuan = queQuan;
            this.ngaySinh = ngaySinh;
            this.gioiTinh = gioiTinh;
            this.diemThuongXuyen1 = diemThuongXuyen1;
            this.diemThuongXuyen2 = diemThuongXuyen2;
            this.diemThuongXuyen3 = diemThuongXuyen3;
            this.diemGiuaKi = diemGiuaKi;
            this.diemCuoiKi = diemCuoiKi;
        } 
        //toString
        public override string ToString()
        {
            return $"MSSV: {maSinhVien}, Họ và tên: {tenSinhVien}, Quên quán: {queQuan}";
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
        //Ham lay gioi tinh text
        public string gioiTinhText
        {
            get { return gioiTinh ? "Nam" : "Nữ"; }
        }
    }
}
