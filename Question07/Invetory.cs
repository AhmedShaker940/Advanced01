using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.Question07
{
    internal class Invetory<T> where T : struct
    {
        public T Value { get; set; }
        public Invetory(T value)
        {
            Value = value;
        }
    }
}
