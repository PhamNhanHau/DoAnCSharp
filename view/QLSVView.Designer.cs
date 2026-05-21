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
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            aboutMeToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            groupBoxGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // labelQueQuan
            // 
            labelQueQuan.AutoSize = true;
            labelQueQuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelQueQuan.Location = new Point(10, 70);
            labelQueQuan.Name = "labelQueQuan";
            labelQueQuan.Size = new Size(108, 30);
            labelQueQuan.TabIndex = 0;
            labelQueQuan.Text = "Quê quán";
            // 
            // labelTimKiemSinhVien
            // 
            labelTimKiemSinhVien.AutoSize = true;
            labelTimKiemSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelTimKiemSinhVien.Location = new Point(10, 34);
            labelTimKiemSinhVien.Name = "labelTimKiemSinhVien";
            labelTimKiemSinhVien.Size = new Size(192, 30);
            labelTimKiemSinhVien.TabIndex = 1;
            labelTimKiemSinhVien.Text = "Tìm kiếm sinh viên";
            // 
            // comboBoxQueQuan
            // 
            comboBoxQueQuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxQueQuan.FormattingEnabled = true;
            comboBoxQueQuan.Location = new Point(142, 68);
            comboBoxQueQuan.Margin = new Padding(3, 2, 3, 2);
            comboBoxQueQuan.Name = "comboBoxQueQuan";
            comboBoxQueQuan.Size = new Size(195, 38);
            comboBoxQueQuan.TabIndex = 2;
            // 
            // labelMaSinhVien
            // 
            labelMaSinhVien.AutoSize = true;
            labelMaSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelMaSinhVien.Location = new Point(344, 70);
            labelMaSinhVien.Name = "labelMaSinhVien";
            labelMaSinhVien.Size = new Size(134, 30);
            labelMaSinhVien.TabIndex = 3;
            labelMaSinhVien.Text = "Mã sinh viên";
            // 
            // textBoxMaSinhVien
            // 
            textBoxMaSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxMaSinhVien.Location = new Point(501, 68);
            textBoxMaSinhVien.Margin = new Padding(3, 2, 3, 2);
            textBoxMaSinhVien.Name = "textBoxMaSinhVien";
            textBoxMaSinhVien.Size = new Size(148, 36);
            textBoxMaSinhVien.TabIndex = 4;
            // 
            // buttonTim
            // 
            buttonTim.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonTim.Location = new Point(654, 65);
            buttonTim.Margin = new Padding(3, 2, 3, 2);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(96, 34);
            buttonTim.TabIndex = 5;
            buttonTim.Text = "Tìm ";
            buttonTim.UseVisualStyleBackColor = true;
            // 
            // buttonHuyTim
            // 
            buttonHuyTim.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonHuyTim.Location = new Point(756, 65);
            buttonHuyTim.Margin = new Padding(3, 2, 3, 2);
            buttonHuyTim.Name = "buttonHuyTim";
            buttonHuyTim.Size = new Size(122, 34);
            buttonHuyTim.TabIndex = 6;
            buttonHuyTim.Text = "Hủy Tìm";
            buttonHuyTim.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutMeToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(888, 38);
            menuStrip.TabIndex = 7;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(58, 34);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(180, 34);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 34);
            saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 34);
            closeToolStripMenuItem.Text = "Close";
            // 
            // aboutMeToolStripMenuItem
            // 
            aboutMeToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            aboutMeToolStripMenuItem.Size = new Size(122, 34);
            aboutMeToolStripMenuItem.Text = "About Me";
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(10, 134);
            table.Margin = new Padding(3, 2, 3, 2);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.Size = new Size(867, 262);
            table.TabIndex = 8;
            table.CellClick += table_CellClick;
            table.CellFormatting += table_CellFormatting;
            // 
            // labelDanhSachSinhVien
            // 
            labelDanhSachSinhVien.AutoSize = true;
            labelDanhSachSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDanhSachSinhVien.Location = new Point(10, 104);
            labelDanhSachSinhVien.Name = "labelDanhSachSinhVien";
            labelDanhSachSinhVien.Size = new Size(201, 30);
            labelDanhSachSinhVien.TabIndex = 9;
            labelDanhSachSinhVien.Text = "Danh sách sinh viên";
            // 
            // labelThemHoacChinhSua
            // 
            labelThemHoacChinhSua.AutoSize = true;
            labelThemHoacChinhSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelThemHoacChinhSua.Location = new Point(10, 398);
            labelThemHoacChinhSua.Name = "labelThemHoacChinhSua";
            labelThemHoacChinhSua.Size = new Size(306, 30);
            labelThemHoacChinhSua.TabIndex = 11;
            labelThemHoacChinhSua.Text = "Thêm hoặc chỉnh sửa sinh viên";
            // 
            // labelMaSinhVienThem
            // 
            labelMaSinhVienThem.AutoSize = true;
            labelMaSinhVienThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelMaSinhVienThem.Location = new Point(10, 436);
            labelMaSinhVienThem.Name = "labelMaSinhVienThem";
            labelMaSinhVienThem.Size = new Size(134, 30);
            labelMaSinhVienThem.TabIndex = 12;
            labelMaSinhVienThem.Text = "Mã sinh viên";
            // 
            // textBoxMaSinhVienThem
            // 
            textBoxMaSinhVienThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxMaSinhVienThem.Location = new Point(164, 434);
            textBoxMaSinhVienThem.Margin = new Padding(3, 2, 3, 2);
            textBoxMaSinhVienThem.Name = "textBoxMaSinhVienThem";
            textBoxMaSinhVienThem.Size = new Size(196, 36);
            textBoxMaSinhVienThem.TabIndex = 13;
            // 
            // textBoxHoVaTen
            // 
            textBoxHoVaTen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxHoVaTen.Location = new Point(164, 475);
            textBoxHoVaTen.Margin = new Padding(3, 2, 3, 2);
            textBoxHoVaTen.Name = "textBoxHoVaTen";
            textBoxHoVaTen.Size = new Size(196, 36);
            textBoxHoVaTen.TabIndex = 14;
            // 
            // labelQueQuanThem
            // 
            labelQueQuanThem.AutoSize = true;
            labelQueQuanThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelQueQuanThem.Location = new Point(10, 518);
            labelQueQuanThem.Name = "labelQueQuanThem";
            labelQueQuanThem.Size = new Size(108, 30);
            labelQueQuanThem.TabIndex = 15;
            labelQueQuanThem.Text = "Quê quán";
            // 
            // comboBoxQueQuanThem
            // 
            comboBoxQueQuanThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxQueQuanThem.FormattingEnabled = true;
            comboBoxQueQuanThem.Location = new Point(164, 516);
            comboBoxQueQuanThem.Margin = new Padding(3, 2, 3, 2);
            comboBoxQueQuanThem.Name = "comboBoxQueQuanThem";
            comboBoxQueQuanThem.Size = new Size(196, 38);
            comboBoxQueQuanThem.TabIndex = 16;
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelNgaySinh.Location = new Point(10, 556);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(108, 30);
            labelNgaySinh.TabIndex = 17;
            labelNgaySinh.Text = "Ngày sinh";
            // 
            // textBoxNgay
            // 
            textBoxNgay.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxNgay.Location = new Point(164, 556);
            textBoxNgay.Margin = new Padding(3, 2, 3, 2);
            textBoxNgay.Name = "textBoxNgay";
            textBoxNgay.Size = new Size(43, 36);
            textBoxNgay.TabIndex = 18;
            // 
            // labelSetThang
            // 
            labelSetThang.AutoSize = true;
            labelSetThang.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelSetThang.Location = new Point(267, 559);
            labelSetThang.Name = "labelSetThang";
            labelSetThang.Size = new Size(22, 30);
            labelSetThang.TabIndex = 19;
            labelSetThang.Text = "/";
            // 
            // textBoxThang
            // 
            textBoxThang.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxThang.Location = new Point(228, 556);
            textBoxThang.Margin = new Padding(3, 2, 3, 2);
            textBoxThang.Name = "textBoxThang";
            textBoxThang.Size = new Size(40, 36);
            textBoxThang.TabIndex = 20;
            // 
            // labelSetNgay
            // 
            labelSetNgay.AutoSize = true;
            labelSetNgay.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelSetNgay.Location = new Point(205, 559);
            labelSetNgay.Name = "labelSetNgay";
            labelSetNgay.Size = new Size(22, 30);
            labelSetNgay.TabIndex = 21;
            labelSetNgay.Text = "/";
            // 
            // textBoxNam
            // 
            textBoxNam.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxNam.Location = new Point(284, 556);
            textBoxNam.Margin = new Padding(3, 2, 3, 2);
            textBoxNam.Name = "textBoxNam";
            textBoxNam.Size = new Size(75, 36);
            textBoxNam.TabIndex = 22;
            // 
            // buttonThem
            // 
            buttonThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonThem.Location = new Point(8, 602);
            buttonThem.Margin = new Padding(3, 2, 3, 2);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(150, 40);
            buttonThem.TabIndex = 23;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonChinhSua
            // 
            buttonChinhSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonChinhSua.Location = new Point(179, 602);
            buttonChinhSua.Margin = new Padding(3, 2, 3, 2);
            buttonChinhSua.Name = "buttonChinhSua";
            buttonChinhSua.Size = new Size(157, 40);
            buttonChinhSua.TabIndex = 24;
            buttonChinhSua.Text = "Chỉnh sửa";
            buttonChinhSua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonXoa.Location = new Point(361, 602);
            buttonXoa.Margin = new Padding(3, 2, 3, 2);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(157, 40);
            buttonXoa.TabIndex = 25;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonLuu
            // 
            buttonLuu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonLuu.Location = new Point(540, 602);
            buttonLuu.Margin = new Padding(3, 2, 3, 2);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(157, 40);
            buttonLuu.TabIndex = 26;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = true;
            // 
            // buttonHuyBo
            // 
            buttonHuyBo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonHuyBo.Location = new Point(721, 602);
            buttonHuyBo.Margin = new Padding(3, 2, 3, 2);
            buttonHuyBo.Name = "buttonHuyBo";
            buttonHuyBo.Size = new Size(157, 40);
            buttonHuyBo.TabIndex = 27;
            buttonHuyBo.Text = "Hủy bỏ";
            buttonHuyBo.UseVisualStyleBackColor = true;
            // 
            // labelHoVaTen
            // 
            labelHoVaTen.AutoSize = true;
            labelHoVaTen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelHoVaTen.Location = new Point(10, 477);
            labelHoVaTen.Name = "labelHoVaTen";
            labelHoVaTen.Size = new Size(107, 30);
            labelHoVaTen.TabIndex = 10;
            labelHoVaTen.Text = "Họ và tên";
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelGioiTinh.Location = new Point(405, 436);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(98, 30);
            labelGioiTinh.TabIndex = 28;
            labelGioiTinh.Text = "Giới Tính";
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            radioButtonNam.Location = new Point(5, 14);
            radioButtonNam.Margin = new Padding(3, 2, 3, 2);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(77, 34);
            radioButtonNam.TabIndex = 29;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            radioButtonNu.Location = new Point(131, 14);
            radioButtonNu.Margin = new Padding(3, 2, 3, 2);
            radioButtonNu.Name = "radioButtonNu";
            radioButtonNu.Size = new Size(60, 34);
            radioButtonNu.TabIndex = 30;
            radioButtonNu.TabStop = true;
            radioButtonNu.Text = "Nữ";
            radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // labelDiemThuongXuyen1
            // 
            labelDiemThuongXuyen1.AutoSize = true;
            labelDiemThuongXuyen1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemThuongXuyen1.Location = new Point(364, 478);
            labelDiemThuongXuyen1.Name = "labelDiemThuongXuyen1";
            labelDiemThuongXuyen1.Size = new Size(107, 30);
            labelDiemThuongXuyen1.TabIndex = 31;
            labelDiemThuongXuyen1.Text = "Điểm TX1";
            // 
            // labelDiemThuongXuyen2
            // 
            labelDiemThuongXuyen2.AutoSize = true;
            labelDiemThuongXuyen2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemThuongXuyen2.Location = new Point(364, 518);
            labelDiemThuongXuyen2.Name = "labelDiemThuongXuyen2";
            labelDiemThuongXuyen2.Size = new Size(107, 30);
            labelDiemThuongXuyen2.TabIndex = 32;
            labelDiemThuongXuyen2.Text = "Điểm TX2";
            // 
            // labelDiemThuongXuyen3
            // 
            labelDiemThuongXuyen3.AutoSize = true;
            labelDiemThuongXuyen3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemThuongXuyen3.Location = new Point(364, 556);
            labelDiemThuongXuyen3.Name = "labelDiemThuongXuyen3";
            labelDiemThuongXuyen3.Size = new Size(107, 30);
            labelDiemThuongXuyen3.TabIndex = 33;
            labelDiemThuongXuyen3.Text = "Điểm TX3";
            // 
            // textBoxDiemThuongXuyen1
            // 
            textBoxDiemThuongXuyen1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemThuongXuyen1.Location = new Point(501, 478);
            textBoxDiemThuongXuyen1.Margin = new Padding(3, 2, 3, 2);
            textBoxDiemThuongXuyen1.Name = "textBoxDiemThuongXuyen1";
            textBoxDiemThuongXuyen1.Size = new Size(64, 36);
            textBoxDiemThuongXuyen1.TabIndex = 34;
            // 
            // textBoxDiemThuongXuyen2
            // 
            textBoxDiemThuongXuyen2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemThuongXuyen2.Location = new Point(501, 518);
            textBoxDiemThuongXuyen2.Margin = new Padding(3, 2, 3, 2);
            textBoxDiemThuongXuyen2.Name = "textBoxDiemThuongXuyen2";
            textBoxDiemThuongXuyen2.Size = new Size(64, 36);
            textBoxDiemThuongXuyen2.TabIndex = 35;
            // 
            // textBoxDiemThuongXuyen3
            // 
            textBoxDiemThuongXuyen3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemThuongXuyen3.Location = new Point(501, 555);
            textBoxDiemThuongXuyen3.Margin = new Padding(3, 2, 3, 2);
            textBoxDiemThuongXuyen3.Name = "textBoxDiemThuongXuyen3";
            textBoxDiemThuongXuyen3.Size = new Size(64, 36);
            textBoxDiemThuongXuyen3.TabIndex = 36;
            // 
            // labelDiemGiuaKi
            // 
            labelDiemGiuaKi.AutoSize = true;
            labelDiemGiuaKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemGiuaKi.Location = new Point(576, 478);
            labelDiemGiuaKi.Name = "labelDiemGiuaKi";
            labelDiemGiuaKi.Size = new Size(98, 30);
            labelDiemGiuaKi.TabIndex = 37;
            labelDiemGiuaKi.Text = "Điểm GK";
            // 
            // labelDiemCuoiKi
            // 
            labelDiemCuoiKi.AutoSize = true;
            labelDiemCuoiKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDiemCuoiKi.Location = new Point(576, 518);
            labelDiemCuoiKi.Name = "labelDiemCuoiKi";
            labelDiemCuoiKi.Size = new Size(97, 30);
            labelDiemCuoiKi.TabIndex = 38;
            labelDiemCuoiKi.Text = "Điểm CK";
            // 
            // textBoxDiemGiuaKi
            // 
            textBoxDiemGiuaKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemGiuaKi.Location = new Point(690, 479);
            textBoxDiemGiuaKi.Margin = new Padding(3, 2, 3, 2);
            textBoxDiemGiuaKi.Name = "textBoxDiemGiuaKi";
            textBoxDiemGiuaKi.Size = new Size(64, 36);
            textBoxDiemGiuaKi.TabIndex = 39;
            // 
            // textBoxDiemCuoiKi
            // 
            textBoxDiemCuoiKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemCuoiKi.Location = new Point(690, 516);
            textBoxDiemCuoiKi.Margin = new Padding(3, 2, 3, 2);
            textBoxDiemCuoiKi.Name = "textBoxDiemCuoiKi";
            textBoxDiemCuoiKi.Size = new Size(64, 36);
            textBoxDiemCuoiKi.TabIndex = 40;
            // 
            // groupBoxGioiTinh
            // 
            groupBoxGioiTinh.Controls.Add(radioButtonNam);
            groupBoxGioiTinh.Controls.Add(radioButtonNu);
            groupBoxGioiTinh.Location = new Point(523, 423);
            groupBoxGioiTinh.Margin = new Padding(3, 2, 3, 2);
            groupBoxGioiTinh.Name = "groupBoxGioiTinh";
            groupBoxGioiTinh.Padding = new Padding(3, 2, 3, 2);
            groupBoxGioiTinh.Size = new Size(232, 51);
            groupBoxGioiTinh.TabIndex = 41;
            groupBoxGioiTinh.TabStop = false;
            // 
            // QLSVView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 651);
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
            Margin = new Padding(3, 2, 3, 2);
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
        public ToolStripMenuItem fileToolStripMenuItem;
        public ToolStripMenuItem aboutMeToolStripMenuItem;
        public ToolStripMenuItem openToolStripMenuItem;
        public ToolStripMenuItem saveToolStripMenuItem;
        public ToolStripMenuItem closeToolStripMenuItem;
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
    }
}
