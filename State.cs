using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1._2.StateOperator
{
    internal class State
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double Area { get; set; }

        public static State operator +(State state1, State state2)
        {
            string name = state1.Name;
            int people = state1.Population + state2.Population;
            double area = state1.Area + state2.Area;

            return new State
            {
                Name = name,
                Area = area,
                Population = people
            };
        }

        public static bool operator > (State state1, State state2)
        {
            if(state1.Area > state2.Area)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static bool operator <(State state1, State state2)
        {
            if (state1.Area < state2.Area)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
