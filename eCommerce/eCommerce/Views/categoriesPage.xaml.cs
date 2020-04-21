using eCommerce.Model;
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
    public partial class categoriesPage : ContentPage
    {
        public categoriesPage(string titleName)
        {
            InitializeComponent();
            title.Text = titleName;

        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
           
        }

        async void OnBrandsSelected(object sender, SelectionChangedEventArgs e)
        {            
            string current = (e.CurrentSelection.FirstOrDefault() as FeaturedBrands)?.brand;
            await Navigation.PushModalAsync(new BrandPage(current));
        }

        async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
            string current = (e.CurrentSelection.FirstOrDefault() as ItemsPreview)?.Name;
            await Navigation.PushModalAsync(new ProductPage());
        }
    }
}