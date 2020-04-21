using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace eCommerce.Model
{
    public class CartModel : INotifyPropertyChanged
    {
        public string image { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public int numbers { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;  
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public Command DecreseTapCommand
        {
            get
            {
                return new Command(val =>
                {
                    var modelObj = (CartModel)val;
                    if (modelObj.numbers >= 2)
                    {                        
                        numbers = (modelObj.numbers - 1);
                        OnPropertyChanged("numbers");
                    }
                   

                });
            }
        }

        public Command IncreaseTapCommand
        {
            get
            {
                return new Command(val =>
                {
                    numbers = (Int16.Parse(val.ToString()) + 1);
                    OnPropertyChanged("numbers");


                });
            }
        }
    }
}
