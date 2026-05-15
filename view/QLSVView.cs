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
        private void themDuLieuVaoHaiCBB(object sender, EventArgs e)
        {
   
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

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
    }
}
