using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class ConNguoiDAO
    {
        protected DBConnection dBConn = new DBConnection();
        protected string tableName = "";

        public virtual DataTable Load()
        {
            string sqlStr = string.Format("SELECT * FROM " + tableName);
            return dBConn.Load(sqlStr);
        }

        public void Them(ConNguoi conNguoi)
        {
            string sqlStr = string.Format("INSERT INTO " + conNguoi.GetType().Name + " (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", conNguoi.Ten, conNguoi.Cmnd, conNguoi.DiaChi, conNguoi.NamSinh.ToString("yyyy-MM-dd"), conNguoi.Email, conNguoi.PhoneNo, conNguoi.GioiTinh);
            dBConn.Execute(sqlStr, "Them");
        }

        public void Xoa(ConNguoi conNguoi)
        {
            string sqlStr = string.Format("DELETE FROM " + conNguoi.GetType().Name + " WHERE Cmnd = '{0}'", conNguoi.Cmnd);
            dBConn.Execute(sqlStr, "Xoa");
        }

        public void Sua(ConNguoi conNguoi)
        {
            string sqlStr = string.Format("UPDATE " + conNguoi.GetType().Name + " SET Ten = '{0}', Diachi = '{1}', Namsinh = '{2}', Email = '{3}', Phoneno = '{4}', Gioitinh = '{5}' WHERE Cmnd = '{6}'", conNguoi.Ten, conNguoi.DiaChi, conNguoi.NamSinh.ToString("yyyy-MM-dd"), conNguoi.Email, conNguoi.PhoneNo, conNguoi.GioiTinh, conNguoi.Cmnd);
            dBConn.Execute(sqlStr, "Sua");
        }
    }
}
