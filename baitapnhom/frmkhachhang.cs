using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitapnhom
{
    public partial class frmkhachhang : Form
    {
        DataTable tblKH;
        public frmkhachhang()
        {
            InitializeComponent();
        }

        private void hienthi()
        {
            string sql = "select * from khachhang";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblsachtruyen = new DataTable();
            adp.Fill(tblsachtruyen);
            dataGridView1.DataSource = tblsachtruyen;
        }
        private void frmkhachhang_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmakhach.Text = dataGridView1.CurrentRow.Cells["makhach"].Value.ToString();
            txttenkhach.Text = dataGridView1.CurrentRow.Cells["tenkhach"].Value.ToString();
            txtngaysinh.Text = dataGridView1.CurrentRow.Cells["ngaysinh"].Value.ToString();
            txtgioitinh.Text = dataGridView1.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txtmakhach.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtmakhach.Enabled = true;
            txtmakhach.Focus();

        }
        private void ResetValues()
        {
            txtmakhach.Text = "";
            txttenkhach.Text = "";
            txtngaysinh.Text = "";
            txtgioitinh.Text = "";
            txtdiachi.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtmakhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhach.Focus();
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtngaysinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txttenkhach.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập giới tính", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            if (txtdiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenkhach.Focus();
                return;
            }
            sql = "SELECT makhach FROM khachhang WHERE makhach=N'" +
txtmakhach.Text.Trim() + "'";
            if (DAO.CheckKey(sql))
            {
                MessageBox.Show("Mã khách này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmakhach.Focus();
                txtmakhach.Text = "";
                return;
            }
            sql = "INSERT INTO khachhang(makhach,tenkhach,ngaysinh,gioitinh,diachi) VALUES(N'" +txtmakhach.Text + "',N'" + txttenkhach.Text + "',N'" + txtngaysinh.Text + "',N'" + txtgioitinh.Text + "',N'" + txtdiachi.Text + "')";
            DAO.RunSql(sql);
            hienthi();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtmakhach.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM khachhang";
            tblKH = DAO.GetDataToTable(sql1);
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (txtmakhach.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txttenkhach.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập tên khách", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenkhach.Focus();
                    return;
                }
                if (txtngaysinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenkhach.Focus();
                    return;
                }
                if (txtgioitinh.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập giới tính", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenkhach.Focus();
                    return;
                }
                if (txtdiachi.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txttenkhach.Focus();
                    return;
                }
            }
            sql = "UPDATE khachhang SET tenkhach=N'" + txttenkhach.Text.ToString() + "',ngaysinh=N'" + txtngaysinh.Text.ToString() + "',gioitinh=N'" + txtgioitinh.Text.ToString() + "',diachi=N'" + txtdiachi.Text.ToString() + "' WHERE makhach=N'" + txtmakhach.Text + "'";
            DAO.RunSql(sql);
            hienthi();
            ResetValues();
            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql1;
            sql1 = "SELECT * FROM khachhang";
            tblKH = DAO.GetDataToTable(sql1);
            string sql;
            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,
MessageBoxIcon.Information);
                return;
            }
            if (txtmakhach.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE khachhang WHERE makhach=N'" + txtmakhach.Text + "'";
                DAO.RunSqlDel(sql);
                hienthi();
                ResetValues();
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtmakhach.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void hienthitimkiem()
        {
            string sql = "select * from khachhang where makhach like '%" + txttimkiem.Text + "%' or tenkhach like '%" + txttimkiem.Text + "%' ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblsachtruyen = new DataTable();
            adp.Fill(tblsachtruyen);
            dataGridView1.DataSource = tblsachtruyen;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthitimkiem();
        }
    }
}
        