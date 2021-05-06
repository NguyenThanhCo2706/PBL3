
namespace GUI
{
    partial class QLNV
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Xoa = new FontAwesome.Sharp.IconButton();
            this.SapXep = new FontAwesome.Sharp.IconButton();
            this.ChinhSua = new FontAwesome.Sharp.IconButton();
            this.Them = new FontAwesome.Sharp.IconButton();
            this.Xem = new FontAwesome.Sharp.IconButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1142, 490);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "`";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(423, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hiệu Sách ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 363);
            this.dataGridView1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "Danh sách nhân viên :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(942, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 22);
            this.textBox1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(863, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ca làm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ và tên:";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(954, 514);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 39);
            this.comboBox2.TabIndex = 24;
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Xoa.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Xoa.IconColor = System.Drawing.Color.Red;
            this.Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Xoa.IconSize = 20;
            this.Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xoa.Location = new System.Drawing.Point(465, 508);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(100, 60);
            this.Xoa.TabIndex = 25;
            this.Xoa.Text = "Xóa";
            this.Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // SapXep
            // 
            this.SapXep.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SapXep.IconChar = FontAwesome.Sharp.IconChar.Sort;
            this.SapXep.IconColor = System.Drawing.Color.Blue;
            this.SapXep.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SapXep.IconSize = 20;
            this.SapXep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SapXep.Location = new System.Drawing.Point(830, 508);
            this.SapXep.Name = "SapXep";
            this.SapXep.Size = new System.Drawing.Size(100, 60);
            this.SapXep.TabIndex = 25;
            this.SapXep.Text = "Sắp xếp";
            this.SapXep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SapXep.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SapXep.UseVisualStyleBackColor = false;
            this.SapXep.Click += new System.EventHandler(this.SapXep_Click);
            // 
            // ChinhSua
            // 
            this.ChinhSua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChinhSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ChinhSua.IconColor = System.Drawing.Color.Blue;
            this.ChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChinhSua.IconSize = 20;
            this.ChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChinhSua.Location = new System.Drawing.Point(328, 508);
            this.ChinhSua.Name = "ChinhSua";
            this.ChinhSua.Size = new System.Drawing.Size(100, 60);
            this.ChinhSua.TabIndex = 25;
            this.ChinhSua.Text = "Chỉnh sửa";
            this.ChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChinhSua.UseVisualStyleBackColor = false;
            this.ChinhSua.Click += new System.EventHandler(this.ChinhSua_Click);
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Them.IconColor = System.Drawing.Color.Blue;
            this.Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Them.IconSize = 20;
            this.Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Them.Location = new System.Drawing.Point(186, 508);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(100, 60);
            this.Them.TabIndex = 25;
            this.Them.Text = "Thêm";
            this.Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // Xem
            // 
            this.Xem.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Xem.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.Xem.IconColor = System.Drawing.Color.Blue;
            this.Xem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Xem.IconSize = 20;
            this.Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xem.Location = new System.Drawing.Point(44, 508);
            this.Xem.Name = "Xem";
            this.Xem.Size = new System.Drawing.Size(100, 60);
            this.Xem.TabIndex = 25;
            this.Xem.Text = "Xem";
            this.Xem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xem.UseVisualStyleBackColor = false;
            this.Xem.Click += new System.EventHandler(this.Xem_Click);
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1202, 595);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.SapXep);
            this.Controls.Add(this.ChinhSua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.Xem);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "QLNV";
            this.Text = "Quản lý nhân viên";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private FontAwesome.Sharp.IconButton Xem;
        private FontAwesome.Sharp.IconButton Them;
        private FontAwesome.Sharp.IconButton ChinhSua;
        private FontAwesome.Sharp.IconButton Xoa;
        private FontAwesome.Sharp.IconButton SapXep;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}