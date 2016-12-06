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
        /// <summary>
        /// The parent class for all triangles
        /// </summary>
        protected Triangle()
        {
        }

        /// <summary>
        /// Tries to create a triangle of specific type based on inputs.
        /// </summary>
        /// <param name="a">side a</param>
        /// <param name="b">side b</param>
        /// <param name="c">side c</param>
        /// <returns>Equilateral, Isosceles, Scalene or NotTriangle</returns>
        public static object CreateTriangle(double a, double b, double c)
        {
            // Starts out with NotTriangle, and work towards the triangle goal
            object returnValue = new NotTriangle();

            // Only proceed with the acceptable length
            if (a > 0 && b > 0 && c > 0)
            {
                // Have a list to store all sides
                List<double> sides = new List<double>();

                // No length can be in negative
                sides.Add(a);
                sides.Add(b);
                sides.Add(c);

                // The easiest solution to test for triangle, is to find the sides of the same length
                switch (sides.Distinct().Count())
                {
                    case 1:
                        // All sides has unique length
                        returnValue = new Equilateral();
                        break;
                    case 2:
                        // 2 sides have the same length
                        returnValue = new Isosceles();
                        break;
                    case 3:
                        // All 3 sides has the same lengths
                        returnValue = new Scalene();
                        break;
                    default:
                        break;

                }
            }

            return returnValue;
        }
    }


    /// <summary>
    /// Not a triangle
    /// </summary>
    public class NotTriangle
    {
    }


    /// <summary>
    /// Equilateral - Triangle with the same length on all sides
    /// </summary>
    public class Equilateral : Triangle
    {
        public Equilateral()
            : base()
        {
        }
    }


    /// <summary>
    /// Isosceles - Triangle with 2 sides of the same length
    /// </summary>
    public class Isosceles : Triangle
    {
        public Isosceles()
            : base()
        {
        }
    }


    /// <summary>
    /// Scalene - Triangle with all sides in different lengths
    /// </summary>
    public class Scalene : Triangle
    {
        public Scalene()
            : base()
        {
        }
    }
}
