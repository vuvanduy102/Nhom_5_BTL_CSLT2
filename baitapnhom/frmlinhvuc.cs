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
    public partial class frmlinhvuc : Form
    {
        public frmlinhvuc()
        {
            InitializeComponent();
        }

        private void frmlinhvuc_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from linhvuc";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblinhvuc = new DataTable();
            adp.Fill(tblinhvuc);
            dataGridView1.DataSource = tblinhvuc;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmalv.Text = dataGridView1.CurrentRow.Cells["malinhvuc"].Value.ToString();
            txttenlv.Text = dataGridView1.CurrentRow.Cells["tenlinhvuc"].Value.ToString();
            txtmalv.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtmalv.Text = "";
            txttenlv.Text = "";
            txtmalv.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtmalv.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txttenlv.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {
                string sql = "update linhvuc set tenlinhvuc=@tenlinhvuc where malinhvuc =@malinhvuc";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("malinhvuc", txtmalv.Text);
                cmd.Parameters.AddWithValue("tenlinhvuc", txttenlv.Text);
                cmd.ExecuteNonQuery();
                hienthi();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmalv.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txttenlv.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {
                try
                {
                    string sql = "insert into linhvuc values(@malinhvuc,@tenlinhvuc)";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("malinhvuc", txtmalv.Text);
                    cmd.Parameters.AddWithValue("tenlinhvuc", txttenlv.Text);
                    cmd.ExecuteNonQuery();
                    hienthi();
                }catch(Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from linhvuc where malinhvuc = '" + txtmalv.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            hienthi();
        }
    }
}
