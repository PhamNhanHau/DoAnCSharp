using System;
namespace DoAnCSharp
{
    public class SinhVien
    {
        public string HoTen { get; set; }
        public void ThongTin()
        {
            Console.WriteLine("Day la sinh vien: " + HoTen);
        }
    }
}
