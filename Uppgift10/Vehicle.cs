using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift10
{
    public class Vehicle
    {
        public string VehicleType { get; set;}
        public Vehicle(string type)
        {
            VehicleType = type;
        }
        public string DescribeVehicle()
        {          
            return "The vehicles type is: " + VehicleType;
        }
    }
    class Car : Vehicle
    {
        public Car(string VehicleType) : base("Car")
        {
            VehicleType = VehicleType;
            bool engineIsRunning = false;
        }
        public void StartEngine(bool engineIsRunning)
        {
            engineIsRunning = true;    
        }
        public void StopEngine(bool engineIsRunning)
        {
            engineIsRunning = false;           
        }     
    }
    class Boat : Vehicle
    {
        public Boat(string VehicleType) : base("Boat")
        {
            VehicleType = VehicleType;
        }

    }
}
