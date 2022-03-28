using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    abstract class Car
    {
        public string Model { get; set; }
        public string Number { get; set; }
        public Car() { }
        public Car(string model, string number)
        {
            Model = model;  
            Number = number;    
        }
        public virtual void Show()
        {
            Console.WriteLine($"Model: {Model}, Number: {Number}");
        }
    }

}
