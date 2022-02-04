using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturation.Config
{
    public static class database
    {
        private static String connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Facturation.accdb;Jet OLEDB:Database Password=ibraKHALIL2020;";
        private static String ownerInfo = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AppInfo.accdb;Jet OLEDB:Database Password=ibraKHALIL2020;";

        public static String getConnectionString()
        {
            return connectionString;
        }
        public static String getOwnerInfoConnString()
        {
            return ownerInfo;
        }
    }
}
