using System;
using System.Collections.Generic;
using VehicleCarTruckLibrary;

namespace VehicleCarTruck {
    class Program {

        void Run() {

            //var vehicles = new list<Vehicle>();
            //vehicles.Add(new Car(~~~~~~~~));
            //foreach(vehicle in vehicles) {
            //  Console.WriteLine(Print());
            //}

            var vehicles = new List<Vehicle>();
            vehicles.Add(new Car(true, false, true, "8375622", "McLaren", "F1", "High trim", 230000));
            vehicles.Add(new Car(false, true, false, "3856211", "Toyota", "Highlander", "Low trim", 7000));
            vehicles.Add(new Car(false, true, true, "9561561", "Tesla", "Model X", "Mid trim", 65000));

            vehicles.Add(new Truck(false, false, "large", "9475626", "Ford", "F150", "Mid trim", 50000));
            vehicles.Add(new Truck(true, true, "giant", "4866252", "Volkswagen", "Hercules Beetle", "High trim", 852000));
            vehicles.Add(new Truck(false, true, "small", "6736251", "Ferrari", "Teaspoon", "Low trim", 33333));

            foreach(var vehicle in vehicles) {
                Console.WriteLine(vehicle.Print());
            }

            //foreach(var vehicle in vehicles) { //can't figure out how to base.print
            //    Console.WriteLine(vehicle.Print());
            //}
        }

        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();
        }
    }
}
