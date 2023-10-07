using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_DAL.IRepositories
{
    public interface IRepositoryManager
    {
        IBaseRepository BaseRepository { get; }
        ISanPhamsRepository SanPhamsRepository { get; }
    }
}
