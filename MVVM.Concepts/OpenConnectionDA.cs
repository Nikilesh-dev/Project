using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.DA
{
    public class OpenConnectionDA
    {
        public string ProQuery { get; set; }

        public string ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Name;Data Source=LAPTOP-PJRIF9P6";
        public SqlDataAdapter GetData()
        {

            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(ProQuery, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlConnection.Close();
            return sqlDataAdapter;
        }
        public int Query()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(ProQuery, sqlConnection);
            int q = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return q;
        }
    }
}
