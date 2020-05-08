using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Text;
using Xamarin.Forms;

namespace eCommerce.Model
{
    public class DeliveryStepsViewModel
    {
        readonly IList<DeliverySteps> source;
        public ObservableCollection<DeliverySteps> delList { get; private set; }

        int currentFlag = 3; //Starts from 0
        List<tempData> tempData = new List<tempData>() {
            new tempData
            {
                Name="Order Signed",
                Location="Lagos State, Nigeria",
                dateMon="20/18",
                tim="10:00 AM"
            },
            new tempData
            {
                Name="Order Signed",
                Location="Lagos State, Nigeria",
                dateMon="20/18",
                tim="10:00 AM"
            },
            new tempData
            {
                Name="Order Signed",
                Location="Lagos State, Nigeria",
                dateMon="20/18",
                tim="10:00 AM"
            },
            new tempData
            {
                Name="Order Signed",
                Location="Lagos State, Nigeria",
                dateMon="20/18",
                tim="10:00 AM"
            },
            new tempData
            {
                Name="Order Signed",
                Location="Lagos State, Nigeria",
                dateMon="20/18",
                tim="10:00 AM"
            }

        };
        public DeliveryStepsViewModel()
        {
            source = new List<DeliverySteps>();
            CreateCollection();
        }
        void CreateCollection()
        {
          
            Xamarin.Forms.Color frColor = Xamarin.Forms.Color.FromHex("#00C569");
            Xamarin.Forms.Color linColor = Xamarin.Forms.Color.FromHex("#00C569");
           
                for (int  i=0;i< tempData.Count;i++)
                {
                    if (i == (tempData.Count - 1))
                    {
                    linColor = Xamarin.Forms.Color.Transparent;
                    }
                    else
                    {
                        if (i<currentFlag)
                        {
                            frColor = Xamarin.Forms.Color.FromHex("#00C569");
                            linColor = Xamarin.Forms.Color.FromHex("#00C569");
                          }
                        else
                        {
                            frColor = Xamarin.Forms.Color.Transparent;
                            linColor = Xamarin.Forms.Color.FromHex("#DDDDDD");
                        }
                    }
                    source.Add(new DeliverySteps
                    {
                        Name = tempData[i].Name,
                        Location = tempData[i].Location,
                        dateMon = tempData[i].dateMon,
                        tim = tempData[i].tim,
                        colorFrame = frColor,
                        colorLine = linColor
                    });

                }    
             delList = new ObservableCollection<DeliverySteps>(source);
        }

    }

    public class tempData
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string dateMon { get; set; }
        public string tim { get; set; }
    }
}
