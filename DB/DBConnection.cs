using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leave_Management_System.DB
{
    internal class DBConnection
    {
        private static DBConnection instance;
        private SqlConnection connection;


        private DBConnection() {
                    connection = new SqlConnection("Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False");
        }

        public SqlConnection getConnection() {
            if (connection.State == System.Data.ConnectionState.Closed || connection.State == System.Data.ConnectionState.Broken)
            {
                connection.Open();  // Open the connection if it's not open
            }
            return connection;
        }

        public static DBConnection getInstance() {
              return instance==null?instance=new DBConnection() : instance;
        }
    }
}
