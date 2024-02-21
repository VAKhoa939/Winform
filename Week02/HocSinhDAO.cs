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
        public override DataTable Load()
        {
            tableName = "HocSinh";
            return base.Load();
        }

        public DataTable Loc(int mode)
        {
            string sqlStr = string.Format("SELECT * FROM HocSinh");
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
