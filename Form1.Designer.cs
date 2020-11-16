namespace DeThiHocKi
{
    partial class frmQuanLiNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCongViec = new System.Windows.Forms.ComboBox();
            this.cbThangSinh = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtLuongKetThuc = new System.Windows.Forms.TextBox();
            this.txtLuongBatDau = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCongViec);
            this.groupBox1.Controls.Add(this.cbThangSinh);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.txtLuongKetThuc);
            this.groupBox1.Controls.Add(this.txtLuongBatDau);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1250, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn tiêu chí để tìm";
            // 
            // cbCongViec
            // 
            this.cbCongViec.FormattingEnabled = true;
            this.cbCongViec.Location = new System.Drawing.Point(801, 156);
            this.cbCongViec.Name = "cbCongViec";
            this.cbCongViec.Size = new System.Drawing.Size(195, 28);
            this.cbCongViec.TabIndex = 10;
            // 
            // cbThangSinh
            // 
            this.cbThangSinh.FormattingEnabled = true;
            this.cbThangSinh.Location = new System.Drawing.Point(218, 225);
            this.cbThangSinh.Name = "cbThangSinh";
            this.cbThangSinh.Size = new System.Drawing.Size(195, 28);
            this.cbThangSinh.TabIndex = 9;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Location = new System.Drawing.Point(218, 156);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(195, 28);
            this.cbGioiTinh.TabIndex = 8;
            // 
            // txtLuongKetThuc
            // 
            this.txtLuongKetThuc.Location = new System.Drawing.Point(801, 91);
            this.txtLuongKetThuc.Name = "txtLuongKetThuc";
            this.txtLuongKetThuc.Size = new System.Drawing.Size(195, 28);
            this.txtLuongKetThuc.TabIndex = 7;
            // 
            // txtLuongBatDau
            // 
            this.txtLuongBatDau.Location = new System.Drawing.Point(218, 91);
            this.txtLuongBatDau.Name = "txtLuongBatDau";
            this.txtLuongBatDau.Size = new System.Drawing.Size(195, 28);
            this.txtLuongBatDau.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(810, 250);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(186, 60);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(632, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "CÔNG VIỆC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "ĐẾN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "GIỚI TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "THÁNG SINH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "LƯƠNG TỪ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(25, 452);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1250, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tìm kiếm";
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(91, 53);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowHeadersWidth = 51;
            this.dtgvNhanVien.RowTemplate.Height = 24;
            this.dtgvNhanVien.Size = new System.Drawing.Size(1094, 193);
            this.dtgvNhanVien.TabIndex = 0;
            this.dtgvNhanVien.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNhanVien_CellContentDoubleClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(895, 735);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(294, 54);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLiNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 794);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLiNhanVien";
            this.Text = "QuanLiNhanVien";
            this.Load += new System.EventHandler(this.frmQuanLiNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbCongViec;
        private System.Windows.Forms.ComboBox cbThangSinh;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtLuongKetThuc;
        private System.Windows.Forms.TextBox txtLuongBatDau;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Button btnThoat;
    }
}

