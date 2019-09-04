using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCarTruckLibrary {

    public class Car : Vehicle {
        public bool Convertible { get; set; }
        public bool Hatchback { get; set; }
        public bool Hybrid { get; set; }

        public override string Print() {
            var hasCvrtbl = (Convertible == true) ? "Yes" : "No";
            var hasHatch = (Hatchback == true) ? "Yes" : "No";
            var hasHyb = (Hybrid == true) ? "Yes" : "No";

            return base.Print() + $" | Convertible: {hasCvrtbl, -5} | Hatchback: {hasHatch, -5} | Hybrid: {hasHyb, -5} | ";
        }

        public Car(bool convertible, bool hatchback, bool hybrid, string vin, string make, string model, string trim, decimal price) 
            : base(vin, make, model, trim, price) {
            Convertible = convertible;
            Hatchback = hatchback;
            Hybrid = hybrid;
        }
    }
}
