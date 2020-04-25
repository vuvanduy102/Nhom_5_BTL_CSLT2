namespace baitapnhom
{
    partial class frmViPham
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
            this.txtMaViPham = new System.Windows.Forms.TextBox();
            this.dataGridView_ViPham = new System.Windows.Forms.DataGridView();
            this.mavipham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenvipham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenViPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vi phạm";
            // 
            // txtMaViPham
            // 
            this.txtMaViPham.Location = new System.Drawing.Point(100, 13);
            this.txtMaViPham.Name = "txtMaViPham";
            this.txtMaViPham.Size = new System.Drawing.Size(100, 20);
            this.txtMaViPham.TabIndex = 1;
            // 
            // dataGridView_ViPham
            // 
            this.dataGridView_ViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ViPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mavipham,
            this.tenvipham,
            this.tienphat});
            this.dataGridView_ViPham.Location = new System.Drawing.Point(3, 99);
            this.dataGridView_ViPham.Name = "dataGridView_ViPham";
            this.dataGridView_ViPham.Size = new System.Drawing.Size(423, 95);
            this.dataGridView_ViPham.TabIndex = 2;
            this.dataGridView_ViPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ViPham_CellClick);
            // 
            // mavipham
            // 
            this.mavipham.DataPropertyName = "mavipham";
            this.mavipham.HeaderText = "Mã vi phạm";
            this.mavipham.Name = "mavipham";
            // 
            // tenvipham
            // 
            this.tenvipham.DataPropertyName = "tenvipham";
            this.tenvipham.HeaderText = "Tên vi phạm";
            this.tenvipham.Name = "tenvipham";
            // 
            // tienphat
            // 
            this.tienphat.DataPropertyName = "tienphat";
            this.tienphat.HeaderText = "Tiền phạt";
            this.tienphat.Name = "tienphat";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(41, 223);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.Location = new System.Drawing.Point(326, 32);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(100, 20);
            this.txtTienPhat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiền phạt";
            // 
            // txtTenViPham
            // 
            this.txtTenViPham.Location = new System.Drawing.Point(100, 61);
            this.txtTenViPham.Name = "txtTenViPham";
            this.txtTenViPham.Size = new System.Drawing.Size(100, 20);
            this.txtTenViPham.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên vi phạm";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(155, 223);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(248, 223);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(338, 223);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(434, 223);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 11;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(543, 223);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 285);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTenViPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTienPhat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView_ViPham);
            this.Controls.Add(this.txtMaViPham);
            this.Controls.Add(this.label1);
            this.Name = "frmViPham";
            this.Text = "Vi phạm";
            this.Load += new System.EventHandler(this.frmViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ViPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaViPham;
        private System.Windows.Forms.DataGridView dataGridView_ViPham;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenViPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn mavipham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenvipham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienphat;
    }
}