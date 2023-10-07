namespace DAMau_Presentation.views
{
    public partial class LoginView : Form, ILoginView
    {
        private string errorMessage;
        private bool isSuccessful;

        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            btn_Login.Click += delegate { LogIn?.Invoke(this, EventArgs.Empty); };
            txtBox_password.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    LogIn?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string UserName { get { return txtBox_username.Text; } set { txtBox_username.Text = value; } }

        public string Password { get { return txtBox_password.Text; } set { txtBox_password.Text = value; } }

        public bool IsSuccessful { get { return isSuccessful; } set { isSuccessful = value; } }

        public string ErrorMessage { get { return errorMessage; } set { errorMessage = value; } }

        public event EventHandler LogIn;
    }
}
