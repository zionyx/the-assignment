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
        protected List<int> sides;

        public Triangle()
        {
        }

        /*
         * CreateTriangle returns a new triangle type based on inputs
         */
        public static Triangle CreateTriangle(int a, int b, int c)
        {
            return null;
        }
    }

    public class Equilateral : Triangle
    {

        public Equilateral()
            : base()
        {
        }
    }

    public class Isosceles : Triangle
    {
    }

    public class Scalene : Triangle
    {
    }
}
