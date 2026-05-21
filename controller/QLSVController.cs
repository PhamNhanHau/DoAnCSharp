using DoAnCSharp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Linq;

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
            this.viewQLSV.fileToolStripMenuItem.Click += nhanNutSaveFile;
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
            }
            else if (this.modelQLSV.ChucNang == "ChinhSua")
            {
                if (this.viewQLSV.table.CurrentRow != null)
                {
                    int indexCanXoa = this.viewQLSV.table.CurrentRow.Index;
                    this.bindingListSV.RemoveAt(indexCanXoa);
                    this.ThucHienThemSinhVien();
                }
            }
            else if (this.modelQLSV.ChucNang == "Xoa")
            {
                if (this.viewQLSV.table.CurrentRow != null)
                {
                    int indexCanXoa = this.viewQLSV.table.CurrentRow.Index;
                    this.bindingListSV.RemoveAt(indexCanXoa);
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
        private void nhanNutSaveFile(object sender, EventArgs e)
        {

        }
    }

}
