﻿
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
            this.TenNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MaNXB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Thoat = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TenNXB
            // 
            this.TenNXB.Location = new System.Drawing.Point(390, 247);
            this.TenNXB.Name = "TenNXB";
            this.TenNXB.Size = new System.Drawing.Size(100, 22);
            this.TenNXB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên NXB";
            // 
            // MaNXB
            // 
            this.MaNXB.Location = new System.Drawing.Point(390, 181);
            this.MaNXB.Name = "MaNXB";
            this.MaNXB.Size = new System.Drawing.Size(100, 22);
            this.MaNXB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã NXB";
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(312, 295);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 6;
            this.Thoat.Text = "Thoat";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(461, 295);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 7;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // ThemNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.TenNXB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaNXB);
            this.Controls.Add(this.label1);
            this.Name = "ThemNXB";
            this.Text = "ThemNXB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TenNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MaNXB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button OK;
    }
}