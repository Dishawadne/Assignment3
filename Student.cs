using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Student
    {
        public void isEligible()
        {

            int phyMarks = 65;
            int chemMarks = 50;
            int mathMarks = 65;
             
            if(mathMarks >= 65 && phyMarks >= 55 && chemMarks >= 50 && (mathMarks + phyMarks + chemMarks >= 180 || mathMarks + phyMarks >= 140)){
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("Not Eligiable for admission");
            }

        }
    }
}
