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

      
    }
}