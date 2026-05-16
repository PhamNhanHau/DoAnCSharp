using DoAnCSharp.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DoAnCSharp
{
    internal class QLSVController 
    {
        private QLSVView viewQLSV;
        private QLSVModel modelQLSV;
        public QLSVController(QLSVView view)
        {
            this.viewQLSV = view;
            this.modelQLSV = new QLSVModel();
            // Controller Khoi chay du lieu
            LoadInitialData();
            this.viewQLSV.buttonThem.Click += nhanNutThem;
        }
        private void LoadInitialData()
        {
            //Khoi tao du lieu cho comboBox
            List<Tinh> dsTinh = Tinh.getDSTinh();
            viewQLSV.capNhatDuLieuTinhVaoCBBQueQuan(dsTinh);
        }
        private void nhanNutThem(object sender, EventArgs e)
        {
            this.viewQLSV.xoaFormThongTin();
            this.viewQLSV.batButtonThem();
        }
    }
}
