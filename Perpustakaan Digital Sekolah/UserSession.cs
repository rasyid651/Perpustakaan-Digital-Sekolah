using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perpustakaan_Digital_Sekolah
{
    public class UserSession
    {
        public static int IdUser { get; set; }
        public static string name { get; set; }
        public static string email { get; set; }
        public static string password { get; set; }

        public static bool IsAdmin()
        {
            return email == "admin@gmail.com";
        }

        public static bool IsPetugas()
        {
            return email == "petugas@gmail.com";
        }

        public static void Logout()
        {
            IdUser = 0;
            name = "";
            email = "";
            password = "";
        }
    }
}
