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
        private string connectionString = "Data Source=SHARADA\\SQLEXPRESS01;Initial Catalog=leavemanagmenet;Integrated Security=True;Encrypt=False";
        private SqlConnection connection;
        private DBConnection() {
                    connection = new SqlConnection(connectionString);
        }

        public SqlConnection getConnection() { 
            return connection;
        }

        public static DBConnection getInstance() {
              return instance==null?instance=new DBConnection() : instance;
        }
    }
}
