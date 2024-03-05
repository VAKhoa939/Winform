using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02
{
    static class KiemTraThongTin
    {
        public static bool CheckEmail(string email)
        {
            int count = 0;
            foreach (char c in email)
            {
                if (c == '@') count++;
            }
            if (count != 1) return false;
            return true;
        }

        public static bool CheckPhoneNo(string phoneNo) 
        { 
            if (phoneNo.Length != 12) return false;
            int count = 0;
            foreach (char c in phoneNo) 
            {
                if (c == '-') count++;
            }
            if (count != 2) return false;
            if (phoneNo[3] != '-' || phoneNo[8] != '-') return false;
            return true;
        }

        public static bool CheckNamSinh(DateTime namSinh) 
        {
            return (DateTime.Now.Year - namSinh.Year) >= 18;
        }

        public static bool CheckAll(ConNguoi conNguoi)
        {
            if (string.IsNullOrEmpty(conNguoi.Ten)
                || string.IsNullOrEmpty(conNguoi.Cmnd)
                || string.IsNullOrEmpty(conNguoi.DiaChi)
                || string.IsNullOrEmpty(conNguoi.Email)
                || string.IsNullOrEmpty(conNguoi.PhoneNo)
                || string.IsNullOrEmpty(conNguoi.GioiTinh)
                )
            {
                MessageBox.Show("Con thieu 1 hoac nhieu thong tin. Xin hay dien day du.");
                return false;
            }
            if (!CheckEmail(conNguoi.Email))
            {
                MessageBox.Show("Email khong hop le. Xin hay dien lai."); 
                return false; 
            }
            if (!CheckPhoneNo(conNguoi.PhoneNo))
            {
                MessageBox.Show("So dien thoai khong hop le. Xin hay dien lai.");
                return false;
            }
            if (!CheckNamSinh(conNguoi.NamSinh))
            {
                MessageBox.Show("Nam sinh duoi 18 tuoi. Xin hay dien lai.");
                return false;
            }
            return true;
        }
    }
}
