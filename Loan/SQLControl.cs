using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Loan.FORMS
{
    class SQLControl : Connect_SQLServer
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable dt;


        public void Retrive(string qty, DataGridView dgv)
        {
            using (var cn = GetConnection())
            {

                cmd = new SqlCommand(qty, cn);
                da = new SqlDataAdapter(cmd);

                dt = new DataTable();

                da.Fill(dt);

                dgv.DataSource = dt;

            }
        }
        public string GetMaxID(string table, string field, int num, string pre, string defualt)

        {
            string id;
            using (var cn = GetConnection())
            {
                cn.Open();
                cmd = new SqlCommand("Select top 1 " + field + " From " + table + " order by " + field + " DESC", cn);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    string s = dr.GetString(0);
                    s = s.Substring(num, s.Length - 2);

                    int str = Convert.ToInt32(s) + 1;
                    id = pre + Convert.ToString(str).PadLeft(s.Length, '0');
                }
                else
                {
                    id = defualt;
                }

                dr.Close();

                return id;

                cn.Close();
            }
        }
    }
}
