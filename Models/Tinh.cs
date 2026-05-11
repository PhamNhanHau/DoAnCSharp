using System;
namespace DoAnCSharp.Models
{
    public class Tinh
    {
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
        public Tinh()
        {
        }
        public Tinh(int maTinh, string tenTinh)
        {
            this.maTinh = maTinh;
            this.tenTinh = tenTinh;
        }
        

    }

}
