using DAMau_Dtos.SanPhamsDtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_DAL.IRepositories
{
    public interface ISanPhamsRepository
    {
        DataSet SelectAll();
    }
}
