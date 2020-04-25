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
    public partial class frmchitiettrasach : Form
    {
        
        public frmchitiettrasach()
        {
            InitializeComponent();
        }

        private void frmchitiettrasach_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from chitiettrasach";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblchitiettrasach = new DataTable();
            adp.Fill(tblchitiettrasach);
            dataGridView1.DataSource = tblchitiettrasach;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatra.Text = dataGridView1.CurrentRow.Cells["matra"].Value.ToString();
            txtmasach.Text = dataGridView1.CurrentRow.Cells["masach"].Value.ToString();
            txtmavipham.Text = dataGridView1.CurrentRow.Cells["mavipham"].Value.ToString();
           
            txtmatra.Enabled = false;
            txtmasach.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmatra.Text = "";
            txtmasach.Text = "";
            txtmavipham.Text = "";
           
            txtmatra.Enabled = true;
            txtmasach.Enabled = true;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmavipham.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
          
            else
            {
                string sql = "update chitiettrasach set masach=@masach,mavipham=@mavipham where matra=@matra ";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("matra", txtmatra.Text);
                cmd.Parameters.AddWithValue("masach", txtmasach.Text);
                cmd.Parameters.AddWithValue("mavipham", txtmavipham.Text);
              
                cmd.ExecuteNonQuery();
                hienthi();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmatra.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txtmasach.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txtmavipham.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
          
            else
            {
                try
                {
                    string sql = "insert into chitiettrasach values(@matra,@masach,@mavipham)";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("matra", txtmatra.Text);
                    cmd.Parameters.AddWithValue("masach", txtmasach.Text);
                    cmd.Parameters.AddWithValue("mavipham", txtmavipham.Text);
                   
                    cmd.ExecuteNonQuery();
                    hienthi();

                }catch(Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete from chitiettrasach where matra=@matra";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.Parameters.AddWithValue("matra", txtmatra.Text);
            cmd.Parameters.AddWithValue("masach", txtmasach.Text);
            cmd.Parameters.AddWithValue("mavipham", txtmavipham.Text);
           
            cmd.ExecuteNonQuery();
            hienthi();
        }
        private void hienthitimkiem()
        {
            //string sql = "select ct.matra, ct.masach,ct.mavipham,ct.thanhtien , ngaytra from chitiettrasach ct join trasach t on ct.matra=t.matra where ct.matra like '%" + txttukhoa.Text + "%'";
            //SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            //DataTable tblchitiettrasach = new DataTable();
            //adp.Fill(tblchitiettrasach);
            //dataGridView1.DataSource = tblchitiettrasach;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthitimkiem();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select distinct chitietthuesach.masach,chitietthuesach.mathue from chitietthuesach where chitietthuesach.mathue='" + txtmathue.Text + "' and chitietthuesach.masach not in (select chitiettrasach.masach from chitiettrasach join trasach on chitiettrasach.matra=trasach.matra where trasach.mathue='" + txtmathue.Text+"')";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblchitiettrasach = new DataTable();
            adp.Fill(tblchitiettrasach);
            dataGridView1.DataSource = tblchitiettrasach;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //txtthahtien.Text =DAO.GetFieldValues( "select sum(DATEDIFF(day,c.ngaythue,f.ngaytra)*(a.dongiathue)+i.tienphat) as [tong tien hoa don thue] from sachtruyen a join chitietthuesach b on a.masach = b.masach join thuesach c on c.mathue = b.mathue join chitiettrasach d on d.masach = a.masach join trasach f on f.matra = d.matra join vipham i on i.mavipham = d.mavipham where f.matra='" + txtmatra.Text + "'");
            string sql = "select f.matra,a.masach,i.mavipham, sum(DATEDIFF(day,c.ngaythue,f.ngaytra)*(a.dongiathue)+i.tienphat) as [Thành Tiền] from sachtruyen a join chitietthuesach b on a.masach = b.masach join thuesach c on c.mathue = b.mathue join chitiettrasach d on d.masach = a.masach join trasach f on f.matra = d.matra join vipham i on i.mavipham = d.mavipham group by f.matra,a.masach,i.mavipham";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblchitiettrasach = new DataTable();
            adp.Fill(tblchitiettrasach);
            dataGridView1.DataSource = tblchitiettrasach;
        }
    }
}
