using DAMau_BLL._IServices;
using DAMau_DAL.IRepositories;
using DAMau_Dtos.AuthenticationDtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_BLL._Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRepositoryManager _repositoryManager;

        public AuthenticationService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public void Login(UserLoginInformation userLogin)
        {
            var command = new SqlCommand();
            command.CommandText = "Login";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@email", System.Data.SqlDbType.VarChar, 50).Value = userLogin.Email;
            command.Parameters.Add("@password", System.Data.SqlDbType.NVarChar, 50).Value = userLogin.Password;
            _repositoryManager.BaseRepository.ExcuteStoreProcedure(command);
        }
    }
}
