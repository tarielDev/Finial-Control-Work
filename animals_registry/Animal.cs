using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals_registry
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Animal(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Имя: {Name}, Возраст: {Age}, Вес: {Weight}";
        }
    }
}
