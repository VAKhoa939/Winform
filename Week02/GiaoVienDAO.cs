using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class GiaoVienDAO : ConNguoiDAO
    {
        public override DataTable Load()
        {
            tableName = "GiaoVien";
            return base.Load();
        }
    }
}
