using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03.Entities
{
    internal class Coment
    {
        public string Text { get; set; }
        public Coment(string text)
        {
            Text = text;
        }
        override public string ToString()
        {
            return Text; // Return the text of the comment
        }
    }
}
