using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Finder
{
    /*
     * Parent Triangle class
     */
    public abstract class Triangle
    {
        protected List<double> sides;

        protected Triangle()
        {
            sides = new List<double>();
        }

        /*
         * CreateTriangle returns a new triangle type based on inputs.
         * 
         * WIP
         */
        public static Triangle CreateTriangle(double a, double b, double c)
        {
            List<double> sides = new List<double>();
            sides.Add(a);
            sides.Add(b);
            sides.Add(c);
            sides.Sort();

            int counter = 0;
            double sumOfSides = 0;
            foreach (var side in sides)
            {
                ++counter;
                sumOfSides += side;
            }
            return new Equilateral();
        }

        /*
         * A functional programming implementation of the loop to get triangle type.
         * 
         * WIP
         */
        protected static Type TriangleType(double average, double total, double side, int count, Queue<double> sidesLeft)
        {
            Type triangleType = null;

            if (sidesLeft.Count > 0)
            {
                return TriangleType((total + sidesLeft.Peek()) / (count + 1), total + sidesLeft.Peek(), sidesLeft.Dequeue(), count + 1, sidesLeft);
            }

            switch (count)
            {
                case 2:
                    if (average == side)
                        triangleType = typeof(Isosceles);
                    break;
                case 3:
                    if (average == side)
                        triangleType = typeof(Equilateral);
                    break;
                default:
                    triangleType = typeof(Scalene);
                    break;
            }
            return triangleType;
        }
    }

    /*
     * Triangle with the same length on all sides
     */
    public class Equilateral : Triangle
    {
        public Equilateral()
            : base()
        {
        }
    }

    /*
     * Triangle with 2 sides of the same length
     */
    public class Isosceles : Triangle
    {
        public Isosceles()
            : base()
        {
        }
    }

    /*
     * Triangle with all sides in different lengths
     */
    public class Scalene : Triangle
    {
        public Scalene()
            : base()
        {
        }
    }
}
