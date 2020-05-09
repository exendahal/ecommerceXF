using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace eCommerce.Model
{
    public class TrackViewModel 
    {

       // bool includeEmptyGroups;
        public List<TrakGroup> track { get; private set; } = new List<TrakGroup>();

        public TrackViewModel(bool emptyGroups = false)
        {
           // includeEmptyGroups = emptyGroups;
            CreateTrackCollection();
        }

        void CreateTrackCollection()
        {


            track.Add(new TrakGroup("Sept 23, 2018", new List<Track>
            {
                new Track
                {
                    orderId = "OD - 424923192 - N",
                    price = "$4500",
                    status = "Delivered",
                    numberofItems = 5
                },
               
                
            }));

            track.Add(new TrakGroup("Sept 23, 2018", new List<Track>
            {
                new Track
                {
                    orderId = "OD - 424923192 - N",
                    price = "$500",
                    status = "Delivered",
                    numberofItems = 5
                },
                new Track
                {
                    orderId = "OD - 424923192 - N",
                    price = "$700",
                    status = "Delivered",
                    numberofItems = 5
                }
               
            }));

            track.Add(new TrakGroup("Sept 22, 2018", new List<Track>
            {
                new Track
                {
                    orderId = "OD - 424923192 - N",
                    price = "$1500",
                    status = "Delivered",
                    numberofItems = 5
                },
                new Track
                {
                    orderId = "OD - 424923192 - N",
                    price = "$2700",
                    status = "Delivered",
                    numberofItems = 5
                }

            }));


        }
    }
}
