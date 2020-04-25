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
    public partial class frmtrasach : Form
    {
        
        public frmtrasach()
        {
            InitializeComponent();
        }

        private void frmtrasach_Load(object sender, EventArgs e)
        {
            DAO.connect();
            loaddata();
        }
        private void loaddata()
        {
            string sql = "select * from trasach";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tbltrasach = new DataTable();
            adp.Fill(tbltrasach);
            dataGridView1_trasach.DataSource = tbltrasach;
        }

        private void dataGridView1_trasach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmatra.Text = dataGridView1_trasach.CurrentRow.Cells["matra"].Value.ToString();
            txtmathue.Text = dataGridView1_trasach.CurrentRow.Cells["mathue"].Value.ToString();
            txtmanhanvien.Text = dataGridView1_trasach.CurrentRow.Cells["manhanvien"].Value.ToString();
            txtngaytra.Text = dataGridView1_trasach.CurrentRow.Cells["ngaytra"].Value.ToString();
            txttongtien.Text = dataGridView1_trasach.CurrentRow.Cells["tongtien"].Value.ToString();
            txtmatra.Enabled = false;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmatra.Text = "";
            txtmathue.Text = "";
            txtmanhanvien.Text = "";
            txtngaytra.Text = "";
            txttongtien.Text = "";
            txtmatra.Enabled = true;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmatra.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txtmathue.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txtngaytra.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txttongtien.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {
                try
                {
                    string sql = "insert into trasach values (@matra,@mathue,@manhanvien,@ngaytra,@tongtien)";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("matra", txtmatra.Text);
                    cmd.Parameters.AddWithValue("mathue", txtmathue.Text);
                    cmd.Parameters.AddWithValue("manhanvien", txtmanhanvien.Text);
                    cmd.Parameters.AddWithValue("ngaytra", Convert.ToDateTime(txtngaytra.Text));
                    cmd.Parameters.AddWithValue("tongtien", txttongtien.Text);
                    cmd.ExecuteNonQuery();
                    loaddata();
                }catch(Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from trasach where matra='"+txtmatra.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);  
            cmd.ExecuteNonQuery();
            loaddata();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmathue.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txtmanhanvien.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txtngaytra.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            if (txttongtien.Text == "")
            {
                MessageBox.Show("không được để trống");
            }
            else
            {
                string sql = "update trasach set mathue=@mathue, manhanvien=@manhanvien,ngaytra=@ngaytra,tongtien=@tongtien where matra = @matra";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("matra", txtmatra.Text);
                cmd.Parameters.AddWithValue("mathue", txtmathue.Text);
                cmd.Parameters.AddWithValue("manhanvien", txtmanhanvien.Text);
                cmd.Parameters.AddWithValue("ngaytra", Convert.ToDateTime(txtngaytra.Text));
                cmd.Parameters.AddWithValue("tongtien", txttongtien.Text);
                cmd.ExecuteNonQuery();
                loaddata();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sql = "select f.matra,c.mathue,f.manhanvien ,sum(DATEDIFF(day,c.ngaythue,f.ngaytra)*(a.dongiathue)+i.tienphat) as [tong tien hoa don thue] from sachtruyen a join chitietthuesach b on a.masach = b.masach join thuesach c on c.mathue = b.mathue join chitiettrasach d on d.masach = a.masach join trasach f on f.matra = d.matra join vipham i on i.mavipham = d.mavipham  where datepart(yy,f.ngaytra)='"+cbthang.Text+"' group by f.matra,c.mathue,f.manhanvien";
            //SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            //DataTable tbltrasach = new DataTable();
            //adp.Fill(tbltrasach);
            //dataGridView1_trasach.DataSource = tbltrasach;
        }
    }
}
