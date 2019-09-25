using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestXam.Common.DataAccess;
using TestXam.Common.DTO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestXam
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContentIndex : ContentPage
	{
        private PaisData _paises;
		public ContentIndex ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _paises = new PaisData();
            ListPaises.ItemsSource = _paises.GetPaises();
        }

        private void ListPaises_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if(e.SelectedItem != null)
            {
                var element = e.SelectedItem as PaisDTO;
                if(element.Id == 7)
                {
                    List<string> images = new List<string>();
                    //images.Add("https://source.unsplash.com/random");
                    //images.Add("https://source.unsplash.com/random");
                    CarouselPaises.ItemsSource = images;
                }
                CarouselPaises.ItemsSource = element.Pictures;
            }

        }
    }
}