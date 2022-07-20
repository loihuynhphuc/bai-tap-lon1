namespace QL_VTXD
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hethongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangnhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taikhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doimatkhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taotaikhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HanghoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phieunhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rpphieunhapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rphoadonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_hienthi = new System.Windows.Forms.Label();
            this.hoadonXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hethongToolStripMenuItem,
            this.taikhoanToolStripMenuItem,
            this.HanghoaToolStripMenuItem,
            this.thongkeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(751, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hethongToolStripMenuItem
            // 
            this.hethongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dangnhapToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hethongToolStripMenuItem.Name = "hethongToolStripMenuItem";
            this.hethongToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.hethongToolStripMenuItem.Text = "Hệ thống";
            this.hethongToolStripMenuItem.Click += new System.EventHandler(this.hethongToolStripMenuItem_Click);
            // 
            // dangnhapToolStripMenuItem
            // 
            this.dangnhapToolStripMenuItem.Name = "dangnhapToolStripMenuItem";
            this.dangnhapToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.dangnhapToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.dangnhapToolStripMenuItem.Text = "Đăng nhập";
            this.dangnhapToolStripMenuItem.Click += new System.EventHandler(this.dangnhapToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(231, 30);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // taikhoanToolStripMenuItem
            // 
            this.taikhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doimatkhauToolStripMenuItem,
            this.taotaikhoanToolStripMenuItem});
            this.taikhoanToolStripMenuItem.Name = "taikhoanToolStripMenuItem";
            this.taikhoanToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.taikhoanToolStripMenuItem.Text = "Tài khoản";
            this.taikhoanToolStripMenuItem.Click += new System.EventHandler(this.taikhoanToolStripMenuItem_Click);
            // 
            // doimatkhauToolStripMenuItem
            // 
            this.doimatkhauToolStripMenuItem.Name = "doimatkhauToolStripMenuItem";
            this.doimatkhauToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.doimatkhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doimatkhauToolStripMenuItem.Click += new System.EventHandler(this.doimatkhauToolStripMenuItem_Click_1);
            // 
            // taotaikhoanToolStripMenuItem
            // 
            this.taotaikhoanToolStripMenuItem.Name = "taotaikhoanToolStripMenuItem";
            this.taotaikhoanToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.taotaikhoanToolStripMenuItem.Text = "Tạo tài khoản";
            this.taotaikhoanToolStripMenuItem.Click += new System.EventHandler(this.taotaikhoanToolStripMenuItem_Click);
            // 
            // HanghoaToolStripMenuItem
            // 
            this.HanghoaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phieunhapToolStripMenuItem,
            this.hoadonToolStripMenuItem});
            this.HanghoaToolStripMenuItem.Name = "HanghoaToolStripMenuItem";
            this.HanghoaToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.HanghoaToolStripMenuItem.Text = "Hàng hóa";
            // 
            // phieunhapToolStripMenuItem
            // 
            this.phieunhapToolStripMenuItem.Name = "phieunhapToolStripMenuItem";
            this.phieunhapToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.phieunhapToolStripMenuItem.Text = "Phiếu Nhập";
            this.phieunhapToolStripMenuItem.Click += new System.EventHandler(this.phieunhapToolStripMenuItem_Click);
            // 
            // hoadonToolStripMenuItem
            // 
            this.hoadonToolStripMenuItem.Name = "hoadonToolStripMenuItem";
            this.hoadonToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.hoadonToolStripMenuItem.Text = "Hóa Đơn";
            this.hoadonToolStripMenuItem.Click += new System.EventHandler(this.hoadonToolStripMenuItem_Click);
            // 
            // thongkeToolStripMenuItem
            // 
            this.thongkeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rpphieunhapToolStripMenuItem,
            this.rphoadonToolStripMenuItem,
            this.hoadonXuấtToolStripMenuItem});
            this.thongkeToolStripMenuItem.Name = "thongkeToolStripMenuItem";
            this.thongkeToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.thongkeToolStripMenuItem.Text = "Thống kê";
            // 
            // rpphieunhapToolStripMenuItem
            // 
            this.rpphieunhapToolStripMenuItem.Name = "rpphieunhapToolStripMenuItem";
            this.rpphieunhapToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.rpphieunhapToolStripMenuItem.Text = "Phiếu Nhập";
            this.rpphieunhapToolStripMenuItem.Click += new System.EventHandler(this.rpphieunhapToolStripMenuItem_Click);
            // 
            // rphoadonToolStripMenuItem
            // 
            this.rphoadonToolStripMenuItem.Name = "rphoadonToolStripMenuItem";
            this.rphoadonToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.rphoadonToolStripMenuItem.Text = "Hóa Đơn";
            this.rphoadonToolStripMenuItem.Click += new System.EventHandler(this.rphoadonToolStripMenuItem_Click);
            // 
            // lb_hienthi
            // 
            this.lb_hienthi.AutoSize = true;
            this.lb_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hienthi.ForeColor = System.Drawing.Color.Blue;
            this.lb_hienthi.Location = new System.Drawing.Point(226, 62);
            this.lb_hienthi.Name = "lb_hienthi";
            this.lb_hienthi.Size = new System.Drawing.Size(0, 32);
            this.lb_hienthi.TabIndex = 1;
            // 
            // hoadonXuấtToolStripMenuItem
            // 
            this.hoadonXuấtToolStripMenuItem.Name = "hoadonXuấtToolStripMenuItem";
            this.hoadonXuấtToolStripMenuItem.Size = new System.Drawing.Size(197, 30);
            this.hoadonXuấtToolStripMenuItem.Text = "Hóa Đơn Xuất";
            this.hoadonXuấtToolStripMenuItem.Click += new System.EventHandler(this.hoadonXuấtToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(751, 443);
            this.Controls.Add(this.lb_hienthi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hethongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangnhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkeToolStripMenuItem;
        private System.Windows.Forms.Label lb_hienthi;
        private System.Windows.Forms.ToolStripMenuItem taikhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doimatkhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taotaikhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HanghoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phieunhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoadonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rpphieunhapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rphoadonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hoadonXuấtToolStripMenuItem;
    }
}

