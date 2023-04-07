using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animals_registry
{
    internal class Counter
    {
        private int count;

        public void Add()
        {
            count++;
        }

        public void Dispose()
        {
            if (count > 0)
            {
                throw new InvalidOperationException("Counter was not properly disposed.");
            }
        }
    }
}
