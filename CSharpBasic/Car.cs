using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
{
    internal class Car
    {
        private string _model = "";

        private string _brand = "";

        public string Model { get; set; }
        public string Brand
        {
            get => _brand;
            set { _brand = value; }
        }

        public Car() { }
        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
            Console.WriteLine("Hello " + model);
        }
       
        public void Print()
        {
            Console.WriteLine();
        }
     }
}
