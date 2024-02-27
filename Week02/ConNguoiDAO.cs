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
        protected string sqlStr = "";
        protected string tableName = "";

        public ConNguoiDAO()
        {
            tableName = this.GetType().Name;
            tableName = tableName.Remove(tableName.Length - 3, 3);
        }

        public virtual DataTable Load()
        {
            sqlStr = string.Format("SELECT * FROM " + tableName);
            return dBConn.Load(sqlStr);
        }

        public virtual void Them(ConNguoi conNguoi)
        {
            sqlStr = string.Format("INSERT INTO " + tableName + " (Ten, Cmnd, Diachi, Namsinh, Email, Phoneno, Gioitinh) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", conNguoi.Ten, conNguoi.Cmnd, conNguoi.DiaChi, conNguoi.NamSinh.ToString("yyyy-MM-dd"), conNguoi.Email, conNguoi.PhoneNo, conNguoi.GioiTinh);
            dBConn.Execute(sqlStr, "Them");
        }

        public void Xoa(ConNguoi conNguoi)
        {
            sqlStr = string.Format("DELETE FROM " + tableName + " WHERE Cmnd = '{0}'", conNguoi.Cmnd);
            dBConn.Execute(sqlStr, "Xoa");
        }

        public virtual void Sua(ConNguoi conNguoi)
        {
            sqlStr = string.Format("UPDATE " + tableName + " SET Ten = '{0}', Diachi = '{1}', Namsinh = '{2}', Email = '{3}', Phoneno = '{4}', Gioitinh = '{5}' WHERE Cmnd = '{6}'", conNguoi.Ten, conNguoi.DiaChi, conNguoi.NamSinh.ToString("yyyy-MM-dd"), conNguoi.Email, conNguoi.PhoneNo, conNguoi.GioiTinh, conNguoi.Cmnd);
            dBConn.Execute(sqlStr, "Sua");
        }
    }
}
