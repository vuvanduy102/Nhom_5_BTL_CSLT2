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
    public partial class frmloaisach : Form
    {
        public frmloaisach()
        {
            InitializeComponent();
        }

        private void frmloaisach_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from loaisach";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tbloaisach = new DataTable();
            adp.Fill(tbloaisach);
            dataGridView1.DataSource = tbloaisach;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmaloaisach.Text = dataGridView1.CurrentRow.Cells["maloaisach"].Value.ToString();
            txttenloaisach.Text = dataGridView1.CurrentRow.Cells["tenloaisach"].Value.ToString();
            txtmaloaisach.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmaloaisach.Text = "";
            txttenloaisach.Text = "";
            txtmaloaisach.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from loaisach where maloaisach = '" + txtmaloaisach.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmaloaisach.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txttenloaisach.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {
                
                    string sql = "insert into loaisach values( '"+txtmaloaisach.Text+"','"+txttenloaisach.Text+"')";
                try {
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
            string sql = "update linhvuc set tenloaisach=@tenloaisach where maloaisach=@maloaisach";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.Parameters.AddWithValue("maloaisach", txtmaloaisach.Text);
            cmd.Parameters.AddWithValue("tenloaisach", txttenloaisach.Text);
            cmd.ExecuteNonQuery();
            hienthi();
        }
    }
}
