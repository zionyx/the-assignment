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
        /// 
        /// Rules that defines a triangle:
        /// 1. All sides should have positive lengths.
        /// 2. Any one side MUST be smaller than the sum of the 2 other sides.
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
            // Starts out with NotTriangle, and work towards the Equilateral triangle goal
            // NotTriangle > Scalene > Isosceles > Equilateral
            Type triangleType = typeof(NotTriangle);
            object returnValue = null;

            // No length can be in negative
            if (a > 0 && b > 0 && c > 0)
            {
                // Any individual side should not be greater than the sum of other 2 sides
                if ((a + b) > c && (c + b) > a && (a + c) > b)
                {
                    // Basic triangle rule fullfilled, upgrades to Scalene
                    triangleType = typeof(Scalene);

                    // Check if any of the 2 sides are the same length
                    if ((a == b) || (b == c) || (a == c))
                    {
                        // Upgrade to Isosceles
                        triangleType = typeof(Isosceles);

                        if ((a == b) && (b == c))
                        {
                            // Upgrade to Equilateral
                            triangleType = typeof(Equilateral);
                        }
                    }
                }
            }

            // Create the object based on the outcome
            returnValue = (object)Activator.CreateInstance(triangleType);
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
    }


    /// <summary>
    /// Isosceles - Triangle with 2 sides of the same length
    /// </summary>
    public class Isosceles : Triangle
    {
    }


    /// <summary>
    /// Scalene - Triangle with all sides in different lengths
    /// </summary>
    public class Scalene : Triangle
    {
    }
}
