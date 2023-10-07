using DAMau_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_DAL.Repostiories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IBaseRepository> _lazyBaseRepository;

        private readonly Lazy<ISanPhamsRepository> _lazySanPhamsRespository;

        public RepositoryManager()
        {
            _lazyBaseRepository = new Lazy<IBaseRepository>(() => new BaseRepository());
            _lazySanPhamsRespository = new Lazy<ISanPhamsRepository>(() => new SanPhamRepository());
        }

        public IBaseRepository BaseRepository => _lazyBaseRepository.Value;

        public ISanPhamsRepository SanPhamsRepository => _lazySanPhamsRespository.Value;
    }
}
