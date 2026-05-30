using DoAnCSharp.Models;
using System.Runtime.CompilerServices;

namespace DoAnCSharp
{
    partial class QLSVView
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelQueQuan = new Label();
            labelTimKiemSinhVien = new Label();
            comboBoxQueQuan = new ComboBox();
            labelMaSinhVien = new Label();
            textBoxMaSinhVien = new TextBox();
            buttonTim = new Button();
            buttonHuyTim = new Button();
            menuStrip = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            openFileMenu = new ToolStripMenuItem();
            saveFileMenu = new ToolStripMenuItem();
            closeFileMenu = new ToolStripMenuItem();
            SQLMenu = new ToolStripMenuItem();
            openSQLMenu = new ToolStripMenuItem();
            loadSQLMenu = new ToolStripMenuItem();
            closeSQLMenu = new ToolStripMenuItem();
            aboutMeMenu = new ToolStripMenuItem();
            table = new DataGridView();
            labelDanhSachSinhVien = new Label();
            labelThemHoacChinhSua = new Label();
            labelMaSinhVienThem = new Label();
            textBoxMaSinhVienThem = new TextBox();
            textBoxHoVaTen = new TextBox();
            labelQueQuanThem = new Label();
            comboBoxQueQuanThem = new ComboBox();
            labelNgaySinh = new Label();
            textBoxNgay = new TextBox();
            labelSetThang = new Label();
            textBoxThang = new TextBox();
            labelSetNgay = new Label();
            textBoxNam = new TextBox();
            buttonThem = new Button();
            buttonChinhSua = new Button();
            buttonXoa = new Button();
            buttonLuu = new Button();
            buttonHuyBo = new Button();
            labelHoVaTen = new Label();
            labelGioiTinh = new Label();
            radioButtonNam = new RadioButton();
            radioButtonNu = new RadioButton();
            labelDiemThuongXuyen1 = new Label();
            labelDiemThuongXuyen2 = new Label();
            labelDiemThuongXuyen3 = new Label();
            textBoxDiemThuongXuyen1 = new TextBox();
            textBoxDiemThuongXuyen2 = new TextBox();
            textBoxDiemThuongXuyen3 = new TextBox();
            labelDiemGiuaKi = new Label();
            labelDiemCuoiKi = new Label();
            textBoxDiemGiuaKi = new TextBox();
            textBoxDiemCuoiKi = new TextBox();
            groupBoxGioiTinh = new GroupBox();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportPDFMenu = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            groupBoxGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // labelQueQuan
            // 
            labelQueQuan.AutoSize = true;
            labelQueQuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelQueQuan.Location = new Point(11, 93);
            labelQueQuan.Name = "labelQueQuan";
            labelQueQuan.Size = new Size(139, 38);
            labelQueQuan.TabIndex = 0;
            labelQueQuan.Text = "Quê quán";
            // 
            // labelTimKiemSinhVien
            // 
            labelTimKiemSinhVien.AutoSize = true;
            labelTimKiemSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelTimKiemSinhVien.Location = new Point(11, 45);
            labelTimKiemSinhVien.Name = "labelTimKiemSinhVien";
            labelTimKiemSinhVien.Size = new Size(249, 38);
            labelTimKiemSinhVien.TabIndex = 1;
            labelTimKiemSinhVien.Text = "Tìm kiếm sinh viên";
            // 
            // comboBoxQueQuan
            // 
            comboBoxQueQuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxQueQuan.FormattingEnabled = true;
            comboBoxQueQuan.Location = new Point(162, 91);
            comboBoxQueQuan.Name = "comboBoxQueQuan";
            comboBoxQueQuan.Size = new Size(222, 45);
            comboBoxQueQuan.TabIndex = 2;
            // 
            // labelMaSinhVien
            // 
            labelMaSinhVien.AutoSize = true;
            labelMaSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelMaSinhVien.Location = new Point(393, 93);
            labelMaSinhVien.Name = "labelMaSinhVien";
            labelMaSinhVien.Size = new Size(174, 38);
            labelMaSinhVien.TabIndex = 3;
            labelMaSinhVien.Text = "Mã sinh viên";
            // 
            // textBoxMaSinhVien
            // 
            textBoxMaSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxMaSinhVien.Location = new Point(573, 91);
            textBoxMaSinhVien.Name = "textBoxMaSinhVien";
            textBoxMaSinhVien.Size = new Size(169, 43);
            textBoxMaSinhVien.TabIndex = 4;
            // 
            // buttonTim
            // 
            buttonTim.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonTim.Location = new Point(747, 87);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(110, 45);
            buttonTim.TabIndex = 5;
            buttonTim.Text = "Tìm ";
            buttonTim.UseVisualStyleBackColor = true;
            // 
            // buttonHuyTim
            // 
            buttonHuyTim.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonHuyTim.Location = new Point(864, 87);
            buttonHuyTim.Name = "buttonHuyTim";
            buttonHuyTim.Size = new Size(139, 45);
            buttonHuyTim.TabIndex = 6;
            buttonHuyTim.Text = "Hủy Tìm";
            buttonHuyTim.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileMenu, SQLMenu, aboutMeMenu });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(6, 3, 0, 3);
            menuStrip.Size = new Size(1015, 48);
            menuStrip.TabIndex = 7;
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { openFileMenu, saveFileMenu, closeFileMenu, exportToolStripMenuItem });
            fileMenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(74, 42);
            fileMenu.Text = "File";
            // 
            // openFileMenu
            // 
            openFileMenu.Name = "openFileMenu";
            openFileMenu.Size = new Size(224, 42);
            openFileMenu.Text = "Open";
            // 
            // saveFileMenu
            // 
            saveFileMenu.Name = "saveFileMenu";
            saveFileMenu.Size = new Size(224, 42);
            saveFileMenu.Text = "Save";
            // 
            // closeFileMenu
            // 
            closeFileMenu.Name = "closeFileMenu";
            closeFileMenu.Size = new Size(224, 42);
            closeFileMenu.Text = "Close";
            // 
            // SQLMenu
            // 
            SQLMenu.DropDownItems.AddRange(new ToolStripItem[] { openSQLMenu, loadSQLMenu, closeSQLMenu });
            SQLMenu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            SQLMenu.Name = "SQLMenu";
            SQLMenu.Size = new Size(80, 42);
            SQLMenu.Text = "SQL";
            // 
            // openSQLMenu
            // 
            openSQLMenu.Name = "openSQLMenu";
            openSQLMenu.Size = new Size(233, 42);
            openSQLMenu.Text = "Open SQL";
            // 
            // loadSQLMenu
            // 
            loadSQLMenu.Name = "loadSQLMenu";
            loadSQLMenu.Size = new Size(233, 42);
            loadSQLMenu.Text = "Load Data";
            // 
            // closeSQLMenu
            // 
            closeSQLMenu.Name = "closeSQLMenu";
            closeSQLMenu.Size = new Size(233, 42);
            closeSQLMenu.Text = "Close SQL";
            // 
            // aboutMeMenu
            // 
            aboutMeMenu.Font = new Font("Segoe UI", 16.2F);
            aboutMeMenu.Name = "aboutMeMenu";
            aboutMeMenu.Size = new Size(154, 42);
            aboutMeMenu.Text = "About Me";
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(11, 179);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.Size = new Size(991, 349);
            table.TabIndex = 8;
            table.CellClick += table_CellClick;
            table.CellFormatting += table_CellFormatting;
            // 
            // labelDanhSachSinhVien
            // 
            labelDanhSachSinhVien.AutoSize = true;
            labelDanhSachSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDanhSachSinhVien.Location = new Point(11, 139);
            labelDanhSachSinhVien.Name = "labelDanhSachSinhVien";
            labelDanhSachSinhVien.Size = new Size(264, 38);
            labelDanhSachSinhVien.TabIndex = 9;
            labelDanhSachSinhVien.Text = "Danh sách sinh viên";
            // 
            // labelThemHoacChinhSua
            // 
            labelThemHoacChinhSua.AutoSize = true;
            labelThemHoacChinhSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelThemHoacChinhSua.Location = new Point(11, 531);
            labelThemHoacChinhSua.Name = "labelThemHoacChinhSua";
            labelThemHoacChinhSua.Size = new Size(398, 38);
            labelThemHoacChinhSua.TabIndex = 11;
            labelThemHoacChinhSua.Text = "Thêm hoặc chỉnh sửa sinh viên";
            // 
            // labelMaSinhVienThem
            // 
            labelMaSinhVienThem.AutoSize = true;
            labelMaSinhVienThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelMaSinhVienThem.Location = new Point(11, 581);
            labelMaSinhVienThem.Name = "labelMaSinhVienThem";
            labelMaSinhVienThem.Size = new Size(174, 38);
            labelMaSinhVienThem.TabIndex = 12;
            labelMaSinhVienThem.Text = "Mã sinh viên";
            // 
            // textBoxMaSinhVienThem
            // 
            textBoxMaSinhVienThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxMaSinhVienThem.Location = new Point(187, 579);
            textBoxMaSinhVienThem.Name = "textBoxMaSinhVienThem";
            textBoxMaSinhVienThem.Size = new Size(223, 43);
            textBoxMaSinhVienThem.TabIndex = 13;
            // 
            // textBoxHoVaTen
            // 
            textBoxHoVaTen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxHoVaTen.Location = new Point(187, 633);
            textBoxHoVaTen.Name = "textBoxHoVaTen";
            textBoxHoVaTen.Size = new Size(223, 43);
            textBoxHoVaTen.TabIndex = 14;
            // 
            // labelQueQuanThem
            // 
            labelQueQuanThem.AutoSize = true;
            labelQueQuanThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelQueQuanThem.Location = new Point(11, 691);
            labelQueQuanThem.Name = "labelQueQuanThem";
            labelQueQuanThem.Size = new Size(139, 38);
            labelQueQuanThem.TabIndex = 15;
            labelQueQuanThem.Text = "Quê quán";
            // 
            // comboBoxQueQuanThem
            // 
            comboBoxQueQuanThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxQueQuanThem.FormattingEnabled = true;
            comboBoxQueQuanThem.Location = new Point(187, 688);
            comboBoxQueQuanThem.Name = "comboBoxQueQuanThem";
            comboBoxQueQuanThem.Size = new Size(223, 45);
            comboBoxQueQuanThem.TabIndex = 16;
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelNgaySinh.Location = new Point(11, 741);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(141, 38);
            labelNgaySinh.TabIndex = 17;
            labelNgaySinh.Text = "Ngày sinh";
            // 
            // textBoxNgay
            // 
            textBoxNgay.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxNgay.Location = new Point(187, 741);
            textBoxNgay.Name = "textBoxNgay";
            textBoxNgay.Size = new Size(49, 43);
            textBoxNgay.TabIndex = 18;
            // 
            // labelSetThang
            // 
            labelSetThang.AutoSize = true;
            labelSetThang.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelSetThang.Location = new Point(305, 745);
            labelSetThang.Name = "labelSetThang";
            labelSetThang.Size = new Size(28, 38);
            labelSetThang.TabIndex = 19;
            labelSetThang.Text = "/";
            // 
            // textBoxThang
            // 
            textBoxThang.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxThang.Location = new Point(261, 741);
            textBoxThang.Name = "textBoxThang";
            textBoxThang.Size = new Size(45, 43);
            textBoxThang.TabIndex = 20;
            // 
            // labelSetNgay
            // 
            labelSetNgay.AutoSize = true;
            labelSetNgay.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelSetNgay.Location = new Point(234, 745);
            labelSetNgay.Name = "labelSetNgay";
            labelSetNgay.Size = new Size(28, 38);
            labelSetNgay.TabIndex = 21;
            labelSetNgay.Text = "/";
            // 
            // textBoxNam
            // 
            textBoxNam.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxNam.Location = new Point(325, 741);
            textBoxNam.Name = "textBoxNam";
            textBoxNam.Size = new Size(85, 43);
            textBoxNam.TabIndex = 22;
            // 
            // buttonThem
            // 
            buttonThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonThem.Location = new Point(9, 803);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(171, 53);
            buttonThem.TabIndex = 23;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonChinhSua
            // 
            buttonChinhSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonChinhSua.Location = new Point(205, 803);
            buttonChinhSua.Name = "buttonChinhSua";
            buttonChinhSua.Size = new Size(179, 53);
            buttonChinhSua.TabIndex = 24;
            buttonChinhSua.Text = "Chỉnh sửa";
            buttonChinhSua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonXoa.Location = new Point(413, 803);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(179, 53);
            buttonXoa.TabIndex = 25;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonLuu
            // 
            buttonLuu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonLuu.Location = new Point(617, 803);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(179, 53);
            buttonLuu.TabIndex = 26;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = true;
            // 
            // buttonHuyBo
            // 
            buttonHuyBo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonHuyBo.Location = new Point(824, 803);
            buttonHuyBo.Name = "buttonHuyBo";
            buttonHuyBo.Size = new Size(179, 53);
            buttonHuyBo.TabIndex = 27;
            buttonHuyBo.Text = "Hủy bỏ";
            buttonHuyBo.UseVisualStyleBackColor = true;
            // 
            // labelHoVaTen
            // 
            labelHoVaTen.AutoSize = true;
            labelHoVaTen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelHoVaTen.Location = new Point(11, 636);
            labelHoVaTen.Name = "labelHoVaTen";
            labelHoVaTen.Size = new Size(136, 38);
            labelHoVaTen.TabIndex = 10;
            labelHoVaTen.Text = "Họ và tên";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelGioiTinh.Location = new Point(463, 581);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(129, 38);
            labelGioiTinh.TabIndex = 28;
            labelGioiTinh.Text = "Giới Tính";
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            radioButtonNam.Location = new Point(6, 19);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(97, 42);
            radioButtonNam.TabIndex = 29;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            radioButtonNu.Location = new Point(150, 19);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(75, 42);
            radioButtonNu.TabIndex = 30;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // labelDiemThuongXuyen1
            // 
            labelDiemThuongXuyen1.AutoSize = true;
            labelDiemThuongXuyen1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemThuongXuyen1.Location = new Point(416, 637);
            labelDiemThuongXuyen1.Name = "labelDiemThuongXuyen1";
            labelDiemThuongXuyen1.Size = new Size(138, 38);
            labelDiemThuongXuyen1.TabIndex = 31;
            labelDiemThuongXuyen1.Text = "Điểm TX1";
            // 
            // labelDiemThuongXuyen2
            // 
            labelDiemThuongXuyen2.AutoSize = true;
            labelDiemThuongXuyen2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemThuongXuyen2.Location = new Point(416, 691);
            labelDiemThuongXuyen2.Name = "labelDiemThuongXuyen2";
            labelDiemThuongXuyen2.Size = new Size(138, 38);
            labelDiemThuongXuyen2.TabIndex = 32;
            labelDiemThuongXuyen2.Text = "Điểm TX2";
            // 
            // labelDiemThuongXuyen3
            // 
            labelDiemThuongXuyen3.AutoSize = true;
            labelDiemThuongXuyen3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemThuongXuyen3.Location = new Point(416, 741);
            labelDiemThuongXuyen3.Name = "labelDiemThuongXuyen3";
            labelDiemThuongXuyen3.Size = new Size(138, 38);
            labelDiemThuongXuyen3.TabIndex = 33;
            labelDiemThuongXuyen3.Text = "Điểm TX3";
            // 
            // textBoxDiemThuongXuyen1
            // 
            textBoxDiemThuongXuyen1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemThuongXuyen1.Location = new Point(573, 637);
            textBoxDiemThuongXuyen1.Name = "textBoxDiemThuongXuyen1";
            textBoxDiemThuongXuyen1.Size = new Size(73, 43);
            textBoxDiemThuongXuyen1.TabIndex = 34;
            // 
            // textBoxDiemThuongXuyen2
            // 
            textBoxDiemThuongXuyen2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemThuongXuyen2.Location = new Point(573, 691);
            textBoxDiemThuongXuyen2.Name = "textBoxDiemThuongXuyen2";
            textBoxDiemThuongXuyen2.Size = new Size(73, 43);
            textBoxDiemThuongXuyen2.TabIndex = 35;
            // 
            // textBoxDiemThuongXuyen3
            // 
            textBoxDiemThuongXuyen3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemThuongXuyen3.Location = new Point(573, 740);
            textBoxDiemThuongXuyen3.Name = "textBoxDiemThuongXuyen3";
            textBoxDiemThuongXuyen3.Size = new Size(73, 43);
            textBoxDiemThuongXuyen3.TabIndex = 36;
            // 
            // labelDiemGiuaKi
            // 
            labelDiemGiuaKi.AutoSize = true;
            labelDiemGiuaKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemGiuaKi.Location = new Point(658, 637);
            labelDiemGiuaKi.Name = "labelDiemGiuaKi";
            labelDiemGiuaKi.Size = new Size(126, 38);
            labelDiemGiuaKi.TabIndex = 37;
            labelDiemGiuaKi.Text = "Điểm GK";
            // 
            // labelDiemCuoiKi
            // 
            labelDiemCuoiKi.AutoSize = true;
            labelDiemCuoiKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemCuoiKi.Location = new Point(658, 691);
            labelDiemCuoiKi.Name = "labelDiemCuoiKi";
            labelDiemCuoiKi.Size = new Size(124, 38);
            labelDiemCuoiKi.TabIndex = 38;
            labelDiemCuoiKi.Text = "Điểm CK";
            // 
            // textBoxDiemGiuaKi
            // 
            textBoxDiemGiuaKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemGiuaKi.Location = new Point(789, 639);
            textBoxDiemGiuaKi.Name = "textBoxDiemGiuaKi";
            textBoxDiemGiuaKi.Size = new Size(73, 43);
            textBoxDiemGiuaKi.TabIndex = 39;
            // 
            // textBoxDiemCuoiKi
            // 
            textBoxDiemCuoiKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemCuoiKi.Location = new Point(789, 688);
            textBoxDiemCuoiKi.Name = "textBoxDiemCuoiKi";
            textBoxDiemCuoiKi.Size = new Size(73, 43);
            textBoxDiemCuoiKi.TabIndex = 40;
            // 
            // groupBoxGioiTinh
            // 
            groupBoxGioiTinh.Controls.Add(radioButtonNam);
            groupBoxGioiTinh.Controls.Add(radioButtonNu);
            groupBoxGioiTinh.Location = new Point(598, 564);
            groupBoxGioiTinh.Name = "groupBoxGioiTinh";
            groupBoxGioiTinh.Size = new Size(265, 68);
            groupBoxGioiTinh.TabIndex = 41;
            groupBoxGioiTinh.TabStop = false;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportPDFMenu });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(224, 42);
            exportToolStripMenuItem.Text = "Export";
            // 
            // exportPDFMenu
            // 
            exportPDFMenu.Name = "exportPDFMenu";
            exportPDFMenu.Size = new Size(224, 42);
            exportPDFMenu.Text = ".pdf";
            // 
            // QLSVView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 868);
            Controls.Add(groupBoxGioiTinh);
            Controls.Add(textBoxDiemCuoiKi);
            Controls.Add(textBoxDiemGiuaKi);
            Controls.Add(labelDiemCuoiKi);
            Controls.Add(labelDiemGiuaKi);
            Controls.Add(textBoxDiemThuongXuyen3);
            Controls.Add(textBoxDiemThuongXuyen2);
            Controls.Add(textBoxDiemThuongXuyen1);
            Controls.Add(labelDiemThuongXuyen3);
            Controls.Add(labelDiemThuongXuyen2);
            Controls.Add(labelDiemThuongXuyen1);
            Controls.Add(labelGioiTinh);
            Controls.Add(buttonHuyBo);
            Controls.Add(buttonLuu);
            Controls.Add(buttonXoa);
            Controls.Add(buttonChinhSua);
            Controls.Add(buttonThem);
            Controls.Add(textBoxNam);
            Controls.Add(labelSetNgay);
            Controls.Add(textBoxThang);
            Controls.Add(labelSetThang);
            Controls.Add(textBoxNgay);
            Controls.Add(labelNgaySinh);
            Controls.Add(comboBoxQueQuanThem);
            Controls.Add(labelQueQuanThem);
            Controls.Add(textBoxHoVaTen);
            Controls.Add(textBoxMaSinhVienThem);
            Controls.Add(labelMaSinhVienThem);
            Controls.Add(labelThemHoacChinhSua);
            Controls.Add(labelHoVaTen);
            Controls.Add(labelDanhSachSinhVien);
            Controls.Add(table);
            Controls.Add(buttonHuyTim);
            Controls.Add(buttonTim);
            Controls.Add(textBoxMaSinhVien);
            Controls.Add(labelMaSinhVien);
            Controls.Add(comboBoxQueQuan);
            Controls.Add(labelTimKiemSinhVien);
            Controls.Add(labelQueQuan);
            Controls.Add(menuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            Name = "QLSVView";
            Text = "Quản lý sinh viên";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            groupBoxGioiTinh.ResumeLayout(false);
            groupBoxGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label labelQueQuan;
        private Label labelTimKiemSinhVien;
        public ComboBox comboBoxQueQuan;
        private Label labelMaSinhVien;
        public TextBox textBoxMaSinhVien;
        public Button buttonTim;
        public Button buttonHuyTim;
        public MenuStrip menuStrip1;
        public ToolStripMenuItem fileMenu;
        public ToolStripMenuItem SQLMenu;
        public ToolStripMenuItem openFileMenu;
        public ToolStripMenuItem saveFileMenu;
        public ToolStripMenuItem closeFileMenu;
        public DataGridView table;
        private Label labelDanhSachSinhVien;
        private Label labelThemHoacChinhSua;
        private Label labelMaSinhVienThem;
        public TextBox textBoxMaSinhVienThem;
        public TextBox textBoxHoVaTen;
        private Label labelQueQuanThem;
        public ComboBox comboBoxQueQuanThem;
        private Label labelNgaySinh;
        public TextBox textBoxNgay;
        private Label labelSetThang;
        public TextBox textBoxThang;
        private Label labelSetNgay;
        public TextBox textBoxNam;
        public Button buttonThem;
        public Button buttonChinhSua;
        public Button buttonXoa;
        public Button buttonLuu;
        public Button buttonHuyBo;
        private Label labelHoVaTen;
        private Label labelGioiTinh;
        public RadioButton radioButtonNam;
        public RadioButton radioButtonNu;
        private Label labelDiemThuongXuyen1;
        private Label labelDiemThuongXuyen2;
        private Label labelDiemThuongXuyen3;
        public TextBox textBoxDiemThuongXuyen1;
        public TextBox textBoxDiemThuongXuyen2;
        public TextBox textBoxDiemThuongXuyen3;
        private Label labelDiemGiuaKi;
        private Label labelDiemCuoiKi;
        public TextBox textBoxDiemGiuaKi;
        public TextBox textBoxDiemCuoiKi;
        private GroupBox groupBoxGioiTinh;
        public MenuStrip menuStrip;
        public ToolStripMenuItem openSQLMenu;
        public ToolStripMenuItem loadSQLMenu;
        public ToolStripMenuItem closeSQLMenu;
        public ToolStripMenuItem aboutMeMenu;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportPDFMenu;
    }
}
