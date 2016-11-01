using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift11
{
     abstract class Vehicle
    {
        public string VehicleType { get; set;}
        public Vehicle(string VehicleType)
        {
            this.VehicleType = VehicleType;
        }
        public virtual string DescribeVehicle()
        {          
            return ("The vehicles type is: " + VehicleType);
        }
    }
    class Car : Vehicle

    {
        public bool engineIsRunning = false;
        public Car(string type) : base("Car")
        {
            this.VehicleType = VehicleType;
           
        }
        public void StartEngine()
        {
            engineIsRunning = true;
                
        }
        public void StopEngine()
        {
            engineIsRunning = false;           
        }
        public override string DescribeVehicle()
        {
            return "The vehicles type is: " + this.VehicleType + "\nIs the engine running?" + engineIsRunning;
        }
    }
    class Boat : Vehicle
    {
        public Boat(string VehicleType) : base("Boat")
        {
            this.VehicleType = VehicleType;
        }
        public override string DescribeVehicle()
        {
            
            return "The vehicles type is: " + VehicleType;
        }

    }
}
