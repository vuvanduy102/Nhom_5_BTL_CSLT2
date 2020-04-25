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
    public partial class frmchitietthuesach : Form
    {
        
        public frmchitietthuesach()
        {
            InitializeComponent();
        }

        private void frmchitietthuesach_Load(object sender, EventArgs e)
        {
            DAO.connect();
            loaddata();
        }
        private void loaddata()
        {
            
            string sql = "select * from chitietthuesach";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblchitietthuesach = new DataTable();
            adp.Fill(tblchitietthuesach);
            dataGridView1.DataSource = tblchitietthuesach;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmathue.Text = dataGridView1.CurrentRow.Cells["mathue"].Value.ToString();
            txtmasach.Text = dataGridView1.CurrentRow.Cells["masach"].Value.ToString();
            txtmatinhtrang.Text = dataGridView1.CurrentRow.Cells["matinhtrang"].Value.ToString();
            txtdatra.Text = dataGridView1.CurrentRow.Cells["datra"].Value.ToString();
            txtmathue.Enabled = false;
            txtmasach.Enabled = false;
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txtmathue.Text = "";
            txtmatinhtrang.Text = "";
            txtdatra.Text = "";
            txtmathue.Enabled = true;
            txtmasach.Enabled = true;
            txtsoluong.Clear();
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from chitietthuesach where mathue= '" + txtmathue.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,DAO.con);
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmathue.Text == "")
            {
                MessageBox.Show("mã thuê còn trống");

            }
            if (txtmasach.Text == "")
            {
                MessageBox.Show("mã sach còn trống");
            }
            if (txtmatinhtrang.Text == "")
            {
                MessageBox.Show("mã tình trạng còn trống");
            }
            if (txtdatra.Text == "")
            {
                MessageBox.Show("đã trả còn trống");
            }
            else
            {
                if ((txtsoluong.Text) != "0")
                {
                    MessageBox.Show("bạn được thêm sách này vào chi tiết hóa đơn");
                    string sql = "insert into chitietthuesach values( '" + txtmathue.Text + "','" + txtmasach.Text + "','" + txtmatinhtrang.Text + "','" + txtdatra.Text + "')";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.ExecuteNonQuery();
                    loaddata();
                }
                else
                    MessageBox.Show("bạn không thêm được vào chi tiết hóa đơn vì số lượng sách bằng 0");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmatinhtrang.Text == "")
            {
                MessageBox.Show("chưa nhập mã tình trạng");
            }
            if (txtdatra.Text == "")
            {
                MessageBox.Show("chưa nhập ô đã trả");
            }
            else
            {
                string sql = "update chitietthuesach set masach=@masach, matinhtrang=@matinhtrang,datra=@datra where mathue=@mathue";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("mathue", txtmathue.Text);
                cmd.Parameters.AddWithValue("masach", txtmasach.Text);
                cmd.Parameters.AddWithValue("matinhtrang", txtmatinhtrang.Text);
                cmd.Parameters.AddWithValue("datra", txtdatra.Text);
                cmd.ExecuteNonQuery();
                loaddata();
            }
        }
        private void loaddatasearch()
        {
            string sql = "select * from chitietthuesach where mathue like '%"+txttimkiem.Text+"%'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblchitietthuesach = new DataTable();
            adp.Fill(tblchitietthuesach);
            dataGridView1.DataSource = tblchitietthuesach;
        }
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            loaddatasearch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtsoluong.Text = DAO.GetFieldValues("SELECT sachtruyen.soluong FROM sachtruyen join chitietthuesach on sachtruyen.masach=chitietthuesach.masach WHERE  sachtruyen.masach = N'" + txtmasach.Text + "'");
        }
    }
}
