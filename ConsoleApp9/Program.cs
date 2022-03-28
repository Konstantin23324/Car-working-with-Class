using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan sedan = new Sedan(5, "Ford","т915та");
            sedan.Show();
            Cargo cargo = new Cargo(50,"Volvo","т345та");
            cargo.Show();
            Console.ReadLine();

        }
    }
}
