using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallGuide
{
    public class DBHelper
    {
        private DBHelper() 
        {
        
        }
        public static string connection = @"Data Source=.\SQLEXPRESS; Initial Catalog=hasankoc; Integrated Security=True; Trusted_Connection=Yes; ";
        private static DataSet set;

        public static DataSet GetDBAdapter() 
        {
            if (set == null)
                set = new DataSet();
           return set;
        }
    }
}
