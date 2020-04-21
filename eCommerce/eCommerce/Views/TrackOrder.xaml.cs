using eCommerce.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eCommerce.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrackOrder : ContentPage
    {
       
        public TrackOrder()
        {
            InitializeComponent();
            BindingContext = new TrackViewModel();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

        }

        async void OnItemSelected(object sender, SelectionChangedEventArgs e)
        {

            await Navigation.PushModalAsync(new StepView());
        }
    }
}