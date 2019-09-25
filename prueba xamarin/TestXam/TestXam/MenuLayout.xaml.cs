using TestXam.Common.DataAccess;
using TestXam.Common.DTO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuLayout : MasterDetailPage
	{
        private MenuData _menu;
        private UserDTO user;
        public string UserName;
        public MenuLayout ()
		{
            user = new UserDTO();
            UserName = user.Email;
            _menu = new MenuData();
			InitializeComponent ();
            CreateMenu();
        }

        public void CreateMenu()
        {
            ListMenu.ItemsSource = _menu.GetMenu();
            Detail = new NavigationPage(new ContentIndex());
        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var menuOption = e.SelectedItem as MenuDTO;
            if (menuOption != null)
            {
                IsPresented = false;
                if(menuOption.Page == null)
                {
                    App.CurrentApp.Logout();
                } else
                {
                    Detail = new NavigationPage(menuOption.Page);
                }
            }
        }
    }
}