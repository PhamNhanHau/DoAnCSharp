using DoAnCSharp.Models;
using DoAnCSharp.view;
using System.ComponentModel;

namespace DoAnCSharp
{
    public partial class QLSVView : Form
    {
        public QLSVView() { InitializeComponent(); }
        public void capNhatDuLieuTinhVaoCBBQueQuan(List<Tinh> dsTinh)
        {
            this.comboBoxQueQuan.DataSource = null;
            this.comboBoxQueQuan.DataSource = dsTinh;
            this.comboBoxQueQuan.DisplayMember = "TenTinh";
            this.comboBoxQueQuan.ValueMember = "MaTinh";
            this.comboBoxQueQuanThem.DataSource = null;
            this.comboBoxQueQuanThem.DataSource = dsTinh;
            this.comboBoxQueQuanThem.DisplayMember = "TenTinh";
            this.comboBoxQueQuanThem.ValueMember = "MaTinh";

        }
        public void xoaFormThongTin()
        {
            this.textBoxMaSinhVienThem.Text = string.Empty;
            this.textBoxHoVaTen.Text = string.Empty;
            this.comboBoxQueQuanThem.SelectedIndex = 0;
            this.textBoxNgay.Text = string.Empty;
            this.textBoxThang.Text = string.Empty;
            this.textBoxNam.Text = string.Empty;
            this.radioButtonNam.Checked = false;
            this.radioButtonNu.Checked = false;
            this.textBoxDiemThuongXuyen1.Text = string.Empty;
            this.textBoxDiemThuongXuyen2.Text = string.Empty;
            this.textBoxDiemThuongXuyen3.Text = string.Empty;
            this.textBoxDiemGiuaKi.Text = string.Empty;
            this.textBoxDiemCuoiKi.Text = string.Empty;
        }
        public void batButtonThem()
        {
            buttonThem.BackColor = Color.LightGreen;
            buttonThem.ForeColor = Color.White;
            buttonChinhSua.BackColor = SystemColors.Control;
            buttonXoa.BackColor = SystemColors.Control;
        }
        public void batButtonChinhSua()
        {
            buttonChinhSua.BackColor = Color.LightGreen;
            buttonChinhSua.ForeColor = Color.White;
            buttonThem.BackColor = SystemColors.Control;
            buttonXoa.BackColor = SystemColors.Control;
        }
        public void batButtonXoa()
        {
            buttonXoa.BackColor = Color.LightGreen;
            buttonXoa.ForeColor = Color.White;
            buttonThem.BackColor = SystemColors.Control;
            buttonChinhSua.BackColor = SystemColors.Control;
        }
        public void batButtonLuu()
        {
            buttonChinhSua.BackColor = SystemColors.Control;
            buttonThem.BackColor = SystemColors.Control;
            buttonXoa.BackColor = SystemColors.Control;
        }
        public void themDuLieuVaoTable()
        {

        }
        public void capNhatDulieuVaoDataGridView()
        {
            //Khoi tao du lieu cho DataGridView
            this.table.Columns.Clear();

            DataGridViewTextBoxColumn colMaSV = new DataGridViewTextBoxColumn();
            colMaSV.DataPropertyName = "MaSinhVien"; //ten bien tren class model
            colMaSV.HeaderText = "Mã Sinh Viên";     //ten tieu de hien thi tren luoi
            colMaSV.Width = 110;                     //kich thuoc
            this.table.Columns.Add(colMaSV);

            DataGridViewTextBoxColumn colHoTen = new DataGridViewTextBoxColumn();
            colHoTen.DataPropertyName = "TenSinhVien";
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.Width = 150;
            this.table.Columns.Add(colHoTen);

            DataGridViewTextBoxColumn colGioiTinh = new DataGridViewTextBoxColumn();
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.Width = 80;
            this.table.Columns.Add(colGioiTinh);

            DataGridViewTextBoxColumn colQueQuan = new DataGridViewTextBoxColumn();
            colQueQuan.DataPropertyName = "QueQuan";
            colQueQuan.HeaderText = "Quê Quán";
            colQueQuan.Width = 120;
            this.table.Columns.Add(colQueQuan);

            DataGridViewTextBoxColumn colNgaySinh = new DataGridViewTextBoxColumn();
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.Width = 100;
            colNgaySinh.DefaultCellStyle.Format = "dd/MM/yyyy"; // Định dạng ngày hiển thị giống trên form
            this.table.Columns.Add(colNgaySinh);

            DataGridViewTextBoxColumn colTX1 = new DataGridViewTextBoxColumn();
            colTX1.DataPropertyName = "DiemThuongXuyen1";
            colTX1.HeaderText = "Điểm TX1";
            colTX1.Width = 75;
            this.table.Columns.Add(colTX1);

            DataGridViewTextBoxColumn colTX2 = new DataGridViewTextBoxColumn();
            colTX2.DataPropertyName = "DiemThuongXuyen2";
            colTX2.HeaderText = "Điểm TX2";
            colTX2.Width = 75;
            this.table.Columns.Add(colTX2);

            DataGridViewTextBoxColumn colTX3 = new DataGridViewTextBoxColumn();
            colTX3.DataPropertyName = "DiemThuongXuyen3";
            colTX3.HeaderText = "Điểm TX3";
            colTX3.Width = 75;
            this.table.Columns.Add(colTX3);

            DataGridViewTextBoxColumn colGK = new DataGridViewTextBoxColumn();
            colGK.DataPropertyName = "DiemGiuaKi";
            colGK.HeaderText = "Điểm GK";
            colGK.Width = 75;
            this.table.Columns.Add(colGK);

            DataGridViewTextBoxColumn colCK = new DataGridViewTextBoxColumn();
            colCK.DataPropertyName = "DiemCuoiKi";
            colCK.HeaderText = "Điểm CK";
            colCK.Width = 75;
            this.table.Columns.Add(colCK);

            this.table.AutoGenerateColumns = false; //Ngan khong tao them dong moi
            this.table.AllowUserToAddRows = false; //Ngan them du lieu bang cach bam vao bang
            this.table.ReadOnly = true;            // Che do chi doc phai chinh sua quan form
            this.table.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Chon ca dong
            this.table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.table.RowHeadersVisible = false;
        }
        public void themSinhVienVaoTable(BindingList<SinhVien> ds)
        {
            this.table.DataSource = ds;
        }
    }
}
