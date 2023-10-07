using DAMau_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_DAL.Repostiories
{
    internal sealed class BaseRepository : IBaseRepository
    {
        protected string _connectionString;
        public BaseRepository()
        {
            _connectionString = "Server=DESKTOP-DQTVDBB\\SQLSERVERLOCAL;Database=DAMau;Trusted_Connection=true";
        }

        public bool ExcuteStoreProcedure(SqlCommand command)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                using(SqlCommand cmd = command)
                {
                    cmd.Connection = connection;

                    connection.Open();
                    var status = cmd.ExecuteScalar();
                    if ( status.ToString() == "1")
                    {
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
