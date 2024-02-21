using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class HocSinh : ConNguoi
    {
        private decimal diemTB;

        public HocSinh(string ten, string cmnd, string diachi, DateTime namsinh, string email, string phoneNo, string gioiTinh, decimal diemTB) : base(ten, cmnd, diachi, namsinh, email, phoneNo, gioiTinh)
        {
            this.diemTB = diemTB;
        }
    }
}
