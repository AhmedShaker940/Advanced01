using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.Question08
{
    internal class Inventory2<T> where T : class
    {
        public T Value { get; set; }
        public Inventory2(T value)
        {
            Value = value;
        }

    }
}
