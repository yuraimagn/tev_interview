using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestXam.Common.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
        private ILoginManager _loginManager;
        public LoginPage(ILoginManager loginManager)
		{
			InitializeComponent ();
            _loginManager = loginManager;
        }

        void Login_Clicked(object sender, System.EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(Username.Text))
            {
                App.Current.Properties["email"] = Username.Text;
                App.Current.Properties["IsLoggedIn"] = true;

                _loginManager.ShowMainPage();
            }
        }

    }
}