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
            menuStrip1 = new MenuStrip();
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
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            groupBoxGioiTinh.SuspendLayout();
            SuspendLayout();
            // 
            // labelQueQuan
            // 
            labelQueQuan.AutoSize = true;
            labelQueQuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelQueQuan.Location = new Point(12, 93);
            labelQueQuan.Name = "labelQueQuan";
            labelQueQuan.Size = new Size(139, 38);
            labelQueQuan.TabIndex = 0;
            labelQueQuan.Text = "Quê quán";
            // 
            // labelTimKiemSinhVien
            // 
            labelTimKiemSinhVien.AutoSize = true;
            labelTimKiemSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelTimKiemSinhVien.Location = new Point(12, 46);
            labelTimKiemSinhVien.Name = "labelTimKiemSinhVien";
            labelTimKiemSinhVien.Size = new Size(249, 38);
            labelTimKiemSinhVien.TabIndex = 1;
            labelTimKiemSinhVien.Text = "Tìm kiếm sinh viên";
            // 
            // comboBoxQueQuan
            // 
            comboBoxQueQuan.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            comboBoxQueQuan.FormattingEnabled = true;
            comboBoxQueQuan.Location = new Point(162, 90);
            comboBoxQueQuan.Name = "comboBoxQueQuan";
            comboBoxQueQuan.Size = new Size(222, 45);
            comboBoxQueQuan.TabIndex = 2;
            comboBoxQueQuan.SelectedIndexChanged += comboBoxQueQuan_SelectedIndexChanged;
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
            labelMaSinhVien.Click += labelMaSinhVien_Click;
            // 
            // textBoxMaSinhVien
            // 
            textBoxMaSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxMaSinhVien.Location = new Point(573, 90);
            textBoxMaSinhVien.Name = "textBoxMaSinhVien";
            textBoxMaSinhVien.Size = new Size(169, 43);
            textBoxMaSinhVien.TabIndex = 4;
            textBoxMaSinhVien.TextChanged += textBox1_TextChanged;
            // 
            // buttonTim
            // 
            buttonTim.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonTim.Location = new Point(748, 87);
            buttonTim.Name = "buttonTim";
            buttonTim.Size = new Size(110, 46);
            buttonTim.TabIndex = 5;
            buttonTim.Text = "Tìm ";
            buttonTim.UseVisualStyleBackColor = true;
            // 
            // buttonHuyTim
            // 
            buttonHuyTim.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonHuyTim.Location = new Point(864, 87);
            buttonHuyTim.Name = "buttonHuyTim";
            buttonHuyTim.Size = new Size(139, 46);
            buttonHuyTim.TabIndex = 6;
            buttonHuyTim.Text = "Hủy Tìm";
            buttonHuyTim.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutMeToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1015, 46);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(74, 42);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(176, 42);
            openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(176, 42);
            saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(176, 42);
            closeToolStripMenuItem.Text = "Close";
            // 
            // aboutMeToolStripMenuItem
            // 
            aboutMeToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            aboutMeToolStripMenuItem.Size = new Size(154, 42);
            aboutMeToolStripMenuItem.Text = "About Me";
            // 
            // table
            // 
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(12, 179);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.Size = new Size(991, 349);
            table.TabIndex = 8;
            table.CellContentClick += table_CellContentClick;
            // 
            // labelDanhSachSinhVien
            // 
            labelDanhSachSinhVien.AutoSize = true;
            labelDanhSachSinhVien.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelDanhSachSinhVien.Location = new Point(12, 138);
            labelDanhSachSinhVien.Name = "labelDanhSachSinhVien";
            labelDanhSachSinhVien.Size = new Size(264, 38);
            labelDanhSachSinhVien.TabIndex = 9;
            labelDanhSachSinhVien.Text = "Danh sách sinh viên";
            // 
            // labelThemHoacChinhSua
            // 
            labelThemHoacChinhSua.AutoSize = true;
            labelThemHoacChinhSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelThemHoacChinhSua.Location = new Point(12, 531);
            labelThemHoacChinhSua.Name = "labelThemHoacChinhSua";
            labelThemHoacChinhSua.Size = new Size(398, 38);
            labelThemHoacChinhSua.TabIndex = 11;
            labelThemHoacChinhSua.Text = "Thêm hoặc chỉnh sửa sinh viên";
            // 
            // labelMaSinhVienThem
            // 
            labelMaSinhVienThem.AutoSize = true;
            labelMaSinhVienThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelMaSinhVienThem.Location = new Point(12, 582);
            labelMaSinhVienThem.Name = "labelMaSinhVienThem";
            labelMaSinhVienThem.Size = new Size(174, 38);
            labelMaSinhVienThem.TabIndex = 12;
            labelMaSinhVienThem.Text = "Mã sinh viên";
            labelMaSinhVienThem.Click += labelMaSinhVienThem_Click;
            // 
            // textBoxMaSinhVienThem
            // 
            textBoxMaSinhVienThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxMaSinhVienThem.Location = new Point(187, 579);
            textBoxMaSinhVienThem.Name = "textBoxMaSinhVienThem";
            textBoxMaSinhVienThem.Size = new Size(223, 43);
            textBoxMaSinhVienThem.TabIndex = 13;
            textBoxMaSinhVienThem.TextChanged += textBoxMaSinhVienThem_TextChanged;
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
            labelQueQuanThem.Location = new Point(12, 691);
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
            labelNgaySinh.Location = new Point(12, 742);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(141, 38);
            labelNgaySinh.TabIndex = 17;
            labelNgaySinh.Text = "Ngày sinh";
            // 
            // textBoxNgay
            // 
            textBoxNgay.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxNgay.Location = new Point(187, 742);
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
            labelSetThang.Click += label4_Click;
            // 
            // textBoxThang
            // 
            textBoxThang.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxThang.Location = new Point(261, 742);
            textBoxThang.Name = "textBoxThang";
            textBoxThang.Size = new Size(45, 43);
            textBoxThang.TabIndex = 20;
            textBoxThang.TextChanged += textBox2_TextChanged;
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
            labelSetNgay.Click += label4_Click_1;
            // 
            // textBoxNam
            // 
            textBoxNam.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxNam.Location = new Point(325, 742);
            textBoxNam.Name = "textBoxNam";
            textBoxNam.Size = new Size(85, 43);
            textBoxNam.TabIndex = 22;
            textBoxNam.TextChanged += textBox3_TextChanged;
            // 
            // buttonThem
            // 
            buttonThem.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonThem.Location = new Point(9, 802);
            buttonThem.Name = "buttonThem";
            buttonThem.Size = new Size(172, 54);
            buttonThem.TabIndex = 23;
            buttonThem.Text = "Thêm";
            buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonChinhSua
            // 
            buttonChinhSua.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonChinhSua.Location = new Point(205, 802);
            buttonChinhSua.Name = "buttonChinhSua";
            buttonChinhSua.Size = new Size(179, 54);
            buttonChinhSua.TabIndex = 24;
            buttonChinhSua.Text = "Chỉnh sửa";
            buttonChinhSua.UseVisualStyleBackColor = true;
            buttonChinhSua.Click += buttonChinhSua_Click;
            // 
            // buttonXoa
            // 
            buttonXoa.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonXoa.Location = new Point(413, 802);
            buttonXoa.Name = "buttonXoa";
            buttonXoa.Size = new Size(179, 54);
            buttonXoa.TabIndex = 25;
            buttonXoa.Text = "Xóa";
            buttonXoa.UseVisualStyleBackColor = true;
            buttonXoa.Click += button1_Click;
            // 
            // buttonLuu
            // 
            buttonLuu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonLuu.Location = new Point(617, 802);
            buttonLuu.Name = "buttonLuu";
            buttonLuu.Size = new Size(179, 54);
            buttonLuu.TabIndex = 26;
            buttonLuu.Text = "Lưu";
            buttonLuu.UseVisualStyleBackColor = true;
            buttonLuu.Click += button2_Click;
            // 
            // buttonHuyBo
            // 
            buttonHuyBo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            buttonHuyBo.Location = new Point(824, 802);
            buttonHuyBo.Name = "buttonHuyBo";
            buttonHuyBo.Size = new Size(179, 54);
            buttonHuyBo.TabIndex = 27;
            buttonHuyBo.Text = "Hủy bỏ";
            buttonHuyBo.UseVisualStyleBackColor = true;
            // 
            // labelHoVaTen
            // 
            labelHoVaTen.AutoSize = true;
            labelHoVaTen.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelHoVaTen.Location = new Point(12, 636);
            labelHoVaTen.Name = "labelHoVaTen";
            labelHoVaTen.Size = new Size(136, 38);
            labelHoVaTen.TabIndex = 10;
            labelHoVaTen.Text = "Họ và tên";
            labelHoVaTen.Click += label1_Click_2;
            // 
            // labelGioiTinh
            // 
            labelGioiTinh.AutoSize = true;
            labelGioiTinh.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelGioiTinh.Location = new Point(463, 582);
            labelGioiTinh.Name = "labelGioiTinh";
            labelGioiTinh.Size = new Size(129, 38);
            labelGioiTinh.TabIndex = 28;
            labelGioiTinh.Text = "Giới Tính";
            labelGioiTinh.Click += label4_Click_2;
            // 
            // radioButtonNam
            // 
            radioButtonNam.AutoSize = true;
            radioButtonNam.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            radioButtonNam.Location = new Point(6, 18);
            radioButtonNam.Name = "radioButtonNam";
            radioButtonNam.Size = new Size(97, 42);
            radioButtonNam.TabIndex = 29;
            radioButtonNam.TabStop = true;
            radioButtonNam.Text = "Nam";
            radioButtonNam.UseVisualStyleBackColor = true;
            radioButtonNam.CheckedChanged += radioButtonNam_CheckedChanged;
            // 
            // radioButtonNu
            // 
            radioButtonNu.AutoSize = true;
            radioButtonNu.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            radioButtonNu.Location = new Point(150, 18);
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
            labelDiemThuongXuyen1.Location = new Point(416, 638);
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
            labelDiemThuongXuyen3.Location = new Point(416, 742);
            labelDiemThuongXuyen3.Name = "labelDiemThuongXuyen3";
            labelDiemThuongXuyen3.Size = new Size(138, 38);
            labelDiemThuongXuyen3.TabIndex = 33;
            labelDiemThuongXuyen3.Text = "Điểm TX3";
            // 
            // textBoxDiemThuongXuyen1
            // 
            textBoxDiemThuongXuyen1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemThuongXuyen1.Location = new Point(573, 638);
            textBoxDiemThuongXuyen1.Name = "textBoxDiemThuongXuyen1";
            textBoxDiemThuongXuyen1.Size = new Size(73, 43);
            textBoxDiemThuongXuyen1.TabIndex = 34;
            textBoxDiemThuongXuyen1.TextChanged += textBox1_TextChanged_1;
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
            labelDiemGiuaKi.Location = new Point(658, 638);
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
            textBoxDiemGiuaKi.Location = new Point(788, 639);
            textBoxDiemGiuaKi.Name = "textBoxDiemGiuaKi";
            textBoxDiemGiuaKi.Size = new Size(73, 43);
            textBoxDiemGiuaKi.TabIndex = 39;
            textBoxDiemGiuaKi.TextChanged += textBox4_TextChanged;
            // 
            // textBoxDiemCuoiKi
            // 
            textBoxDiemCuoiKi.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            textBoxDiemCuoiKi.Location = new Point(788, 688);
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
            groupBoxGioiTinh.Enter += groupBox1_Enter;
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QLSVView";
            Text = "Quản lý sinh viên";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            groupBoxGioiTinh.ResumeLayout(false);
            groupBoxGioiTinh.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label labelQueQuan;
        private Label labelTimKiemSinhVien;
        private ComboBox comboBoxQueQuan;
        private Label labelMaSinhVien;
        private Button button2;
        public TextBox textBoxMaSinhVien;
        public Button buttonTim;
        public Button buttonHuyTim;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem aboutMeToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private DataGridView table;
        private Label labelDanhSachSinhVien;
        private Label labelThemHoacChinhSua;
        private Label labelMaSinhVienThem;
        public TextBox textBoxMaSinhVienThem;
        public TextBox textBoxHoVaTen;
        private Label labelQueQuanThem;
        private ComboBox comboBoxQueQuanThem;
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
        private RadioButton radioButtonNam;
        private RadioButton radioButtonNu;
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
        private QLSVModel model = new QLSVModel();
        private GroupBox groupBoxGioiTinh;
    }
}
