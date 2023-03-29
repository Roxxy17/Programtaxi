using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTaxi
{
    public class taxi
    {
        //Properties
        public string DriverName{ get; set; }
        public int NumPassenger { get; set; }
        public bool OnDuty { get; set; }
            
        //Method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name : {0}", DriverName);
            Console.WriteLine("Number of Pasangger {0}", NumPassenger);
            if (OnDuty == true)
            {
                Console.WriteLine("On Duty : Yes");
            }
            else
            {
                Console.WriteLine("On Duty : No");
            }
        }
        public void PickUpPassanger()
        {
            Console.WriteLine("{0} sedang menjemput penumpang\n", DriverName);
        }
        public void DropOffPassanger()
        {
            Console.WriteLine("{0} sedang Mengantar penumpang\n", DriverName);
        }
      
   }
}
