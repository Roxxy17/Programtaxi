using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
    class program
    {
        static void Main(string[] args)
        {
            taxi taxi = new taxi();

            taxi.DriverName = "Kalila Atha Achmad";
            taxi.OnDuty = false;
            taxi.NumPassenger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Console.ReadKey();
           
        }
      

    }
}