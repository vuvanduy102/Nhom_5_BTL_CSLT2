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
    public partial class frmCaLam : Form
    {
        
        public frmCaLam()
        {
            InitializeComponent();
        }

        private void frmCaLam_Load(object sender, EventArgs e)
        {
            DAO.connect();
            loaddatagridview();
        }
        private void loaddatagridview()
        {
            string sql = "select * from calam";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tablecalam = new DataTable();
            adp.Fill(tablecalam);
            dataGridView_CaLam.DataSource = tablecalam;
        }
        private void dataGridView_CaLam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaCa.Text = dataGridView_CaLam.CurrentRow.Cells["maca"].Value.ToString();
            txtTenCa.Text = dataGridView_CaLam.CurrentRow.Cells["tenca"].Value.ToString();
            txtMaCa.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaCa.Text = "";
            txtTenCa.Text = "";
            txtMaCa.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from calam where calam = '" + txtMaCa.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            loaddatagridview();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("chua nhap ten ca");
                txtTenCa.Focus();
                return;
            }
            else
            {
                string sql = "update calam set tenca=@tenca where maca =@maca";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("maca", txtMaCa.Text);
                cmd.Parameters.AddWithValue("tenca", txtTenCa.Text);
                cmd.ExecuteNonQuery();
                loaddatagridview();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaCa.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã ca");
                txtMaCa.Focus();
                return;
            }
            if (txtTenCa.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên ca");
                txtTenCa.Focus();
                return;
            }
            else
            {
                try
                {
                    string sql = "insert into calam values ('" + txtMaCa.Text + "', '" +
                    txtTenCa.Text + "'" + ")";
                    MessageBox.Show(sql);
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            txtMaCa.Text = "";
            txtTenCa.Text = "";
        }

        

    }
}
