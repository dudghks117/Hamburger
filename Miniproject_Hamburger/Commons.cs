using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniproject_Hamburger
{
    public static class Commons
    {
        //공용 연결문자열
        public static string CONSTRING =
            "Data Source=192.168.0.20;" +
            "Initial Catalog = MiniDB;" +
            "Persist Security Info=True;User ID = sa;" +
            "Password=p@ssw0rd!";
        public static string LOGINUSERID = "";
    }
}
