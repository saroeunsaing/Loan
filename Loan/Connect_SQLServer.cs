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
        private  string datasource  = "Seanghai";
        private  string database = "loan";
        private  string user_ID  = "";
        private  string pwd  = "";

        private  string cs;


        public Connect_SQLServer()
        {
            //cs = "Data Source=" + datasource + ";Initial Catalog=" + database + "; User ID=" + user_ID + ";Password=" + pwd;
            cs = "data source=" + datasource + ";initial catalog = " + database + "; persist security info = True;Integrated Security = SSPI;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(cs);
        }

    }
}
