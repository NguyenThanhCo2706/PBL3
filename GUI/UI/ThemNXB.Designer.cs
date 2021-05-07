
namespace GUI
{
    partial class ThemNXB
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MaNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenNXB = new System.Windows.Forms.TextBox();
            this.OK = new FontAwesome.Sharp.IconButton();
            this.Thoat = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OK);
            this.groupBox1.Controls.Add(this.Thoat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MaNXB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TenNXB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 307);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà xuất bản :";
            // 
            // MaNXB
            // 
            this.MaNXB.Location = new System.Drawing.Point(199, 93);
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Size = new System.Drawing.Size(147, 27);
            this.MaNXB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà xuất bản :";
            // 
            // TenNXB
            // 
            this.TenNXB.Location = new System.Drawing.Point(199, 148);
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.Size = new System.Drawing.Size(147, 27);
            this.TenNXB.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.OK.IconColor = System.Drawing.Color.Blue;
            this.OK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OK.IconSize = 20;
            this.OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK.Location = new System.Drawing.Point(291, 238);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 34);
            this.OK.TabIndex = 37;
            this.OK.Text = "Xác nhận";
            this.OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OK.UseVisualStyleBackColor = false;
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Thoat.IconColor = System.Drawing.Color.Red;
            this.Thoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Thoat.IconSize = 25;
            this.Thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Thoat.Location = new System.Drawing.Point(36, 238);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(110, 34);
            this.Thoat.TabIndex = 36;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thoat.UseVisualStyleBackColor = false;
            // 
            // ThemNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 332);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemNXB";
            this.Text = "ThemNXB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenNXB;
        private FontAwesome.Sharp.IconButton OK;
        private FontAwesome.Sharp.IconButton Thoat;
    }
}