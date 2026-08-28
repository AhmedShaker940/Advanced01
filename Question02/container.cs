using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01Advanced.Question02
{
    // Q2: Write a generic class Container<T> with Add and Get methods.
    internal class container<T>
    {
        T box;

        public void Add(T item)
        {
            box = item;
        }

        public T Get()
        {
            return box;
        }
    }
}
