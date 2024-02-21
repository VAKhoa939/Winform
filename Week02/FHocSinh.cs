using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Week02
{
    public partial class FHocSinh : Form
    {
        HocSinhDAO hocSinhDAO = new HocSinhDAO();

        public FHocSinh()
        {
            InitializeComponent();
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            gvHsinh.DataSource = hocSinhDAO.Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtTen.Text, txtCmnd.Text, txtDiachi.Text, dtNamsinh.Value, txtEmail.Text, txtPhoneno.Text, txtGioitinh.Text, numDiemtb.Value);
            if (!hocSinh.CheckThongTin())
            {
                MessageBox.Show("Thong tin khong hop le. Moi nhap lai.");
                return;
            }
            hocSinhDAO.Them(hocSinh);
            FHocSinh_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtTen.Text, txtCmnd.Text, txtDiachi.Text, dtNamsinh.Value, txtEmail.Text, txtPhoneno.Text, txtGioitinh.Text, numDiemtb.Value);
            hocSinhDAO.Xoa(hocSinh);
            FHocSinh_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(txtTen.Text, txtCmnd.Text, txtDiachi.Text, dtNamsinh.Value, txtEmail.Text, txtPhoneno.Text, txtGioitinh.Text, numDiemtb.Value);
            if (!hocSinh.CheckThongTin())
            {
                MessageBox.Show("Thong tin khong hop le. Moi nhap lai.");
                return;
            }
            hocSinhDAO.Sua(hocSinh);
            FHocSinh_Load(sender, e);
        }

        private void gvHsinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = gvHsinh.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCmnd.Text = gvHsinh.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiachi.Text = gvHsinh.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtNamsinh.Value = (DateTime)gvHsinh.Rows[e.RowIndex].Cells[3].Value;
            txtEmail.Text = gvHsinh.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPhoneno.Text = gvHsinh.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtGioitinh.Text = gvHsinh.Rows[e.RowIndex].Cells[6].Value.ToString();
            numDiemtb.Value = (decimal)gvHsinh.Rows[e.RowIndex].Cells[7].Value;
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Hide();
            FGiaoVien fGiaoVien = new FGiaoVien();
            fGiaoVien.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            gvHsinh.DataSource = hocSinhDAO.Loc(cbLocDiemtb.SelectedIndex);
        }
    }
}
