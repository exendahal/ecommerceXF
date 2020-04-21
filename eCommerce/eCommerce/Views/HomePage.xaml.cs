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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();           
        }

        async void OnCatItemSelected(object sender, SelectionChangedEventArgs e)
        {
            string current = (e.CurrentSelection.FirstOrDefault() as Category)?.title;
            await Navigation.PushModalAsync(new categoriesPage(current));
        }
        async void OnBrandsSelected(object sender, SelectionChangedEventArgs e)
        {
            string current = (e.CurrentSelection.FirstOrDefault() as FeaturedBrands)?.brand;
            await Navigation.PushModalAsync(new BrandPage(current));
        }

        async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {
           
            await Navigation.PushModalAsync(new ProductPage());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BrandPage("Recommended"));
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new BrandPage("Best Selling"));
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Cart());
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Account());
        }

        protected override bool OnBackButtonPressed()
        {
            return false;
        }
        }
    }