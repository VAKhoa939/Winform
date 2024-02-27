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
            uc.Load += FGiaoVien_Load;
            uc.btnThem.Click += btnThem_Click;
            uc.btnXoa.Click += btnXoa_Click;
            uc.btnSua.Click += btnSua_Click;
            uc.gvUC.CellContentClick += gvGvien_CellContentClick;
            uc.btnChuyen.Click += btnChuyen_Click;
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            uc.gvUC.DataSource = giaoVienDAO.Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(uc.txtTen.Text, uc.txtCmnd.Text, uc.txtDiachi.Text, uc.dtNamsinh.Value, uc.txtEmail.Text, uc.txtPhoneno.Text, uc.txtGioitinh.Text);
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
            GiaoVien giaoVien = new GiaoVien(uc.txtTen.Text, uc.txtCmnd.Text, uc.txtDiachi.Text, uc.dtNamsinh.Value, uc.txtEmail.Text, uc.txtPhoneno.Text, uc.txtGioitinh.Text);
            giaoVienDAO.Xoa(giaoVien);
            FGiaoVien_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien giaoVien = new GiaoVien(uc.txtTen.Text, uc.txtCmnd.Text, uc.txtDiachi.Text, uc.dtNamsinh.Value, uc.txtEmail.Text, uc.txtPhoneno.Text, uc.txtGioitinh.Text);
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
            uc.txtTen.Text = uc.gvUC.Rows[e.RowIndex].Cells[0].Value.ToString();
            uc.txtCmnd.Text = uc.gvUC.Rows[e.RowIndex].Cells[1].Value.ToString();
            uc.txtDiachi.Text = uc.gvUC.Rows[e.RowIndex].Cells[2].Value.ToString();
            uc.dtNamsinh.Value = (DateTime)uc.gvUC.Rows[e.RowIndex].Cells[3].Value;
            uc.txtEmail.Text = uc.gvUC.Rows[e.RowIndex].Cells[4].Value.ToString();
            uc.txtPhoneno.Text = uc.gvUC.Rows[e.RowIndex].Cells[5].Value.ToString();
            uc.txtGioitinh.Text = uc.gvUC.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Hide();
            FHocSinh fHocSinh = new FHocSinh();
            fHocSinh.Show();
        }
    }
}
