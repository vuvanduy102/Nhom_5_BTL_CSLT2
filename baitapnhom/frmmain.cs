using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitapnhom
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void chiTiếtThuêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitietthuesach frm = new frmchitietthuesach();
            frm.Show();
        }

        private void sáchTruyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsachtruyen1 frm = new frmsachtruyen1();
            frm.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhanvien frm = new frmnhanvien();
            frm.Show();
        }

        private void chiTiếtTrảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitiettrasach frm = new frmchitiettrasach();
            frm.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtrasach frm = new frmtrasach();
            frm.Show();
        }

        private void caLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCaLam frm = new frmCaLam();
            frm.Show();
        }

        private void viPhạmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViPham frm = new frmViPham();
            frm.Show();
        }

        private void thuêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthuesach frm = new frmthuesach();
            frm.Show();
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhaxuatban frm = new frmnhaxuatban();
            frm.Show();
        }

        private void lĩnhVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlinhvuc frm = new frmlinhvuc();
            frm.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmkhachhang frm = new frmkhachhang();
            frm.Show();
        }

        private void ngônNgữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmngonngu frm = new frmngonngu();
            frm.Show();
        }

        private void loạiSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmloaisach frm = new frmloaisach();
            frm.Show();
        }

        private void tìnhTrạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtinhtrang frm = new frmtinhtrang();
            frm.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtacgia frm = new frmtacgia();
            frm.Show();
        }

        private void danhSáchSáchTruyệnChưaTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbaocaosachtruyen frm = new frmbaocaosachtruyen();
            frm.Show();
        }

        private void top5SáchTruyệnCóDoanhThuCaoNhấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtop5 frm = new frmtop5();
            frm.Show();
        }

        private void báoCáoTheoThángQuýNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbaocaotheothangquynam frm = new frmbaocaotheothangquynam();
            frm.Show();
        }
    }
}
