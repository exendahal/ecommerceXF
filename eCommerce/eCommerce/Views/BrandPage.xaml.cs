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
    public partial class BrandPage : TabbedPage
    {
        public BrandPage(String name)
        {
            InitializeComponent();
            //title.Text = name;
            this.ItemsSource = new MainClass[] {
                new MainClass ("All",new List<ItemsPreview>(){ new ItemsPreview {ImageUrl = "Image1",Name = "Smart Bluetooth Speaker", brand = "Bang and Olufsen",price = "$90"}, new ItemsPreview { ImageUrl = "Image7", Name = "B&o Desk Lamp", brand = "Bang and Olufsen", price = "$450" },new ItemsPreview { ImageUrl = "Image8", Name = "BeoPlay Stand Speaker", brand = "Bang and Olufsen", price = "$300" } }),
                new MainClass ("Headphones",new List<ItemsPreview>(){ new ItemsPreview {ImageUrl = "Image1",Name = "Smart Bluetooth Speaker", brand = "Bang and Olufsen",price = "$90"}, new ItemsPreview { ImageUrl = "Image7", Name = "B&o Desk Lamp", brand = "Bang and Olufsen", price = "$450" },new ItemsPreview { ImageUrl = "Image8", Name = "BeoPlay Stand Speaker", brand = "Bang and Olufsen", price = "$300" } }),
                new MainClass ("Speakers",new List<ItemsPreview>(){ new ItemsPreview {ImageUrl = "Image1",Name = "Smart Bluetooth Speaker", brand = "Bang and Olufsen",price = "$90"}, new ItemsPreview { ImageUrl = "Image7", Name = "B&o Desk Lamp", brand = "Bang and Olufsen", price = "$450" },new ItemsPreview { ImageUrl = "Image8", Name = "BeoPlay Stand Speaker", brand = "Bang and Olufsen", price = "$300" } }),
                new MainClass ("Microphones",new List<ItemsPreview>(){ new ItemsPreview {ImageUrl = "Image1",Name = "Smart Bluetooth Speaker", brand = "Bang and Olufsen",price = "$90"}, new ItemsPreview { ImageUrl = "Image7", Name = "B&o Desk Lamp", brand = "Bang and Olufsen", price = "$450" },new ItemsPreview { ImageUrl = "Image8", Name = "BeoPlay Stand Speaker", brand = "Bang and Olufsen", price = "$300" } }),
                
            };
        }

        class MainClass
        {
            public MainClass(string name, IList<ItemsPreview> list)
            {
                this.Name = name;
                this.list = list;
            }

            public string Name { private set; get; }
            public IList<ItemsPreview> list { private set; get; }

            public override string ToString()
            {
                return Name;
            }
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