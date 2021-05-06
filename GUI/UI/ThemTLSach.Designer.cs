
namespace GUI
{
    partial class ThemTLSach
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
            this.MaLS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenLS = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sách";
            // 
            // MaLS
            // 
            this.MaLS.Location = new System.Drawing.Point(314, 97);
            this.MaLS.Name = "MaLS";
            this.MaLS.Size = new System.Drawing.Size(100, 22);
            this.MaLS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sách";
            // 
            // TenLS
            // 
            this.TenLS.Location = new System.Drawing.Point(314, 163);
            this.TenLS.Name = "TenLS";
            this.TenLS.Size = new System.Drawing.Size(100, 22);
            this.TenLS.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(356, 218);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(207, 218);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 2;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // ThemTLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.TenLS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaLS);
            this.Controls.Add(this.label1);
            this.Name = "ThemTLSach";
            this.Text = "ThemTLSach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaLS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenLS;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Thoat;
    }
}