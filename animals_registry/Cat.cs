using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace animals_registry
{
    internal class Cat: Pet
    {
        public string Color { get; set; }

        public Cat(string name, int age, double weight, string color) : base(name, age, weight)
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"Кошка: {base.ToString()}, Окрас: {Color}";
        }

        public override void Train(string command)
        {
            Console.WriteLine($"Кошка {Name} выполняет команду \"{command}\"");
        }
    }
}
