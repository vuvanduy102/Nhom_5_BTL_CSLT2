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
    public partial class frmtop5 : Form
    {
        public frmtop5()
        {
            InitializeComponent();
        }

        private void frmtop5_Load(object sender, EventArgs e)
        {
            DAO.connect();
            string sql = "select top 5 a.masach,a.tensach,a.maloaisach,sum(DATEDIFF(day,c.ngaythue,f.ngaytra)*(a.dongiathue)+i.tienphat) as [Doanh thu] from sachtruyen a join chitietthuesach b on a.masach=b.masach join thuesach c on c.mathue=b.mathue join chitiettrasach d on d.masach=a.masach join trasach f on f.matra=d.matra join vipham i on i.mavipham=d.mavipham group by a.masach,a.tensach,a.maloaisach  order by [Doanh thu] desc";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblsachtruyen1 = new DataTable();
            adp.Fill(tblsachtruyen1);
            dataGridView1.DataSource = tblsachtruyen1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            excel ex = new excel();
            DataTable dt = (DataTable)dataGridView1.DataSource;
            ex.Export(dt, "Danh sach", "Danh sách Top 5 truyện có doanh thu cao nhất");
        }
    }
}
