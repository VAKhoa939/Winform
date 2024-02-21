using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class GiaoVien : ConNguoi
    {
        public GiaoVien(string ten, string cmnd, string diachi, DateTime namsinh, string email, string phoneNo, string gioiTinh) : base(ten, cmnd, diachi, namsinh, email, phoneNo, gioiTinh)
        {
        }
    }
}
