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
    public partial class frmnhanvien : Form
    {
        public frmnhanvien()
        {
            InitializeComponent();
        }

        private void frmnhanvien_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from nhanvien";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblnhanvien = new DataTable();
            adp.Fill(tblnhanvien);
            dataGridView1.DataSource = tblnhanvien;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmanv.Text = dataGridView1.CurrentRow.Cells["manhanvien"].Value.ToString();
            txttennv.Text = dataGridView1.CurrentRow.Cells["Tennhanvien"].Value.ToString();
            txtmaca.Text = dataGridView1.CurrentRow.Cells["maca"].Value.ToString();
            txtnamsinh.Text = dataGridView1.CurrentRow.Cells["namsinh"].Value.ToString();
            cbgioitinh.Text = dataGridView1.CurrentRow.Cells["gioitinh"].Value.ToString();
            txtdiachi.Text = dataGridView1.CurrentRow.Cells["diachi"].Value.ToString();
            txtsodt.Text = dataGridView1.CurrentRow.Cells["sodienthoai"].Value.ToString();
            txtluongthang.Text = dataGridView1.CurrentRow.Cells["luongthang"].Value.ToString();
            txtmanv.Enabled = false;
        }
        private void hienthitimkiem()
        {
            string sql = "select distinct n.Tennhanvien, n.namsinh,n.gioitinh ,n.luongthang from nhanvien n join calam c on n.maca = c.maca where n.Tennhanvien like '%"+txttukhoa.Text+"%'or n.gioitinh like '%"+txttukhoa.Text+"%' or c.tenca like '%"+txttukhoa.Text+"%'";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblnhanvien = new DataTable();
            adp.Fill(tblnhanvien);
            dataGridView1.DataSource = tblnhanvien;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            hienthitimkiem();
        }

        private void btndatlai_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DAO.con.Close();
            this.Close();
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            txtmaca.Text = "";
            txtnamsinh.Text = "";
            cbgioitinh.Text = "";
            txtdiachi.Text = "";
            txtsodt.Text = "";
            txtluongthang.Text = "";
            txtmanv.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from nhanvien where manhanvien = '" + txtmanv.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmanv.Text == "")
            {
                MessageBox.Show("khong duoc bo trong");
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("khong duoc bo trong");
            }
            else
            {
                try
                {
                    string sql = "insert into nhanvien values(@manhanvien,@Tennhanvien,@maca,@namsinh,@gioitinh,@diachi,@sodienthoai,@luongthang)";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("manhanvien", txtmanv.Text);
                    cmd.Parameters.AddWithValue("Tennhanvien", txttennv.Text);
                    cmd.Parameters.AddWithValue("maca", txtmaca.Text);
                    cmd.Parameters.AddWithValue("namsinh", Convert.ToDateTime(txtnamsinh.Text));
                    cmd.Parameters.AddWithValue("gioitinh", cbgioitinh.Text);
                    cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
                    cmd.Parameters.AddWithValue("sodienthoai", txtsodt.Text);
                    cmd.Parameters.AddWithValue("luongthang", txtluongthang.Text);
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
            if (txtmanv.Text == "")
            {
                MessageBox.Show("khong duoc bo trong");
            }
            if (txttennv.Text == "")
            {
                MessageBox.Show("khong duoc bo trong");
            }
            else
            {
                string sql = "update nhanvien set Tennhanvien=@Tennhanvien,maca=@maca,namsinh=@namsinh,gioitinh=@gioitinh,diachi=@diachi,sodienthoai=@sodienthoai,luongthang=@luongthang where manhanvien=@manhanvien ";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("manhanvien", txtmanv.Text);
                cmd.Parameters.AddWithValue("Tennhanvien", txttennv.Text);
                cmd.Parameters.AddWithValue("maca", txtmaca.Text);
                cmd.Parameters.AddWithValue("namsinh", Convert.ToDateTime(txtnamsinh.Text));
                cmd.Parameters.AddWithValue("gioitinh", cbgioitinh.Text);
                cmd.Parameters.AddWithValue("diachi", txtdiachi.Text);
                cmd.Parameters.AddWithValue("sodienthoai", txtsodt.Text);
                cmd.Parameters.AddWithValue("luongthang", txtluongthang.Text);
                cmd.ExecuteNonQuery();
                hienthi();
            }
        }
    }
}
