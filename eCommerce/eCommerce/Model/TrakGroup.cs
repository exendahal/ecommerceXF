using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Model
{
    public class TrakGroup : List<Track>
    {

        public string Date { get; private set; }

        public TrakGroup(string date, List<Track> tracks) : base(tracks)
        {
            Date = date;
        }

        public override string ToString()
        {
            return Date;
        }

    }
}
