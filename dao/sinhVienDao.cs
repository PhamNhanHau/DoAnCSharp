using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoAnCSharp.Models
{
    public class sinhVienDao : DAOInterface<SinhVien>
    {
        public static sinhVienDao getInstance()
        {
            return new sinhVienDao();
        }
        public int delete(SinhVien t)
        {
            throw new NotImplementedException();
        }

        public int insert(SinhVien t)
        {
            int ketQua = 0;
            string sql = "INSERT INTO sinhvien (maSinhVien, tenSinhVien, queQuan, ngaySinh, gioiTinh, diemThuongXuyen1, diemThuongXuyen2, diemThuongXuyen3, diemGiuaKi, diemCuoiKi) VALUES (@ma, @ten, @que, @ngay, @gioi, @diem1, @diem2, @diem3, @diemGiua, @diemCuoi)";

            using (MySqlConnection con = MSCUtil.getConnection())
            {
                if (con == null) return 0;

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    //Dung Parameter de tranh SQL Injection (loi noi chuoi 1 == 1)
                    cmd.Parameters.AddWithValue("@ma", t.MaSinhVien);
                    cmd.Parameters.AddWithValue("@ten", t.TenSinhVien);
                    cmd.Parameters.AddWithValue("@que", t.QueQuan.TenTinh);
                    cmd.Parameters.AddWithValue("@ngay", t.NgaySinh.Date);
                    cmd.Parameters.AddWithValue("@gioi", t.GioiTinhText);
                    cmd.Parameters.AddWithValue("@diem1", t.DiemThuongXuyen1);
                    cmd.Parameters.AddWithValue("@diem2", t.DiemThuongXuyen2);
                    cmd.Parameters.AddWithValue("@diem3", t.DiemThuongXuyen3);
                    cmd.Parameters.AddWithValue("@diemGiua", t.DiemGiuaKi);
                    cmd.Parameters.AddWithValue("@diemCuoi", t.DiemCuoiKi);
                    // Thuc thi tra ve so dong bi anh huong 
                    ketQua = cmd.ExecuteNonQuery();
                }
            }
            return ketQua;
        }

        public List<SinhVien> selectAll(SinhVien t)
        {
            throw new NotImplementedException();
        }

        public List<SinhVien> selectByCondition(string condition)
        {
            throw new NotImplementedException();
        }

        public SinhVien selectByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int update(SinhVien t)
        {
            int ketQua = 0;
            string sql = "UPDATE sinhvien SET " +
             "tenSinhVien = @ten, " +
             "queQuan = @que, " +
             "ngaySinh = @ngay, " +
             "gioiTinh = @gioi, " +
             "diemThuongXuyen1 = @diem1, " +
             "diemThuongXuyen2 = @diem2, " +
             "diemThuongXuyen3 = @diem3, " +
             "diemGiuaKi = @diemGiua, " +
             "diemCuoiKi = @diemCuoi " +
             "WHERE maSinhVien = @ma"; 

            using (MySqlConnection con = MSCUtil.getConnection())
            {
                if (con == null) return 0;

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    //Dung Parameter de tranh SQL Injection (loi noi chuoi 1 == 1)
                    cmd.Parameters.AddWithValue("@ma", t.MaSinhVien);
                    cmd.Parameters.AddWithValue("@ten", t.TenSinhVien);
                    cmd.Parameters.AddWithValue("@que", t.QueQuan.TenTinh);
                    cmd.Parameters.AddWithValue("@ngay", t.NgaySinh.Date);
                    cmd.Parameters.AddWithValue("@gioi", t.GioiTinhText);
                    cmd.Parameters.AddWithValue("@diem1", t.DiemThuongXuyen1);
                    cmd.Parameters.AddWithValue("@diem2", t.DiemThuongXuyen2);
                    cmd.Parameters.AddWithValue("@diem3", t.DiemThuongXuyen3);
                    cmd.Parameters.AddWithValue("@diemGiua", t.DiemGiuaKi);
                    cmd.Parameters.AddWithValue("@diemCuoi", t.DiemCuoiKi);
                    // Thuc thi tra ve so dong bi anh huong 
                    ketQua = cmd.ExecuteNonQuery();
                }
            }
            return ketQua;
        }
    }
}
