using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
     class Student
    {
        public String Name= " ";
        public double First;
        public double Second;
        public double Third;
        public String Situation = "";


        public double Show_media()
        {
            return First + Second + Third;
        }

        public String Analyze()
        {
            return Situation = Show_media() > 60.00 ? "APROVADO" : "REPROVADO";
        }

        public override string ToString()
        {
            return "Nome:" + Name
                + " Media:" + Show_media()
                + " Situação:" + Analyze();
                ;
        }


    }
}
