using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eCommerce.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrandPage : ContentPage
    {
        public BrandPage(String name)
        {
            InitializeComponent();
            title.Text = name;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }

        async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {

            await Navigation.PushModalAsync(new ProductPage());
        }
    }
}