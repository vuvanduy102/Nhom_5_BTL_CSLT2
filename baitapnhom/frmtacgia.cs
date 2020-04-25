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
    public partial class frmtacgia : Form
    {
        public frmtacgia()
        {
            InitializeComponent();
        }

        private void frmtacgia_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from tacgia";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tbltacgia = new DataTable();
            adp.Fill(tbltacgia);
            dataGridView1.DataSource = tbltacgia;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatg.Text = dataGridView1.CurrentRow.Cells["matacgia"].Value.ToString();
            txttentg.Text = dataGridView1.CurrentRow.Cells["tentacgia"].Value.ToString();
            txtngaysinh.Text = dataGridView1.CurrentRow.Cells["ngaysinh"].Value.ToString();
            cbgioitinh.Text = dataGridView1.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txtmatg.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtmatg.Text = "";
            txttentg.Text = "";
            txtngaysinh.Text = "";
            cbgioitinh.Text = "";
            txtdiachi.Text = "";
            txtmatg.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "delete from tacgia where matacgia = '" + txtmatg.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtmatg.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
            }
            if (txttentg.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
            }
            else
            {
                try
                {
                    string sql = "insert into tacgia values(@matacgia,@tentacgia,@ngaysinh,@gioitinh,@diachi)";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("matacgia", txtmatg.Text);
                    cmd.Parameters.AddWithValue("tentacgia", txttentg.Text);
                    cmd.Parameters.AddWithValue("ngaysinh", Convert.ToDateTime(txtngaysinh.Text));
                    cmd.Parameters.AddWithValue("gioitinh", cbgioitinh.Text);
                    cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtmatg.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
            }
            if (txttentg.Text == "")
            {
                MessageBox.Show("chưa nhập thông tin");
            }
            else
            {
                try
                {
                    string sql = "update tacgia set tentacgia=@tentacgia,ngaysinh=@ngaysinh,gioitinh=@gioitinh,diachi=@diachi where matacgia=@matacgia";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("matacgia", txtmatg.Text);
                    cmd.Parameters.AddWithValue("tentacgia", txttentg.Text);
                    cmd.Parameters.AddWithValue("ngaysinh", Convert.ToDateTime(txtngaysinh.Text));
                    cmd.Parameters.AddWithValue("gioitinh", cbgioitinh.Text);
                    cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
                }
                catch (Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }
    }
}

