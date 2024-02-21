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
    public partial class FGiaoVien : Form
    {
        GiaoVienDAO giaoVienDAO = new GiaoVienDAO();

        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            gvGvien.DataSource = giaoVienDAO.Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(txtTen.Text, txtCmnd.Text, txtDiachi.Text, dtNamsinh.Value, txtEmail.Text, txtPhoneno.Text, txtGioitinh.Text);
            if (!giaoVien.CheckThongTin())
            {
                MessageBox.Show("Thong tin khong hop le. Moi nhap lai.");
                return;
            }
            giaoVienDAO.Them(giaoVien);
            FGiaoVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(txtTen.Text, txtCmnd.Text, txtDiachi.Text, dtNamsinh.Value, txtEmail.Text, txtPhoneno.Text, txtGioitinh.Text);
            giaoVienDAO.Xoa(giaoVien);
            FGiaoVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(txtTen.Text, txtCmnd.Text, txtDiachi.Text, dtNamsinh.Value, txtEmail.Text, txtPhoneno.Text, txtGioitinh.Text);
            if (!giaoVien.CheckThongTin())
            {
                MessageBox.Show("Thong tin khong hop le. Moi nhap lai.");
                return;
            }
            giaoVienDAO.Sua(giaoVien);
            FGiaoVien_Load(sender, e);
        }

        private void gvGvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTen.Text = gvGvien.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCmnd.Text = gvGvien.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDiachi.Text = gvGvien.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtNamsinh.Value = (DateTime)gvGvien.Rows[e.RowIndex].Cells[3].Value;
            txtEmail.Text = gvGvien.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPhoneno.Text = gvGvien.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtGioitinh.Text = gvGvien.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Hide();
            FHocSinh fHocSinh = new FHocSinh();
            fHocSinh.Show();
        }
    }
}
