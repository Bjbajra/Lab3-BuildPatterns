using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF.Houses
{
    public class NormalHouse : House
    {
        //(int noOfRooms, int noOfWindows, string streeAdress, bool hasSwimmingPool, int parkingSpotsInGarage)
        public NormalHouse() : base(
            2, 
            3, 
            "Newroad 12", 
            false, 
            0)
        {}
    }
}
