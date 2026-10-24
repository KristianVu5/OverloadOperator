using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1._2.StateOperator
{
    internal class Application
    {
        static void Main()
        {
            State s1 = new State { Name = "State1", Area = 300, Population = 100 };
            State s2 = new State { Name = "State2", Area = 200, Population = 700 }; 

            if(s1 > s2)
            {
                Console.WriteLine("State1 bigger than State2");
            }
            else if(s1 < s2)
            {
                Console.WriteLine("State1 smaller than State2");
            }
            else
            {
                Console.WriteLine("State1 equals State2");
            }

            State s3 = s1 + s2;
            Console.WriteLine("State name : {0}", s3.Name);
            Console.WriteLine("State area : {0}", s3.Area);
            Console.WriteLine("State population : {0}", s3.Population);

        }
    }
}
