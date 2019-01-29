using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject.GoodeeDAO
{
    class GoodeeDAO : IGoodee
    {
        private DBConnection con;

        private static GoodeeDAO gd;

        public static GoodeeDAO getInstance()
        {
            if (gd == null)
            {
                gd = new GoodeeDAO();
            }
            return gd;
        }

        public List<AccountInfo> AccountLogin()
        {
            throw new NotImplementedException();
        }
    }
}
