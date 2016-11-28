using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductMaintenance
{
    public class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\telec\Documents\Visual Studio 2015\Projects\CIS-3309-Assignments\RizerChapter20\ProductMaintenance\ProductMaintenance\MMABooks.mdf";Integrated Security=True
            // 
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                                      "AttachDbFilename=|DataDirectory|\\MMABooks.mdf" +
                                      "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection; 
        }
    }
}
