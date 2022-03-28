using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Cargo:Car
    {
        public uint LoadCapacity { get; set; }
        public Cargo() { }
        public Cargo(uint loadCapacity, string model, string number)
        {
            LoadCapacity = loadCapacity;    
            Model = model;  
            Number = number;    
        }
        public override void Show()
        {
            Console.WriteLine($"Грузовой автомобиль: марка { Model}, номер  { Number}, грузоподьемность  { LoadCapacity}");
        }
    }
}
