using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    class ConNguoi
    {
        protected string ten;
        protected string cmnd;
        protected string diaChi;
        protected DateTime namSinh;
        protected string email;
        protected string phoneNo;
        protected string gioiTinh;

        public ConNguoi(string ten, string cmnd, string diaChi, DateTime namSinh, string email, string phoneNo, string gioiTinh)
        {
            this.ten = ten;
            this.cmnd = cmnd;
            this.diaChi = diaChi;
            this.namSinh = namSinh;
            this.email = email;
            this.phoneNo = phoneNo;
            this.gioiTinh = gioiTinh;
        }

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        public string Cmnd
        {
            get { return cmnd; }
            set { cmnd = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        public DateTime NamSinh
        {
            get { return namSinh; }
            set { namSinh = value; }
        }

        public string Email
        { 
            get { return email; } 
            set { email = value; } 
        }

        public string PhoneNo
        { 
            get { return phoneNo; } 
            set {  phoneNo = value; } 
        }

        public string GioiTinh
        { 
            get { return gioiTinh; } 
            set { gioiTinh = value; }
        }
    }
}
