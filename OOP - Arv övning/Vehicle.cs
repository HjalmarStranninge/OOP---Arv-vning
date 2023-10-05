using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP___Arv_övning
{
    internal abstract class Vehicle
    {
        public string Model {  get; set; }
        public string Year { get; set; }
        public int Mileage {  get; private set; }
        public void SetMileage(int kilometersDriven)
        {
            Mileage = kilometersDriven;
        }
        public abstract void PrintInfo();
        
    }
}
