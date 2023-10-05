using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Arv_övning
{
    internal class Truck : Vehicle
    {
        public double MaxLoadKg {  get; set; }
        public bool hasTrailer { get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Model: {Model}. Year: {Year}. Mileage: {Mileage}km. Max load: {MaxLoadKg}kg. Has trailer: {hasTrailer}.");
        }
    }
}
