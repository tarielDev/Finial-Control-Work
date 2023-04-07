using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace animals_registry
{
    internal class Dog: Pet
    {
        public string Breed { get; set; }

        public Dog(string name, int age, double weight, string breed) : base(name, age, weight)
        {
            Breed = breed;
        }

        public override string ToString()
        {
            return $"Собака: {base.ToString()}, Порода: {Breed}";
        }

        public override void Train(string command)
        {
            Console.WriteLine($"Собака {Name} выполняет команду \"{command}\"");
        }
    }
}
