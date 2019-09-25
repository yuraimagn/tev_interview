using System;
using TestXam.Common.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TestXam
{
    public partial class App : Application, ILoginManager
    {
        public static App CurrentApp;

        public App()
        {
            InitializeComponent();

            CurrentApp = this;
            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") ? (bool)Properties["IsLoggedIn"] : false;
            if (isLoggedIn)
                MainPage = new MenuLayout();
            else
                MainPage = new LoginPage(this);
        }

        public void ShowMainPage()
        {
            MainPage = new MenuLayout();
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false;
            MainPage = new LoginPage(this);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
