using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace animals_registry
{
    internal class Pet: Animal
    {
        public Pet(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public virtual void Train(string command)
        {
            Console.WriteLine($"Обучение {Name} команде \"{command}\"");
        }
    }
}
