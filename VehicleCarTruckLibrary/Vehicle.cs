using System;

namespace VehicleCarTruckLibrary {

    public class Vehicle {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Trim { get; set; }
        public decimal Price { get; set; }

        public virtual string Print() {
            return $"{VIN, -7} - {Make, -10} {Model, -17}: {Trim, -10}| {Price.ToString("C"), 12}";
        }

        public Vehicle(string vin, string make, string model, string trim, decimal price) {
            VIN = vin;
            Make = make;
            Model = model;
            Trim = trim;
            Price = price;
        }
    }
}
