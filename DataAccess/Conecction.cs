using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Conecction
    {
        private readonly string ConnectionString;
        public Conecction()
        {
            ConnectionString = "server=localhost; database=ventas; integrated security = true;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
