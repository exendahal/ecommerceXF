using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace eCommerce.Model
{
    public class BrandViewModel : INotifyPropertyChanged
    {
        readonly IList<BrandsItems> source;
        readonly IList<ItemsPreview> source1;
        public ObservableCollection<BrandsItems> itemList{ get; private set; }
        public ObservableCollection<ItemsPreview> itemPreview { get; private set; }

        ICommand tapCommand;
        public  BrandViewModel()
        {
            source = new List<BrandsItems>();
            source1 = new List<ItemsPreview>();
            CreateMenuCollection();
            CreateItemCollection();
        }

        public ICommand TapCommand
        {
            
            get { 
                return tapCommand; 
            }
        }
        void CreateItemCollection()
        {
            source1.Add(new ItemsPreview
            {
                ImageUrl = "Image1",
                Name = "Smart Bluetooth Speaker",
                brand = "Bang and Olufsen",
                price = "$90"
            });
            source1.Add(new ItemsPreview
            {
                ImageUrl = "Image7",
                Name = "B&o Desk Lamp",
                brand = "Bang and Olufsen",
                price = "$450"
            });
            source1.Add(new ItemsPreview
            {
                ImageUrl = "Image8",
                Name = "BeoPlay Stand Speaker",
                brand = "Bang and Olufsen",
                price = "$300"
            });
            source1.Add(new ItemsPreview
            {
                ImageUrl = "Image9",
                Name = "Airpods",
                brand = "B&o Phone Case",
                price = "$30"
            });
            itemPreview = new ObservableCollection<ItemsPreview>(source1);
        }
        void CreateMenuCollection()
        {
            source.Add(new BrandsItems
            {                
                brand = "Bang and Olufsen",
                itemName = "All"
            });
            source.Add(new BrandsItems
            {
                brand = "Bang and Olufsen",
                itemName = "Headphones"
            });
            source.Add(new BrandsItems
            {
                brand = "Bang and Olufsen",
                itemName = "Speakers"
            });
            source.Add(new BrandsItems
            {
                brand = "Bang and Olufsen",
                itemName = "Microphones"
            });
            itemList = new ObservableCollection<BrandsItems>(source);
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
