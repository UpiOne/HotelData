using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelData
{
    internal class LoginSaveID
    {
        static string ULogin;
        public static string ulogin
        {
            get
            {
                return ULogin;
            }
            set
            {
                ULogin = value;
            }
        }

    }
}
