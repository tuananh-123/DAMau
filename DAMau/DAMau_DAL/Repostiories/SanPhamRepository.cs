using DAMau_DAL.IRepositories;
using DAMau_Dtos.SanPhamsDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DAMau_DAL.Repostiories
{
    internal sealed class SanPhamRepository : ISanPhamsRepository
    {
        private readonly string Conn;
        public SanPhamRepository()
        {
            Conn = "Server=DESKTOP-DQTVDBB\\SQLSERVERLOCAL;Database=DAMau;Trusted_Connection=true";
        }

        public DataSet SelectAll()
        {
            string sqlQuery = "select * from dbo.SanPhams";
            using (SqlConnection connection = new SqlConnection(Conn))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                try
                {
                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.TableMappings.Add("Table", "SanPhams"); // Sửa "Table" thành "SanPhams"
                    adapter.SelectCommand = command;
                    DataSet dataSet = new DataSet("SanPhams"); // Sửa "SansPhams" thành "SanPhams"
                    adapter.Fill(dataSet);


                    connection.Close();
                    return dataSet;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
