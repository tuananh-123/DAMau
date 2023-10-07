using DAMau_Dtos.AuthenticationDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_BLL._IServices
{
    public interface IAuthenticationService
    {
        void Login(UserLoginInformation userLogin);
    }
}
