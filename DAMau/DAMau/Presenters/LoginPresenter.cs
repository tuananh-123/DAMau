using DAMau_BLL._IServices;
using DAMau_Dtos.AuthenticationDtos;
using DAMau_Presentation.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_Presentation.Presenters
{
    public class LoginPresenter
    {
        private ILoginView view;
        private IAuthenticationService authenticationService;

        public LoginPresenter(ILoginView view, IAuthenticationService authenticationService)
        {
            this.view=view;
            this.authenticationService = authenticationService;
            this.view.LogIn += CheckUserAuthentication;
        }

        private void CheckUserAuthentication(object? sender, EventArgs e)
        {
            var userInFor = new UserLoginInformation
            {
                Email = this.view.UserName, Password = this.view.Password
            };
            authenticationService.Login(userInFor);


        }
    }
}
