using LoginFlowTest.Pages;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginFlowTest.ViewModels
{
    public class ViewModel_Logout
    {
        #region events

        #endregion

        #region vars

        #endregion

        #region properties
        public ICommand Command_Logout { get; set; }
        #endregion

        #region commands

        #endregion

        #region ctors
        public ViewModel_Logout()
        {
            InitCommands();
        }
        #endregion

        #region command methods
        void Command_Logout_Click()
        {
            Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
        #endregion

        #region methods
        void InitCommands()
        {
            if (Command_Logout == null) Command_Logout = new Command(Command_Logout_Click);
        }
        #endregion
    }
}
