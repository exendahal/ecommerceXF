using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace eCommerce.Model
{
    public class ProductViewModel: INotifyPropertyChanged
    {
        readonly IList<Reviews> source;
        public ObservableCollection<Reviews> itemPreview { get; private set; }

        public ProductViewModel()
        {
            source = new List<Reviews>();            
            CreateItemCollection();
        }

        void CreateItemCollection()
        {
            source.Add(new Reviews
            {
                image = "user1",
                name = "Samuel Smith",
                review = "Wonderful jean, perfect gift for my girl for our anniversary!",
                rating = "4"
            });
            source.Add(new Reviews
            {
                image = "user2",
                name = "Beth Aida",
                review = "I love this, paired it with a nice blouse and all eyes on me.",
                rating = "3"
            });
            source.Add(new Reviews
            {
                image = "user1",
                name = "Samuel Smith",
                review = "Wonderful jean, perfect gift for my girl for our anniversary!",
                rating = "4"
            });
            source.Add(new Reviews
            {
                image = "user2",
                name = "Beth Aida",
                review = "I love this, paired it with a nice blouse and all eyes on me.",
                rating = "3"
            });
            itemPreview = new ObservableCollection<Reviews>(source);
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
