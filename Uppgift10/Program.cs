using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData vd = new VehicleData();
            Car car = new Car("");
            Boat boat = new Boat("");

            vd.PrintData(car);
            vd.PrintData(boat);
            Console.ReadLine();
           
        }
    }
}
