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
    public partial class frmsachtruyen1 : Form
    {
        public frmsachtruyen1()
        {
            InitializeComponent();
        }

        private void frmsachtruyen_Load(object sender, EventArgs e)
        {
            DAO.connect();
            hienthi();
        }
        private void hienthi()
        {
            string sql = "select * from sachtruyen";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblsachtruyen = new DataTable();
            adp.Fill(tblsachtruyen);
            dataGridView1.DataSource = tblsachtruyen;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmasach.Text = dataGridView1.CurrentRow.Cells["masach"].Value.ToString();
            txttensach.Text = dataGridView1.CurrentRow.Cells["tensach"].Value.ToString();
            txtmaloaisach.Text = dataGridView1.CurrentRow.Cells["maloaisach"].Value.ToString();
            txtmalinhvuc.Text = dataGridView1.CurrentRow.Cells["malinhvuc"].Value.ToString();
            txtmatacgia.Text = dataGridView1.CurrentRow.Cells["matacgia"].Value.ToString();
            txtmanxb.Text = dataGridView1.CurrentRow.Cells["manhaxuatban"].Value.ToString();
            txtmangonngu.Text = dataGridView1.CurrentRow.Cells["mangonngu"].Value.ToString();
            txtsotrang.Text = dataGridView1.CurrentRow.Cells["sotrang"].Value.ToString();
            txtgiasach.Text = dataGridView1.CurrentRow.Cells["giasach"].Value.ToString();
            txtdongiathue.Text = dataGridView1.CurrentRow.Cells["dongiathue"].Value.ToString();
            txtsoluong.Text = dataGridView1.CurrentRow.Cells["soluong"].Value.ToString();
            txtanh.Text = dataGridView1.CurrentRow.Cells["anh"].Value.ToString();
            txtghichu.Text = dataGridView1.CurrentRow.Cells["ghichu"].Value.ToString();
            txtmasach.Enabled = false;
        }
        private void hienthitimkiem()
        {
            string sql = "select s.masach ,s.tensach, l.tenlinhvuc as [Tên lĩnh vực], t.tentacgia as [Tên tác giả],n.tennxb as [Tên nhà xuất bản] from sachtruyen s join  tacgia t on s.matacgia = t.matacgia join linhvuc l on s.malinhvuc=l.malinhvuc join nhaxuatban n on s.manhaxuatban=n.manhaxuatban where s.tensach like '%"+txttukhoa.Text+"%' or n.tennxb like '%"+txttukhoa.Text+"%' or l.tenlinhvuc like '%"+txttukhoa.Text+"%' or t.tentacgia like '"+txttukhoa.Text+"' ";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblsachtruyen = new DataTable();
            adp.Fill(tblsachtruyen);
            dataGridView1.DataSource = tblsachtruyen;
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

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtmasach.Text = "";
            txttensach.Text = "";
            txtmaloaisach.Text = "";
            txtmalinhvuc.Text = "";
            txtmatacgia.Text = "";
            txtmanxb.Text = "";
            txtmangonngu.Text = "";
            txtsotrang.Text = "";
            txtgiasach.Text = "";
            txtdongiathue.Text = "";
            txtsoluong.Text = "";
            txtanh.Text = "";
            txtghichu.Text = "";
            txtmasach.Enabled = true;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from sachtruyen where masach = '" + txtmasach.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, DAO.con);
            cmd.ExecuteNonQuery();
            hienthi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txttensach.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên sách");
                txttensach.Focus();
                return;
            }
            if (txtmaloaisach.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã loại sách");
                txtmaloaisach.Focus();
                return;
            }
            else
            {
                string sql = "update sachtruyen set tensach=@tensach, maloaisach=@maloaisach, malinhvuc=@malinhvuc, matacgia=@matacgia, manhaxuatban=@manhaxuatban, mangonngu=@mangonngu, sotrang=@sotrang, giasach=@giasach, dongiathue=@dongiathue, soluong=@soluong, ghichu=@ghichu where masach =@masach";
                SqlCommand cmd = new SqlCommand(sql, DAO.con);
                cmd.Parameters.AddWithValue("masach", txtmasach.Text);
                cmd.Parameters.AddWithValue("tensach", txttensach.Text);
                cmd.Parameters.AddWithValue("maloaisach", txtmaloaisach.Text);
                cmd.Parameters.AddWithValue("malinhvuc", txtmalinhvuc.Text);
                cmd.Parameters.AddWithValue("matacgia", txtmatacgia.Text);
                cmd.Parameters.AddWithValue("manhaxuatban", txtmanxb.Text);
                cmd.Parameters.AddWithValue("mangonngu", txtmangonngu.Text);
                cmd.Parameters.AddWithValue("sotrang", txtsotrang.Text);
                cmd.Parameters.AddWithValue("giasach", txtgiasach.Text);
                cmd.Parameters.AddWithValue("dongiathue", txtdongiathue.Text);
                cmd.Parameters.AddWithValue("soluong", txtsoluong.Text);
                
                cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
                cmd.ExecuteNonQuery();
                hienthi();
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txtmasach.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã sách");
                txtmasach.Focus();
                return;
            }
            if (txttensach.Text == "")
            {
                MessageBox.Show("bạn chưa nhập tên sách");
                txttensach.Focus();
                return;
            }
            else
            {
                try
                {
                    string sql = "insert into sachtruyen values(@masach,@tensach,@maloaisach,@malinhvuc,@matacgia,@manhaxuatban,@mangonngu,@sotrang,@giasach,@dongiathue,@soluong,@anh,@ghichu) ";
                    SqlCommand cmd = new SqlCommand(sql, DAO.con);
                    cmd.Parameters.AddWithValue("masach", txtmasach.Text);
                    cmd.Parameters.AddWithValue("tensach", txttensach.Text);
                    cmd.Parameters.AddWithValue("maloaisach", txtmaloaisach.Text);
                    cmd.Parameters.AddWithValue("malinhvuc", txtmalinhvuc.Text);
                    cmd.Parameters.AddWithValue("matacgia", txtmatacgia.Text);
                    cmd.Parameters.AddWithValue("manhaxuatban", txtmanxb.Text);
                    cmd.Parameters.AddWithValue("mangonngu", txtmangonngu.Text);
                    cmd.Parameters.AddWithValue("sotrang", txtsotrang.Text);
                    cmd.Parameters.AddWithValue("giasach", txtgiasach.Text);
                    cmd.Parameters.AddWithValue("dongiathue", txtdongiathue.Text);
                    cmd.Parameters.AddWithValue("soluong", txtsoluong.Text);
                    cmd.Parameters.AddWithValue("anh", txtanh.Text);
                    cmd.Parameters.AddWithValue("ghichu", txtghichu.Text);
                    cmd.ExecuteNonQuery();
                    hienthi();
                }catch(Exception d)
                {
                    MessageBox.Show(d.ToString());
                }
            }
        }
    }
}
