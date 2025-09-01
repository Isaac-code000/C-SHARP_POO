using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_06.Entities
{
    internal class Log
    {
        public string Name { get; set; }
        public DateTime Moment { get; set; }

        public Log(string name, DateTime moment)
        {
            Name = name;
            Moment = moment;
        }

        override public bool Equals(object obj)
        {
           if(!(obj is Log))
            {
                return false;
            }
            Log other = obj as Log;
            return Name.Equals(other.Name);
        }

        override public int GetHashCode()
        {
            return Name.GetHashCode();
        }

        override public string ToString()
        {
            return Name + ", " + Moment;
        }
    }
}
