namespace baitapnhom
{
    partial class frmtinhtrang
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnlammoi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView_Formtinhtrang = new System.Windows.Forms.DataGridView();
            this.matinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tentinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttentinhtrang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmatinhtrang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Formtinhtrang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(465, 243);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 26;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnlammoi
            // 
            this.btnlammoi.Location = new System.Drawing.Point(350, 243);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.Size = new System.Drawing.Size(75, 23);
            this.btnlammoi.TabIndex = 25;
            this.btnlammoi.Text = "Làm mới";
            this.btnlammoi.UseVisualStyleBackColor = true;
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(145, 243);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(45, 243);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView_Formtinhtrang
            // 
            this.dataGridView_Formtinhtrang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Formtinhtrang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matinhtrang,
            this.tentinhtrang});
            this.dataGridView_Formtinhtrang.Location = new System.Drawing.Point(315, 32);
            this.dataGridView_Formtinhtrang.Name = "dataGridView_Formtinhtrang";
            this.dataGridView_Formtinhtrang.Size = new System.Drawing.Size(245, 193);
            this.dataGridView_Formtinhtrang.TabIndex = 22;
            this.dataGridView_Formtinhtrang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Formtinhtrang_CellClick);
            // 
            // matinhtrang
            // 
            this.matinhtrang.DataPropertyName = "matinhtrang";
            this.matinhtrang.HeaderText = "Mã Tình Trạng";
            this.matinhtrang.Name = "matinhtrang";
            // 
            // tentinhtrang
            // 
            this.tentinhtrang.DataPropertyName = "tentinhtrang";
            this.tentinhtrang.HeaderText = "Tên Tình Trạng";
            this.tentinhtrang.Name = "tentinhtrang";
            // 
            // txttentinhtrang
            // 
            this.txttentinhtrang.Location = new System.Drawing.Point(145, 75);
            this.txttentinhtrang.Name = "txttentinhtrang";
            this.txttentinhtrang.Size = new System.Drawing.Size(100, 20);
            this.txttentinhtrang.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên Tình Trạng";
            // 
            // txtmatinhtrang
            // 
            this.txtmatinhtrang.Location = new System.Drawing.Point(145, 32);
            this.txtmatinhtrang.Name = "txtmatinhtrang";
            this.txtmatinhtrang.Size = new System.Drawing.Size(100, 20);
            this.txtmatinhtrang.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã Tình Trạng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmtinhtrang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView_Formtinhtrang);
            this.Controls.Add(this.txttentinhtrang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatinhtrang);
            this.Controls.Add(this.label1);
            this.Name = "frmtinhtrang";
            this.Text = "frmtinhtrang";
            this.Load += new System.EventHandler(this.frmtinhtrang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Formtinhtrang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnlammoi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView_Formtinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn matinhtrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tentinhtrang;
        private System.Windows.Forms.TextBox txttentinhtrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmatinhtrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}