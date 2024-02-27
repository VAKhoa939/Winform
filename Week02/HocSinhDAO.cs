using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02
{
    class HocSinhDAO : ConNguoiDAO
    {
        public void Them(HocSinh hocSinh)
        {
            sqlStr = string.Format("INSERT INTO HocSinh (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh, Diemtb) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", hocSinh.Ten, hocSinh.Cmnd, hocSinh.DiaChi, hocSinh.NamSinh.ToString("yyyy-MM-dd"), hocSinh.Email, hocSinh.PhoneNo, hocSinh.GioiTinh, hocSinh.DiemTB);
            dBConn.Execute(sqlStr, "Them");
        }

        public void Sua(HocSinh hocSinh)
        {
            sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', Diachi = '{1}', Namsinh = '{2}', Email = '{3}', Phoneno = '{4}', Gioitinh = '{5}', Diemtb = '{6}' WHERE Cmnd = '{7}'", hocSinh.Ten, hocSinh.DiaChi, hocSinh.NamSinh.ToString("yyyy-MM-dd"), hocSinh.Email, hocSinh.PhoneNo, hocSinh.GioiTinh, hocSinh.DiemTB, hocSinh.Cmnd);
            dBConn.Execute(sqlStr, "Sua");
        }

        public DataTable Loc(int mode)
        {
            sqlStr = string.Format("SELECT * FROM HocSinh");
            switch (mode)
            {
                case 0:
                    sqlStr += string.Format(" WHERE Diemtb >= 8");
                    break;
                case 1:
                    sqlStr += string.Format(" WHERE Diemtb >= 5 AND Diemtb < 8");
                    break;
                case 2:
                    sqlStr += string.Format(" WHERE Diemtb < 5");
                    break;
                default:
                    break;
            }
            return dBConn.Load(sqlStr);
        }
    }
}
