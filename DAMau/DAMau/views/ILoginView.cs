using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAMau_Presentation.views
{
    public interface ILoginView
    {
        string UserName { get; set; }
        string Password { get; set; }

        bool IsSuccessful { get; set; }
        string ErrorMessage { get; set; }

        // events
        event EventHandler LogIn;

    }
}
