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
    public partial class frmtinhtrang : Form
    {
        public frmtinhtrang()
        {
            InitializeComponent();
        }

        private void frmtinhtrang_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from tinhtrang ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tbltinhtrang = new DataTable();
            adp.Fill(tbltinhtrang);
            dataGridView_Formtinhtrang.DataSource = tbltinhtrang;
        }

        private void dataGridView_Formtinhtrang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatinhtrang.Text = dataGridView_Formtinhtrang.CurrentRow.Cells["matinhtrang"].Value.ToString();
            txttentinhtrang.Text = dataGridView_Formtinhtrang.CurrentRow.Cells["tentinhtrang"].Value.ToString();
            txtmatinhtrang.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmatinhtrang.Text = "";
            txttentinhtrang.Text = "";
            txtmatinhtrang.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmatinhtrang.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txttentinhtrang.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {
                try
                {

                    string sql = "insert into tinhtrang values(@matinhtrang,@tentinhtrang)";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("matinhtrang", txtmatinhtrang.Text);
                    cmd.Parameters.AddWithValue("tentinhtrang", txttentinhtrang.Text);
                    cmd.ExecuteNonQuery();
                    hienthi();
                }catch(Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update tinhtrang set tentinhtrang=@tentinhtrang where matinhtrang =@matinhtrang";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.Parameters.AddWithValue("matinhtrang", txtmatinhtrang.Text);
            cmd.Parameters.AddWithValue("tentinhtrang", txttentinhtrang.Text);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql= "delete from tinhtrang where matinhtrang = '" + txtmatinhtrang.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            hienthi();
        }
    }
}
