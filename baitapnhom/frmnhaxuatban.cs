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
    public partial class frmnhaxuatban : Form
    {
        public frmnhaxuatban()
        {
            InitializeComponent();
        }

        private void frmnhaxuatban_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from nhaxuatban";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblnhaxb = new DataTable();
            adp.Fill(tblnhaxb);
            dataGridView1.DataSource = tblnhaxb;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanxb.Text = dataGridView1.CurrentRow.Cells["manhaxuatban"].Value.ToString();
            txttennxb.Text = dataGridView1.CurrentRow.Cells["tennxb"].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txtsodt.Text = dataGridView1.CurrentRow.Cells["sodt"].Value.ToString();
            txtmanxb.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmanxb.Text = "";
            txttennxb.Text = "";
            txtdiachi.Text = "";
            txtsodt.Text = "";
            txtmanxb.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from nhaxuatban where manhaxuatban = '" + txtmanxb.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmanxb.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
            }
            if (txttennxb.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
            }
            else
            {
                try
                {
                    string sql = "insert into nhaxuatban values(@manhaxuatban,@tennxb,@diachi,@sodt)";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("manhaxuatban", txtmanxb.Text);
                    cmd.Parameters.AddWithValue("tennxb", txttennxb.Text);
                    cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("sodt", txtsodt.Text);
                    cmd.ExecuteNonQuery();
                    hienthi();
                }catch(Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmanxb.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
            }
            if (txttennxb.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
            }
            else
            {


                string sql = "update nhaxuatban set tennxb=@tennxb, diachi=@diachi,sodt=@sodt where manhaxuatban=@manhaxuatban";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("manhaxuatban", txtmanxb.Text);
                cmd.Parameters.AddWithValue("tennxb", txttennxb.Text);
                cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
                cmd.Parameters.AddWithValue("sodt", txtsodt.Text);
                cmd.ExecuteNonQuery();
                hienthi();
            }
        }
    }
}
