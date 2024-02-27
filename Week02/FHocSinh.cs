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
            uc.Load += FHocSinh_Load;
            uc.btnThem.Click += btnThem_Click;
            uc.btnXoa.Click += btnXoa_Click;
            uc.btnSua.Click += btnSua_Click;
            uc.gvUC.CellContentClick += gvHsinh_CellContentClick;
            uc.btnChuyen.Click += btnChuyen_Click;
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            uc.gvUC.DataSource = hocSinhDAO.Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(uc.txtTen.Text, uc.txtCmnd.Text, uc.txtDiachi.Text, uc.dtNamsinh.Value, uc.txtEmail.Text, uc.txtPhoneno.Text, uc.txtGioitinh.Text, numDiemtb.Value);
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
            HocSinh hocSinh = new HocSinh(uc.txtTen.Text, uc.txtCmnd.Text, uc.txtDiachi.Text, uc.dtNamsinh.Value, uc.txtEmail.Text, uc.txtPhoneno.Text, uc.txtGioitinh.Text, numDiemtb.Value);
            hocSinhDAO.Xoa(hocSinh);
            FHocSinh_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hocSinh = new HocSinh(uc.txtTen.Text, uc.txtCmnd.Text, uc.txtDiachi.Text, uc.dtNamsinh.Value, uc.txtEmail.Text, uc.txtPhoneno.Text, uc.txtGioitinh.Text, numDiemtb.Value);
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
            uc.txtTen.Text = uc.gvUC.Rows[e.RowIndex].Cells[0].Value.ToString();
            uc.txtCmnd.Text = uc.gvUC.Rows[e.RowIndex].Cells[1].Value.ToString();
            uc.txtDiachi.Text = uc.gvUC.Rows[e.RowIndex].Cells[2].Value.ToString();
            uc.dtNamsinh.Value = (DateTime)uc.gvUC.Rows[e.RowIndex].Cells[3].Value;
            uc.txtEmail.Text = uc.gvUC.Rows[e.RowIndex].Cells[4].Value.ToString();
            uc.txtPhoneno.Text = uc.gvUC.Rows[e.RowIndex].Cells[5].Value.ToString();
            uc.txtGioitinh.Text = uc.gvUC.Rows[e.RowIndex].Cells[6].Value.ToString();
            numDiemtb.Value = (decimal)uc.gvUC.Rows[e.RowIndex].Cells[7].Value;
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            Hide();
            FGiaoVien fGiaoVien = new FGiaoVien();
            fGiaoVien.Show();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            uc.gvUC.DataSource = hocSinhDAO.Loc(cbLocDiemtb.SelectedIndex);
        }
    }
}
