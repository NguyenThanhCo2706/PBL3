
namespace GUI
{
    partial class QuanLy
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLDT = new FontAwesome.Sharp.IconButton();
            this.btnQLKS = new FontAwesome.Sharp.IconButton();
            this.btnQLNV = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnQLDT);
            this.panelMenu.Controls.Add(this.btnQLKS);
            this.panelMenu.Controls.Add(this.btnQLNV);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 803);
            this.panelMenu.TabIndex = 48;
            // 
            // btnQLDT
            // 
            this.btnQLDT.FlatAppearance.BorderSize = 0;
            this.btnQLDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDT.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQLDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDT.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLDT.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnQLDT.IconColor = System.Drawing.Color.White;
            this.btnQLDT.IconSize = 35;
            this.btnQLDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDT.Location = new System.Drawing.Point(3, 307);
            this.btnQLDT.Name = "btnQLDT";
            this.btnQLDT.Rotation = 0D;
            this.btnQLDT.Size = new System.Drawing.Size(235, 65);
            this.btnQLDT.TabIndex = 1;
            this.btnQLDT.Text = "Quản lý doanh thu";
            this.btnQLDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDT.UseVisualStyleBackColor = true;
            this.btnQLDT.Click += new System.EventHandler(this.btnQLDT_Click);
            // 
            // btnQLKS
            // 
            this.btnQLKS.FlatAppearance.BorderSize = 0;
            this.btnQLKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKS.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQLKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLKS.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnQLKS.IconColor = System.Drawing.Color.White;
            this.btnQLKS.IconSize = 35;
            this.btnQLKS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKS.Location = new System.Drawing.Point(3, 235);
            this.btnQLKS.Name = "btnQLKS";
            this.btnQLKS.Rotation = 0D;
            this.btnQLKS.Size = new System.Drawing.Size(235, 65);
            this.btnQLKS.TabIndex = 1;
            this.btnQLKS.Text = "Quản lý kho sách";
            this.btnQLKS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKS.UseVisualStyleBackColor = true;
            this.btnQLKS.Click += new System.EventHandler(this.btnQLKS_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLNV.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnQLNV.IconColor = System.Drawing.Color.White;
            this.btnQLNV.IconSize = 35;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 165);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Rotation = 0D;
            this.btnQLNV.Size = new System.Drawing.Size(238, 65);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Location = new System.Drawing.Point(0, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(238, 161);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            //this.btnHome.Image = global::UIUX.Properties.Resources.reading_book__3_;
            this.btnHome.Location = new System.Drawing.Point(50, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(123, 133);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(238, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1444, 70);
            this.panelTitleBar.TabIndex = 49;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(79, 21);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(95, 33);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconSize = 45;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(24, 15);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(45, 49);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(238, 70);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1444, 10);
            this.panelShadow.TabIndex = 50;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(238, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1444, 723);
            this.panelDesktop.TabIndex = 51;
            // 
            // UiUxQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 803);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "UiUxQuanLy";
            this.Text = "UxUiQuanLy";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnQLDT;
        private FontAwesome.Sharp.IconButton btnQLKS;
        private FontAwesome.Sharp.IconButton btnQLNV;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
    }
}