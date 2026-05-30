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

            dsTinh = Tinh.getDSTinh();

            //Gan qua bindingSource rieng tranh cung du lieu
            this.comboBoxQueQuan.DataSource = new BindingSource(dsTinh, null);
            this.comboBoxQueQuan.DisplayMember = "TenTinh"; //Thuoc tinh hien thi
            this.comboBoxQueQuan.ValueMember = "MaTinh";    //Thuoc tinh gia tri


            this.comboBoxQueQuanThem.DataSource = new BindingSource(dsTinh, null);
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
        public void xoaFormTimKiem()
        {
            this.textBoxMaSinhVien.Text = string.Empty;
            this.comboBoxQueQuan.SelectedIndex = 0;
        }
        public void batButtonThem()
        {
            buttonThem.BackColor = Color.LightGreen;
            buttonChinhSua.BackColor = SystemColors.Control;
            buttonXoa.BackColor = SystemColors.Control;
        }
        public void batButtonChinhSua()
        {
            buttonChinhSua.BackColor = Color.LightGreen;
            buttonThem.BackColor = SystemColors.Control;
            buttonXoa.BackColor = SystemColors.Control;
        }
        public void batButtonXoa()
        {
            buttonXoa.BackColor = Color.LightGreen;
            buttonThem.BackColor = SystemColors.Control;
            buttonChinhSua.BackColor = SystemColors.Control;
        }
        public void batButtonLuu()
        {
            if (buttonThem.BackColor == Color.LightGreen)
            {
                buttonChinhSua.BackColor = SystemColors.Control;
                buttonXoa.BackColor = SystemColors.Control;
            }
            else if (buttonChinhSua.BackColor == Color.LightGreen)
            {
                buttonThem.BackColor = SystemColors.Control;
                buttonXoa.BackColor = SystemColors.Control;
            }
            else
            {
                buttonThem.BackColor = SystemColors.Control;
                buttonChinhSua.BackColor = SystemColors.Control;
            }
        }
        public void batButtonHuyBo()
        {
            buttonChinhSua.BackColor = SystemColors.Control;
            buttonThem.BackColor = SystemColors.Control;
            buttonXoa.BackColor = SystemColors.Control;
        }
        public void batButtonTimKiem()
        {
            buttonTim.BackColor = Color.LightGreen;
        }
        public void batButtonHuyTim()
        {
            buttonTim.BackColor = SystemColors.Control;
        }
        public void capNhatDulieuVaoDataGridView()
        {
            //Khoi tao du lieu cho DataGridView
            this.table.Columns.Clear();

            DataGridViewTextBoxColumn colMaSV = new DataGridViewTextBoxColumn();
            colMaSV.DataPropertyName = "MaSinhVien"; //ten bien tren class model
            colMaSV.HeaderText = "Mã Sinh Viên";     //ten tieu de hien thi tren luoi
            colMaSV.Width = 120;                     //kich thuoc
            this.table.Columns.Add(colMaSV);

            DataGridViewTextBoxColumn colHoTen = new DataGridViewTextBoxColumn();
            colHoTen.DataPropertyName = "TenSinhVien";
            colHoTen.HeaderText = "Họ và Tên";
            colHoTen.Width = 218;
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
            colTX1.Width = 70;
            this.table.Columns.Add(colTX1);

            DataGridViewTextBoxColumn colTX2 = new DataGridViewTextBoxColumn();
            colTX2.DataPropertyName = "DiemThuongXuyen2";
            colTX2.HeaderText = "Điểm TX2";
            colTX2.Width = 70;
            this.table.Columns.Add(colTX2);

            DataGridViewTextBoxColumn colTX3 = new DataGridViewTextBoxColumn();
            colTX3.DataPropertyName = "DiemThuongXuyen3";
            colTX3.HeaderText = "Điểm TX3";
            colTX3.Width = 70;
            this.table.Columns.Add(colTX3);

            DataGridViewTextBoxColumn colGK = new DataGridViewTextBoxColumn();
            colGK.DataPropertyName = "DiemGiuaKi";
            colGK.HeaderText = "Điểm GK";
            colGK.Width = 70;
            this.table.Columns.Add(colGK);

            DataGridViewTextBoxColumn colCK = new DataGridViewTextBoxColumn();
            colCK.DataPropertyName = "DiemCuoiKi";
            colCK.HeaderText = "Điểm CK";
            colCK.Width = 70;
            this.table.Columns.Add(colCK);

            this.table.AutoGenerateColumns = false; //Ngan khong tao them dong moi
            this.table.AllowUserToAddRows = false; //Ngan them du lieu bang cach bam vao bang
            this.table.ReadOnly = true;            // Che do chi doc phai chinh sua quan form
            this.table.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Chon ca dong
            //this.table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //this.table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //Can giua cho du lieu trong data grid view
            this.table.EnableHeadersVisualStyles = false;
            this.table.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.table.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            this.table.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.table.RowHeadersVisible = false;
        }
        //Ham sua cot gioi tinh va que quan
        private void table_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.Value != null)
            {
                string valStr = e.Value.ToString().Trim().ToLower();

                if (valStr == "true" || valStr == "nam")
                {
                    e.Value = "Nam";
                }
                else
                {
                    e.Value = "Nữ";
                }
                e.FormattingApplied = true;
            }
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                string fullString = e.Value.ToString();
                e.Value = fullString;
                e.FormattingApplied = true;
            }
        }
        //Ham lay du lieu khi nhan vao mot hang
        private void table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            this.xoaFormThongTin();
            //lay dong dang chon
            DataGridViewRow row = this.table.Rows[e.RowIndex];
            //ma sinh vien ho ten
            this.textBoxMaSinhVienThem.Text = row.Cells[0].Value?.ToString();
            this.textBoxHoVaTen.Text = row.Cells[1].Value?.ToString();
            //Gioi tinh
            string gioiTinh = row.Cells[2].Value?.ToString();
            if (gioiTinh == "True")
            {
                this.radioButtonNam.Checked = true;
            }
            else
            {
                this.radioButtonNu.Checked = true;
            }
            //Que quan
            if (row.Cells[3].Value != null)
            {
                this.comboBoxQueQuanThem.Text = row.Cells[3].Value.ToString();
            }

            //Ngay sinh
            string ngaySinhFull = row.Cells[4].Value?.ToString();

            if (!string.IsNullOrEmpty(ngaySinhFull))
            {
                string ngaySinhStr = ngaySinhFull.Split(' ')[0].Trim();
                string[] mangNgaySinh = ngaySinhStr.Split('/');
                if (mangNgaySinh.Length == 3)
                {
                    this.textBoxNgay.Text = mangNgaySinh[0];
                    this.textBoxThang.Text = mangNgaySinh[1];
                    this.textBoxNam.Text = mangNgaySinh[2];
                }
            }

            //Diem so
            this.textBoxDiemThuongXuyen1.Text = row.Cells[5].Value?.ToString();
            this.textBoxDiemThuongXuyen2.Text = row.Cells[6].Value?.ToString();
            this.textBoxDiemThuongXuyen3.Text = row.Cells[7].Value?.ToString();
            this.textBoxDiemGiuaKi.Text = row.Cells[8].Value?.ToString();
            this.textBoxDiemCuoiKi.Text = row.Cells[9].Value?.ToString();
        }
        //thong tin trong khi them vao danh sach
        public void kiemTraThongTinTrong()
        {
            if (
            (this.radioButtonNam.Checked == false && this.radioButtonNu.Checked == false)
            || string.IsNullOrWhiteSpace(this.textBoxMaSinhVienThem.Text)
            || string.IsNullOrWhiteSpace(this.textBoxHoVaTen.Text)
            || string.IsNullOrWhiteSpace(this.textBoxNgay.Text)
            || string.IsNullOrWhiteSpace(this.textBoxThang.Text)
            || string.IsNullOrWhiteSpace(this.textBoxNam.Text)
            || string.IsNullOrWhiteSpace(this.textBoxDiemThuongXuyen1.Text)
            || string.IsNullOrWhiteSpace(this.textBoxDiemThuongXuyen2.Text)
            || string.IsNullOrWhiteSpace(this.textBoxDiemThuongXuyen3.Text)
            || string.IsNullOrWhiteSpace(this.textBoxDiemGiuaKi.Text)
            || string.IsNullOrWhiteSpace(this.textBoxDiemCuoiKi.Text))
            {
                throw new Exception("Chưa điền hết thông tin");
            }
        }
    }
}
