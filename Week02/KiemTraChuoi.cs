using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02
{
    static class KiemTraChuoi
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
    }
}
