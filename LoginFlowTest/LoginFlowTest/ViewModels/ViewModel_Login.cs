using LoginFlowTest.Pages;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginFlowTest.ViewModels
{
    public class ViewModel_Login
    {
        #region events

        #endregion

        #region vars

        #endregion

        #region properties

        #endregion

        #region commands
        public ICommand Command_Login { get; set; }
        public ICommand Command_Register { get; set; }
        #endregion

        #region ctors
        public ViewModel_Login()
        {
            InitCommands();
        }
        #endregion

        #region command methods
        async void Command_Login_Click()
        {
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }

        async void Command_Register_Click()
        {
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}/{nameof(RegistrationPage)}");
        }
        #endregion

        #region methods
        void InitCommands()
        {
            if (Command_Login == null) Command_Login = new Command(Command_Login_Click);
            if (Command_Register == null) Command_Register = new Command(Command_Register_Click);
        }
        #endregion
    }
}
