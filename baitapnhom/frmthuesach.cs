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
    public partial class frmthuesach : Form
    {
        public frmthuesach()
        {
            InitializeComponent();
        }
        public void ketnoi()
        {
            string sql = "select * from thuesach";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblnhanvien = new DataTable();
            adp.Fill(tblnhanvien);
            dataGridView1.DataSource = tblnhanvien;
        }
        private void frmthuesach_Load(object sender, EventArgs e)
        {
            DAO.connect();
            ketnoi();
        }
        int index;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = dataGridView1.CurrentRow.Index;
            txtmathue.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtmakhach.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtmanhanvien.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txtngaythue.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txttiendatcoc.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            txtmathue.ReadOnly = false;
            try
            {
                DAO.connect();
                string sql = "insert into thuesach values('" + txtmathue.Text + "','" + txtmakhach.Text + "','" + txtmanhanvien.Text + "','" + txtngaythue.Text + "','" + txttiendatcoc.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.ExecuteNonQuery();
                ketnoi();
                MessageBox.Show("bạn lưu thành công");
            }
            catch
            {
                MessageBox.Show("không lưu được vì trùng mã hoặc chưa điền đủ thông tin");
                txtmakhach.Clear();
                txtmathue.Clear();
                txtmanhanvien.Clear();
                txtngaythue.Clear();
                txttiendatcoc.Clear();
            }
            finally
            {
                DAO.connect();
            }
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            txtmathue.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtmakhach.Text = "";
            txtmathue.Text = "";
            txtmanhanvien.Text = "";
            txtngaythue.Text = "";
            txttiendatcoc.Text = "";
            txtmathue.Enabled = true;
            txtmathue.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtmathue.ReadOnly = true;
            DAO.connect();
            string sql = "update thuesach set tiendatcoc='" + txttiendatcoc.Text + "',makhach='" + txtmakhach.Text + "',manhanvien='" + txtmanhanvien.Text + "',ngaythue='" + txtngaythue.Text + "' where mathue='" + txtmathue.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            ketnoi();
            btnHuy.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmathue.TextLength == 0)
            {
                MessageBox.Show("bạn chưa chọn dòng xóa");
            }
            txtmathue.ReadOnly = false;
            DAO.connect();
            string sql = "delete thuesach where mathue='" + txtmathue.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            ketnoi();
            txtmakhach.Clear();
            txtmathue.Clear();
            txtmanhanvien.Clear();
            txtngaythue.Clear();
            txttiendatcoc.Clear();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtmakhach.Text = "";
            txtmathue.Text = "";
            txtmanhanvien.Text = "";
            txttiendatcoc.Text = "";
            txtngaythue.Text = "";
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtmathue.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
