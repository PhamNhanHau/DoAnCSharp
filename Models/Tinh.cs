using System;
using System.Xml.Linq;
namespace DoAnCSharp.Models
{
    public class Tinh
    {
        // Biến của hàm, set và get
        private int maTinh;
        public int MaTinh  
        {
            get
            {
                return maTinh;
            }
            set
            {
                if (value > 0)
                {
                    maTinh = value;
                }
            }
        }
        private string tenTinh;
        public string TenTinh
        {
            get
            {
                return tenTinh;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    tenTinh = value;
                }
            }
        }
        //Constructor rỗng và constructor chuẩn
        public Tinh()
        {
        }
        public Tinh(int maTinh, string tenTinh)
        {
            this.maTinh = maTinh;
            this.tenTinh = tenTinh;
        }
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
