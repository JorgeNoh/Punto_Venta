using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
namespace DataAccess
{
    public class UserDao : Conecction
    {
        public bool Login(string user, string pass) { 
            using(var connection = GetConnection())
            {
                connection.Open();
                using(var command= new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Users WHERE LoginName=@user AND Pass=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.IdUser = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(3);
                            UserLoginCache.Apellido = reader.GetString(4);
                            UserLoginCache.Puesto = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }                        
                }
            }
        }
    }
}
