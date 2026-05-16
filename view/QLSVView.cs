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
        private void labelMaSinhVien_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBoxMaSinhVienThem_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMaSinhVienThem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonChinhSua_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void radioButtonNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBoxQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
