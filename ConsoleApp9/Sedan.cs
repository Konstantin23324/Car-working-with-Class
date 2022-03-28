using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Sedan:Car
    {
        public uint NumberOfPlaces { get; set; }
        public Sedan() { }
        public Sedan(uint numberOfplaces,string model,string number)
        {
            NumberOfPlaces = numberOfplaces;    
            Model = model;  
            Number = number;
        }
        public override void Show()
        {
            Console.WriteLine($"Легковой автомобиль: марка  { Model}, номер  { Number}, число пассажирских мест  { NumberOfPlaces }");
        }
    }
}
