using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace baitapnhom
{
    public partial class frmbaocaosachtruyen : Form
    {
        public frmbaocaosachtruyen()
        {
            InitializeComponent();
        }

        private void frmbaocaosachtruyen_Load(object sender, EventArgs e)
        {
            DAO.connect();
            string sql = "select masach,tensach,maloaisach from sachtruyen   where exists (select masach from chitietthuesach where chitietthuesach.masach = sachtruyen.masach)";
            SqlDataAdapter adp = new SqlDataAdapter(sql, DAO.con);
            DataTable tblsachtruyen = new DataTable();
            adp.Fill(tblsachtruyen);
            dataGridView1.DataSource = tblsachtruyen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            xuatexcel excel = new xuatexcel();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 
            DataTable dt = (DataTable)dataGridView1.DataSource;
            excel.Export(dt, "Danh sach", "Danh sách các đầu sách đang được thuê");
        }
    }
}
