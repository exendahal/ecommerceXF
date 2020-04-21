using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eCommerce.Model
{
    public class CardViewModel : INotifyPropertyChanged
    {
        readonly IList<CartModel> source;
        public ObservableCollection<CartModel> itemPreview { get; private set; }

        public ICommand DeleteCommand => new Command<CartModel>(RemoveCart);

        public CardViewModel()
        {
            source = new List<CartModel>();
            CreateItemCollection();
        }

        void RemoveCart(CartModel cart)
        {
            if (itemPreview.Contains(cart))
            {
                itemPreview.Remove(cart);
            }
        }
        void CreateItemCollection()
        {
            source.Add(new CartModel
            {
                image = "Item1",
                name = "Tag Heuer Wristwatch",
                price = "$2400",
                numbers = 1
            });
            source.Add(new CartModel
            {
                image = "Item2",
                name = "BeoPlay Speaker",
                price = "$4400",
                numbers = 1
            });
            source.Add(new CartModel
            {
                image = "Item3",
                name = "Electric Kettle",
                price = "$400",
                numbers = 1
            });
            source.Add(new CartModel
            {
                image = "Item4",
                name = "Bang & Olufsen Case",
                price = "$4500",
                numbers = 1
            });
            itemPreview = new ObservableCollection<CartModel>(source);           

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
