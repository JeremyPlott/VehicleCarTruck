using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleCarTruckLibrary {

    public class Truck : Vehicle {
        public bool Cap { get; set; }
        public bool Diesel { get; set; }
        public string Bedsize { get; set; }



        public override string Print() {
            var hasCap = (Cap == true) ? "Yes" : "No";
            var hasDsl = (Diesel == true) ? "Yes" : "No";

            return base.Print() + $" | Cap: {hasCap, -5} | Diesel: {hasDsl, -5} | Bedsize: {Bedsize, -5} | ";
        }

        public Truck(bool cap, bool diesel, string bedsize, string vin, string make, string model, string trim, decimal price) 
            : base(vin, make, model, trim, price) {
            Cap = cap;
            Diesel = diesel;
            Bedsize = bedsize;
        } 
    }
}
