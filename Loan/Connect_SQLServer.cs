using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Loan
{
    public abstract class  Connect_SQLServer
    {


        //Server Configuration
        private readonly string datasource  = "GURUTECH";
        private readonly string database = "Coffee_Shop";
        private readonly string user_ID  = "sa";
        private readonly string pwd  = "123";

        private readonly string cs;


        public Connect_SQLServer()
        {
            cs = "Data Source=" + datasource + ";Initial Catalog=" + database + "; User ID=" + user_ID + ";Password=" + pwd;
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(cs);
        }

    }
}
