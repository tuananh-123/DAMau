using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_DAL.IRepositories
{
    public interface IBaseRepository
    {
        bool ExcuteStoreProcedure(SqlCommand command);
    }
}
