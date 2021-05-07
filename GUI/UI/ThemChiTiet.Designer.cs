
namespace GUI
{
    partial class ThemChiTiet
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.GiaNhap = new System.Windows.Forms.TextBox();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.ThemSach = new System.Windows.Forms.Button();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            this.cbbMaDonNhap = new System.Windows.Forms.ComboBox();
            this.Thoat = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.ThemHoaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(279, 49);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 22);
            this.Id.TabIndex = 1;
            // 
            // GiaNhap
            // 
            this.GiaNhap.Location = new System.Drawing.Point(270, 196);
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.Size = new System.Drawing.Size(100, 22);
            this.GiaNhap.TabIndex = 1;
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(270, 242);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(100, 22);
            this.SoLuong.TabIndex = 1;
            // 
            // ThemSach
            // 
            this.ThemSach.Location = new System.Drawing.Point(427, 134);
            this.ThemSach.Name = "ThemSach";
            this.ThemSach.Size = new System.Drawing.Size(75, 23);
            this.ThemSach.TabIndex = 2;
            this.ThemSach.Text = "Thêm sách";
            this.ThemSach.UseVisualStyleBackColor = true;
            this.ThemSach.Click += new System.EventHandler(this.ThemSach_Click);
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(279, 132);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(121, 24);
            this.cbbMaSach.TabIndex = 3;
            // 
            // cbbMaDonNhap
            // 
            this.cbbMaDonNhap.FormattingEnabled = true;
            this.cbbMaDonNhap.Location = new System.Drawing.Point(279, 89);
            this.cbbMaDonNhap.Name = "cbbMaDonNhap";
            this.cbbMaDonNhap.Size = new System.Drawing.Size(121, 24);
            this.cbbMaDonNhap.TabIndex = 3;
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(155, 303);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 10;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(304, 303);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 11;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ThemHoaDon
            // 
            this.ThemHoaDon.Location = new System.Drawing.Point(427, 89);
            this.ThemHoaDon.Name = "ThemHoaDon";
            this.ThemHoaDon.Size = new System.Drawing.Size(113, 23);
            this.ThemHoaDon.TabIndex = 47;
            this.ThemHoaDon.Text = "ThemHoaDon";
            this.ThemHoaDon.UseVisualStyleBackColor = true;
            this.ThemHoaDon.Click += new System.EventHandler(this.ThemHoaDon_Click);
            // 
            // ThemChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ThemHoaDon);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.cbbMaDonNhap);
            this.Controls.Add(this.cbbMaSach);
            this.Controls.Add(this.ThemSach);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.GiaNhap);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemChiTiet";
            this.Text = "ThemChiTiet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox GiaNhap;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Button ThemSach;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private System.Windows.Forms.ComboBox cbbMaDonNhap;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button ThemHoaDon;
    }
}