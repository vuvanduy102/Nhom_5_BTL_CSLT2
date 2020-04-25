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
    public partial class frmViPham : Form
    {
        
        public frmViPham()
        {
            InitializeComponent();
        }
        private void frmViPham_Load(object sender, EventArgs e)
        {
            DAO.connect();

        }
        private void loaddatagridview()
        {
            string sql = "select * from vipham";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tablevipham = new DataTable();
            adp.Fill(tablevipham);
            dataGridView_ViPham.DataSource = tablevipham;
        }
        private void dataGridView_ViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaViPham.Text = dataGridView_ViPham.CurrentRow.Cells["mavipham"].Value.ToString();
            txtTenViPham.Text = dataGridView_ViPham.CurrentRow.Cells["tenvipham"].Value.ToString();
            txtTienPhat.Text = dataGridView_ViPham.CurrentRow.Cells["tienphat"].Value.ToString();
            txtMaViPham.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaViPham.Text = "";
            txtTenViPham.Text = "";
            txtTienPhat.Text = "";
            txtMaViPham.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from vipham where mavipham = '" + txtMaViPham.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            loaddatagridview();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenViPham.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên vi phạm");
                txtTenViPham.Focus();
                return;
               }
            if (txtTienPhat.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tiền phạt");
                txtTienPhat.Focus();
                return;
            }
            else
            {
                string sql = "update vipham set tenvipham=@tenvipham, tienphat=@tienphat where mavipham =@mavipham";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("mavipham", txtMaViPham.Text);
                cmd.Parameters.AddWithValue("tenphong", txtTenViPham.Text);
                cmd.Parameters.AddWithValue("dongia", txtTienPhat.Text);
                cmd.ExecuteNonQuery();
                loaddatagridview();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaViPham.Text == "")
            {
            MessageBox.Show("bạn chưa nhập mã vi phạm");
            txtMaViPham.Focus();
            return;
            }
            if (txtTenViPham.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên vi phạm");
                txtTenViPham.Focus();
                return;
            }
            else
            {
                try
                {
                    string sql = "insert into vipham values ('" + txtMaViPham.Text + "', '" +
                    txtTenViPham.Text + "'";
                    if (txtTienPhat.Text != "")
                    {
                        sql = sql + "," + txtTienPhat.Text.Trim();
                    }
                    sql = sql + ")";
                    MessageBox.Show(sql);
                    DAO.con.Open();
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.ExecuteNonQuery();
                    loaddatagridview();
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            txtMaViPham.Text = "";
            txtTenViPham.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }
    }
}
