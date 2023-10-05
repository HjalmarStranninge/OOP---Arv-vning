using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Arv_övning
{
    internal class Car : Vehicle
    {
        public int Seats {  get; set; }
        public int Doors {  get; set; }

        public override void PrintInfo()
        {
            Console.WriteLine($"Model: {Model}. Year: {Year}. Mileage: {Mileage}. Number of seats: {Seats}. Number of doors: {Doors}.");
        }
    }
}
