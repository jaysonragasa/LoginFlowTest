using LoginFlowTest.Pages;
using Xamarin.Forms;

namespace LoginFlowTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            RegisterPage();

            MainPage = new AppShell();
        }

        void RegisterPage()
        {
            // register other pages not part in AppShell
            Routing.RegisterRoute(nameof(LoginPage) + "/" + nameof(RegistrationPage), typeof(RegistrationPage));
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
