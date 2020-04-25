using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace baitapnhom
{
    public partial class frmngonngu : Form
    {
        public frmngonngu()
        {
            InitializeComponent();
        }

        private void frmngonngu_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from ngonngu";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblngonngu = new DataTable();
            adp.Fill(tblngonngu);
            dataGridView1.DataSource = tblngonngu;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmangonngu.Text = dataGridView1.CurrentRow.Cells["mangonngu"].Value.ToString();
            txttenngonngu.Text = dataGridView1.CurrentRow.Cells["tenngonngu"].Value.ToString();
            txtmangonngu.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmangonngu.Text = "";
            txttenngonngu.Text = "";
            txtmangonngu.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from ngonngu where mangonngu = '" + txtmangonngu.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmangonngu.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txttenngonngu.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {

                string sql = "insert into ngonngu values( '" + txtmangonngu.Text + "','" + txttenngonngu.Text + "')";
                try
                {
                    MessageBox.Show(sql);
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);

                    cmd.ExecuteNonQuery();
                    hienthi();
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
            }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sql = "update ngonngu set tenngonngu=@tenngonngu where mangonngu=@mangonngu";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.Parameters.AddWithValue("maloaisach", txtmangonngu.Text);
            cmd.Parameters.AddWithValue("tenloaisach", txttenngonngu.Text);
            cmd.ExecuteNonQuery();
            hienthi();
        }
    }
}
