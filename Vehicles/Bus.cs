﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPark.Vehicles
{
    internal class Bus : Vehicle
    {
        public int PassengerCaparcity
        { get; set; }

        public void BusPropertiesOutput()
        {
            Console.WriteLine($"{Model} Characteristics: ");
            Console.WriteLine($"Passenger Caparcity: {PassengerCaparcity}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Max Speed: {maxSpeed} km/h");
            Console.WriteLine($"Power: {Power} hp");
            Console.WriteLine($"Max Load: {MaxLoad} kg\n");
            engine.EngineOutput();
            chassis.ChassisOutput();
            transmission.TransmissionOutput();
            Console.WriteLine("\n");
        }
    }
}
