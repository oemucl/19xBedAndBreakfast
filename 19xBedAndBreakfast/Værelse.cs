using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19xBedAndBreakfast
{
    public class Værelse
    {
        private int RoomNo;
        private float Price;
        private int Beds;

        public Værelse(int roomNo, float price, int beds)
        {
            RoomNo = roomNo;
            Price = price;
            Beds = beds;
        }

    }
}
