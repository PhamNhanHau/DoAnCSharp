using DoAnCSharp.Models;
using DoAnCSharp.view;

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
        public void capNhatTable(List<SinhVien> danhSach)
        {
            table.DataSource = null;
            table.DataSource = danhSach;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            table.ReadOnly = true;
        }
    }
}
