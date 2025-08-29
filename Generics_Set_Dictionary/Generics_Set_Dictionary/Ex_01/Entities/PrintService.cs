using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01.Entities
{
    internal class PrintService<T>
    {

        private T[] _values = new T[10];  
        private int _count = 0;  


        public void Add(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
                _values[_count] = value;
                _count++;
        }

        public void Print()
        {
            Console.Write("Values: ");
            Console.Write("[");
            for(int i = 0; i < _count-1;i++ )
            {
                Console.Write(_values[i] + ",");
            }
            if(_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.Write("]");
            Console.WriteLine();
            
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }




    }
}
