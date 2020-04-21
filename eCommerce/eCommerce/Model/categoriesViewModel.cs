using eCommerce.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eCommerce.Model
{  
    public class categoriesViewModel : INotifyPropertyChanged
    {
        readonly IList<FeaturedBrands> source1;
        public ObservableCollection<FeaturedBrands> featuredItemPreview { get; private set; }

        readonly IList<ItemsPreview> source;
        public ObservableCollection<ItemsPreview> itemPreview { get; private set; }
       
        public categoriesViewModel()
        {
            source = new List<ItemsPreview>();
            source1 = new List<FeaturedBrands>();
            CreateItemCollection();
            CreateFeaturedItemCollection();
        }       

        void CreateItemCollection()
        {
            source.Add(new ItemsPreview
            {
                ImageUrl = "Image3",
                Name = "Smart Bluetooth Speaker",
                brand = "Google LLC",
                price = "$90"
            });
            source.Add(new ItemsPreview
            {
                ImageUrl = "Image5",
                Name = "Smart Luggage",
                brand = "Smart Inc",
                price = "$450"
            });
            source.Add(new ItemsPreview
            {
                ImageUrl = "Image6",
                Name = "Wireless Remote",
                brand = "Tesla Inc",
                price = "$790"
            });
            source.Add(new ItemsPreview
            {
                ImageUrl = "Image4",
                Name = "Airpods",
                brand = "Apple Inc",
                price = "$120"
            });
            itemPreview = new ObservableCollection<ItemsPreview>(source);
        }

        void CreateFeaturedItemCollection()
        {
            source1.Add(new FeaturedBrands
            {
                ImageUrl = "Icon_Apple",
                brand = "Apple Inc",
                details = "5693 Products"
            });
            source1.Add(new FeaturedBrands
            {
                ImageUrl = "beats",
                brand = "Beats",
                details = "1124 Products"
            });
            source1.Add(new FeaturedBrands
            {
                ImageUrl = "Icon_Bo",
                brand = "B&o",
                details = "5693 Products"
            });

            featuredItemPreview = new ObservableCollection<FeaturedBrands>(source1);
        }

      
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }


}
