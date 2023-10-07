using DAMau_BLL._IServices;
using DAMau_BLL._Services;
using DAMau_DAL.IRepositories;
using DAMau_DAL.Repostiories;
using DAMau_Presentation;
using DAMau_Presentation.Presenters;
using DAMau_Presentation.views;

namespace DAMau
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ILoginView view = new LoginView();
            IRepositoryManager repositoryManager = new RepositoryManager();
            IAuthenticationService authenticationService = new AuthenticationService(repositoryManager);
            new LoginPresenter(view, authenticationService);
            Application.Run((Form)view);
           
        }
    }
}