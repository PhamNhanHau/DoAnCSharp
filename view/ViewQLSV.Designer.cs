namespace DoAnCSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            SuspendLayout();
            // 
            // labelQueQuan
            // 
            labelQueQuan.AutoSize = true;
            labelQueQuan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelQueQuan.Location = new Point(12, 45);
            labelQueQuan.Name = "labelQueQuan";
            labelQueQuan.Size = new Size(117, 31);
            labelQueQuan.TabIndex = 0;
            labelQueQuan.Text = "Quê Quán";
            labelQueQuan.Click += label1_Click;
            // 
            // labelTimKiemSinhVien
            // 
            labelTimKiemSinhVien.AutoSize = true;
            labelTimKiemSinhVien.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            labelTimKiemSinhVien.Location = new Point(12, 12);
            labelTimKiemSinhVien.Name = "labelTimKiemSinhVien";
            labelTimKiemSinhVien.Size = new Size(203, 31);
            labelTimKiemSinhVien.TabIndex = 1;
            labelTimKiemSinhVien.Text = "Tìm kiếm sinh viên";
            labelTimKiemSinhVien.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 806);
            Controls.Add(labelTimKiemSinhVien);
            Controls.Add(labelQueQuan);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelQueQuan;
        private Label labelTimKiemSinhVien;
    }
}
