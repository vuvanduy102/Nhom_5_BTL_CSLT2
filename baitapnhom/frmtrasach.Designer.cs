namespace baitapnhom
{
    partial class frmtrasach
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
            this.lblmatra = new System.Windows.Forms.Label();
            this.txtmatra = new System.Windows.Forms.TextBox();
            this.txtmathue = new System.Windows.Forms.TextBox();
            this.lblmathue = new System.Windows.Forms.Label();
            this.txtmanhanvien = new System.Windows.Forms.TextBox();
            this.lblmanhanvien = new System.Windows.Forms.Label();
            this.txtngaytra = new System.Windows.Forms.TextBox();
            this.lblngaytra = new System.Windows.Forms.Label();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.lbltongtien = new System.Windows.Forms.Label();
            this.dataGridView1_trasach = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.matra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhanvien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_trasach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmatra
            // 
            this.lblmatra.AutoSize = true;
            this.lblmatra.Location = new System.Drawing.Point(12, 13);
            this.lblmatra.Name = "lblmatra";
            this.lblmatra.Size = new System.Drawing.Size(37, 13);
            this.lblmatra.TabIndex = 0;
            this.lblmatra.Text = "Mã trả";
            // 
            // txtmatra
            // 
            this.txtmatra.Location = new System.Drawing.Point(64, 10);
            this.txtmatra.Name = "txtmatra";
            this.txtmatra.Size = new System.Drawing.Size(100, 20);
            this.txtmatra.TabIndex = 1;
            // 
            // txtmathue
            // 
            this.txtmathue.Location = new System.Drawing.Point(64, 45);
            this.txtmathue.Name = "txtmathue";
            this.txtmathue.Size = new System.Drawing.Size(100, 20);
            this.txtmathue.TabIndex = 3;
            // 
            // lblmathue
            // 
            this.lblmathue.AutoSize = true;
            this.lblmathue.Location = new System.Drawing.Point(12, 48);
            this.lblmathue.Name = "lblmathue";
            this.lblmathue.Size = new System.Drawing.Size(46, 13);
            this.lblmathue.TabIndex = 2;
            this.lblmathue.Text = "Mã thuê";
            // 
            // txtmanhanvien
            // 
            this.txtmanhanvien.Location = new System.Drawing.Point(271, 10);
            this.txtmanhanvien.Name = "txtmanhanvien";
            this.txtmanhanvien.Size = new System.Drawing.Size(100, 20);
            this.txtmanhanvien.TabIndex = 5;
            // 
            // lblmanhanvien
            // 
            this.lblmanhanvien.AutoSize = true;
            this.lblmanhanvien.Location = new System.Drawing.Point(193, 13);
            this.lblmanhanvien.Name = "lblmanhanvien";
            this.lblmanhanvien.Size = new System.Drawing.Size(72, 13);
            this.lblmanhanvien.TabIndex = 4;
            this.lblmanhanvien.Text = "Mã nhân viên";
            // 
            // txtngaytra
            // 
            this.txtngaytra.Location = new System.Drawing.Point(271, 45);
            this.txtngaytra.Name = "txtngaytra";
            this.txtngaytra.Size = new System.Drawing.Size(100, 20);
            this.txtngaytra.TabIndex = 7;
            // 
            // lblngaytra
            // 
            this.lblngaytra.AutoSize = true;
            this.lblngaytra.Location = new System.Drawing.Point(193, 51);
            this.lblngaytra.Name = "lblngaytra";
            this.lblngaytra.Size = new System.Drawing.Size(47, 13);
            this.lblngaytra.TabIndex = 6;
            this.lblngaytra.Text = "Ngày trả";
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(436, 10);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(100, 20);
            this.txttongtien.TabIndex = 9;
            // 
            // lbltongtien
            // 
            this.lbltongtien.AutoSize = true;
            this.lbltongtien.Location = new System.Drawing.Point(384, 13);
            this.lbltongtien.Name = "lbltongtien";
            this.lbltongtien.Size = new System.Drawing.Size(52, 13);
            this.lbltongtien.TabIndex = 8;
            this.lbltongtien.Text = "Tổng tiền";
            // 
            // dataGridView1_trasach
            // 
            this.dataGridView1_trasach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_trasach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matra,
            this.mathue,
            this.manhanvien,
            this.ngaytra,
            this.tongtien});
            this.dataGridView1_trasach.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1_trasach.Name = "dataGridView1_trasach";
            this.dataGridView1_trasach.Size = new System.Drawing.Size(546, 169);
            this.dataGridView1_trasach.TabIndex = 10;
            this.dataGridView1_trasach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_trasach_CellClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(64, 301);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(153, 301);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(245, 301);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(335, 301);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 14;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(426, 301);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // matra
            // 
            this.matra.DataPropertyName = "matra";
            this.matra.HeaderText = "Mã Trả";
            this.matra.Name = "matra";
            // 
            // mathue
            // 
            this.mathue.DataPropertyName = "mathue";
            this.mathue.HeaderText = "Mã Thuê";
            this.mathue.Name = "mathue";
            // 
            // manhanvien
            // 
            this.manhanvien.DataPropertyName = "manhanvien";
            this.manhanvien.HeaderText = "Mã Nhân Viên";
            this.manhanvien.Name = "manhanvien";
            // 
            // ngaytra
            // 
            this.ngaytra.DataPropertyName = "ngaytra";
            this.ngaytra.HeaderText = "Ngày Trả";
            this.ngaytra.Name = "ngaytra";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // frmtrasach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 334);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.dataGridView1_trasach);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.lbltongtien);
            this.Controls.Add(this.txtngaytra);
            this.Controls.Add(this.lblngaytra);
            this.Controls.Add(this.txtmanhanvien);
            this.Controls.Add(this.lblmanhanvien);
            this.Controls.Add(this.txtmathue);
            this.Controls.Add(this.lblmathue);
            this.Controls.Add(this.txtmatra);
            this.Controls.Add(this.lblmatra);
            this.Name = "frmtrasach";
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.frmtrasach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_trasach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmatra;
        private System.Windows.Forms.TextBox txtmatra;
        private System.Windows.Forms.TextBox txtmathue;
        private System.Windows.Forms.Label lblmathue;
        private System.Windows.Forms.TextBox txtmanhanvien;
        private System.Windows.Forms.Label lblmanhanvien;
        private System.Windows.Forms.TextBox txtngaytra;
        private System.Windows.Forms.Label lblngaytra;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label lbltongtien;
        private System.Windows.Forms.DataGridView dataGridView1_trasach;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn matra;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaytra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
    }
}