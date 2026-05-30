using DoAnCSharp.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace DoAnCSharp
{
    internal class QLSVController 
    {
        private QLSVView viewQLSV;
        private QLSVModel modelQLSV;
        private BindingList<SinhVien> bindingListSV;
        private BindingList<SinhVien> bindingListTimKiem;
        public QLSVController(QLSVView view)
        {
            this.viewQLSV = view;
            this.modelQLSV = new QLSVModel();
            // Controller Khoi chay du lieu
            LoadInitialData();
            this.viewQLSV.buttonThem.Click += nhanNutThem;
            this.viewQLSV.buttonLuu.Click += nhanNutLuu;
            this.viewQLSV.buttonChinhSua.Click += nhanNutChinhSua;
            this.viewQLSV.buttonXoa.Click += nhanNutXoa;
            this.viewQLSV.buttonHuyBo.Click += nhanNutHuyBo;
            this.viewQLSV.buttonHuyTim.Click += nhanNutHuyTim;
            this.viewQLSV.buttonTim.Click += nhanNutTimKiem;
            this.viewQLSV.fileMenu.Click += nhanNutSaveFile;
            this.viewQLSV.openSQLMenu.Click += nhanNutOpenSQLMenu;
            this.viewQLSV.loadSQLMenu.Click += nhanNutLoadSQLMenu;
            this.viewQLSV.closeSQLMenu.Click += nhanNutCloseSQLMenu;
        }
        private void LoadInitialData()
        {
            //Khoi tao du lieu cho comboBox
            List<Tinh> dsTinh = Tinh.getDSTinh();
            viewQLSV.capNhatDuLieuTinhVaoCBBQueQuan(dsTinh);
            viewQLSV.capNhatDulieuVaoDataGridView();
            bindingListSV = new BindingList<SinhVien>(this.modelQLSV.DsSinhVien);
            this.viewQLSV.table.DataSource = bindingListSV;
        }   
        //Chuc nang them
        private void nhanNutThem(object sender, EventArgs e)
        {
            this.viewQLSV.xoaFormThongTin();
            this.viewQLSV.batButtonThem();
            this.modelQLSV.ChucNang = "Them";
        }
        //Chuc nang chinh sua
        private void nhanNutChinhSua(object sender, EventArgs e)
        { 
            this.viewQLSV.batButtonChinhSua();
            this.modelQLSV.ChucNang = "ChinhSua";
        }
        //Chuc nang xoa
        private void nhanNutXoa(object sender, EventArgs e)
        {
            this.viewQLSV.batButtonXoa();
            this.modelQLSV.ChucNang = "Xoa";
        }
        private void nhanNutHuyBo(object sender, EventArgs e)
        {
            this.viewQLSV.batButtonHuyBo();
            this.modelQLSV.ChucNang = "";
        }
        //Chuc nang luu
        private void nhanNutLuu(object sender, EventArgs e)
        {
            if (this.modelQLSV.ChucNang == "Them")
            {
                this.ThucHienThemSinhVien();
                Log.Information($"USER - Thêm sinh viên có mã sinh viên {this.viewQLSV.textBoxMaSinhVienThem.Text.Trim()}");
            }
            else if (this.modelQLSV.ChucNang == "ChinhSua")
            {
                if (this.viewQLSV.table.CurrentRow != null)
                {
                    int indexCanXoa = this.viewQLSV.table.CurrentRow.Index;
                    this.bindingListSV.RemoveAt(indexCanXoa);
                    this.ThucHienThemSinhVien();
                    Log.Information($"USER - Chỉnh sửa sinh viên có mã sinh viên {this.viewQLSV.textBoxMaSinhVienThem.Text.Trim()}");
                }
            }
            else if (this.modelQLSV.ChucNang == "Xoa")
            {
                if (this.viewQLSV.table.CurrentRow != null)
                {
                    SinhVien svCanXoa = (SinhVien)this.viewQLSV.table.CurrentRow.DataBoundItem;
                    int indexCanXoa = this.viewQLSV.table.CurrentRow.Index;
                    this.bindingListSV.RemoveAt(indexCanXoa);
                    if (this.modelQLSV.TrangThaiSQL)
                    {
                        tuongTacSQL(svCanXoa);
                    }
                    Log.Information($"- Xóa sinh viên có mã sinh viên {this.viewQLSV.textBoxMaSinhVienThem.Text.Trim()}");
                }
            }
            this.viewQLSV.batButtonLuu();
        }
        private void ThucHienThemSinhVien()
        {
            try
            {
                int maSinhVien = int.Parse(viewQLSV.textBoxMaSinhVienThem.Text.Trim());
                this.modelQLSV.kiemTraTrungMaSinhVien(maSinhVien);

                string hoVaTen = viewQLSV.textBoxHoVaTen.Text.Trim();

                string tinh = viewQLSV.comboBoxQueQuanThem.Text.Trim();
                Tinh queQuan = Tinh.getTinhByTen(tinh);

                string chuoiGioiTinh = viewQLSV.radioButtonNam.Checked ? "Nam" : "Nữ";
                bool gioiTinh = chuoiGioiTinh.Equals("Nam");
                this.viewQLSV.kiemTraCheckedGioiTinh();

                string chuoiNgaySinh = $"{viewQLSV.textBoxNgay.Text.Trim()}/{viewQLSV.textBoxThang.Text.Trim()}/{viewQLSV.textBoxNam.Text.Trim()}";
                DateTime ngaySinh = new DateTime(2000, 1, 1);

                int ngay = int.Parse(viewQLSV.textBoxNgay.Text.Trim());
                int thang = int.Parse(viewQLSV.textBoxThang.Text.Trim());
                int nam = int.Parse(viewQLSV.textBoxNam.Text.Trim());
                ngaySinh = new DateTime(nam, thang, ngay);

                float diemtThuongXuyen1 = float.Parse(viewQLSV.textBoxDiemThuongXuyen1.Text.Trim());
                float diemtThuongXuyen2 = float.Parse(viewQLSV.textBoxDiemThuongXuyen2.Text.Trim());
                float diemtThuongXuyen3 = float.Parse(viewQLSV.textBoxDiemThuongXuyen3.Text.Trim());
                float diemGiuaKi = float.Parse(viewQLSV.textBoxDiemGiuaKi.Text);
                float diemCuoiKi = float.Parse(viewQLSV.textBoxDiemCuoiKi.Text);

                SinhVien sv = new SinhVien(maSinhVien, hoVaTen, queQuan, ngaySinh, gioiTinh, diemtThuongXuyen1, diemtThuongXuyen2, diemtThuongXuyen3, diemGiuaKi, diemCuoiKi);
                this.modelQLSV.themSinhVien(sv);
                if (this.bindingListSV != null)
                {
                    this.bindingListSV.Add(sv);
                }
                if (this.modelQLSV.TrangThaiSQL)
                {
                    this.tuongTacSQL(sv);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        //Chuc nang huy tim
        private void nhanNutHuyTim(object sender, EventArgs e)
        {
            this.viewQLSV.xoaFormTimKiem();
            this.viewQLSV.batButtonHuyTim();
            this.viewQLSV.table.DataSource = bindingListSV;
        }
        //Chuc nang tim
        private void nhanNutTimKiem(object sender, EventArgs e)
        {
            this.viewQLSV.batButtonTimKiem();
            this.bindingListTimKiem = new BindingList<SinhVien>();
            //lay du lieu tu 2 o tim kiem
            string queQuanCanTim = viewQLSV.comboBoxQueQuan.Text.Trim();
            string maSVText = viewQLSV.textBoxMaSinhVien.Text.Trim();

            //Ep ve dang IEnumerable de dung LINQ
            var ketQuaLoc = this.modelQLSV.DsSinhVien.AsEnumerable();

            //Neu nguoi dung chi chon que quan
            ketQuaLoc = ketQuaLoc.Where(sv => sv.QueQuan != null && sv.QueQuan.TenTinh.Equals(queQuanCanTim, StringComparison.OrdinalIgnoreCase));

            //Neu co nhap ma sinh vien
            if (!string.IsNullOrEmpty(maSVText))
            {
                if (int.TryParse(maSVText, out int maSVCanTim))
                {
                    ketQuaLoc = ketQuaLoc.Where(sv => sv.MaSinhVien == maSVCanTim);
                }
                else
                {
                    MessageBox.Show("Mã sinh viên tìm kiếm phải là số!", "Thông báo");
                    return;
                }
            }

            //Cho du lieu tim kiem vao mot lis moi
            List<SinhVien> danhSachSauKhiLoc = ketQuaLoc.ToList();

            //Cap nhat vao datagridview
            this.bindingListTimKiem.Clear();
            foreach (var sv in danhSachSauKhiLoc)
            {
                this.bindingListTimKiem.Add(sv);
            }
            //khong co sinh vien nao dung ket qua
            this.viewQLSV.table.DataSource = bindingListTimKiem;
        }
        //
        //Cac chuc nang cua File
        //
        private void nhanNutSaveFile(object sender, EventArgs e)
        {
            
        }
        //
        //Cac chuc nang cua SQL
        //
        private void nhanNutOpenSQLMenu(object sender, EventArgs e)
        {
            string xamppFolder = @"D:\Tool\Xampp\Source";

            try
            {
                //Khoi chay apache
                string apacheScript = Path.Combine(xamppFolder, "apache_start.bat");
                if (File.Exists(apacheScript))
                {
                    ProcessStartInfo apacheInfo = new ProcessStartInfo(apacheScript)
                    {
                        WorkingDirectory = xamppFolder,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };
                    Process.Start(apacheInfo);
                }

                //khoi Chay Mysql
                string mysqlScript = Path.Combine(xamppFolder, "mysql_start.bat");
                if (File.Exists(mysqlScript))
                {
                    ProcessStartInfo mysqlInfo = new ProcessStartInfo(mysqlScript)
                    {
                        WorkingDirectory = xamppFolder,
                        CreateNoWindow = true,
                        UseShellExecute = false
                    };
                    Process.Start(mysqlInfo);
                }

                //Doi apache va mysql bat len
                System.Threading.Thread.Sleep(3000);

               
                MessageBox.Show("Đã kích hoạt Apache và MySQL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.modelQLSV.TrangThaiSQL = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống khi mở SQL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void nhanNutLoadSQLMenu(object sender, EventArgs e)
        {
            List<SinhVien> dsMoi = sinhVienDao.getInstance().selectAll();
            this.modelQLSV.DsSinhVien = dsMoi;
            this.bindingListSV.Clear();
            foreach (SinhVien sv in dsMoi)
            {
                this.bindingListSV.Add(sv);
            }
        }
        private void nhanNutCloseSQLMenu(object sender, EventArgs e)
        {
            closeSQL();
            this.modelQLSV.TrangThaiSQL = false;
        }
        public void closeSQL()
        {
            try
            {
                //Tat SQL
                foreach (var process in Process.GetProcessesByName("mysqld"))
                {
                    process.Kill();
                }

                //Tat Apache
                foreach (var process in Process.GetProcessesByName("httpd"))
                {
                    process.Kill();
                }

                MessageBox.Show("Đã tắt apache và SQL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.modelQLSV.TrangThaiSQL = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tắt apache và SQL " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tuongTacSQL(SinhVien sv)
        {
            if (this.modelQLSV.ChucNang == "Them")
            {
                sinhVienDao.getInstance().insert(sv);
                Log.Information($"USER - Thêm sinh viên có mã sinh viên {this.viewQLSV.textBoxMaSinhVienThem.Text.Trim()} vào DB");
            }
            else if (this.modelQLSV.ChucNang == "ChinhSua")
            {
                sinhVienDao.getInstance().insert(sv);
                Log.Information($"USER - Chỉnh sửa sinh viên có mã sinh viên {this.viewQLSV.textBoxMaSinhVienThem.Text.Trim()} vào DB");
            }
            else if (this.modelQLSV.ChucNang == "Xoa")
            {
                sinhVienDao.getInstance().delete(sv);
                Log.Information($"USER - Xóa sinh viên có mã sinh viên {this.viewQLSV.textBoxMaSinhVienThem.Text.Trim()} vào DB");
            }
        }
    }

}
