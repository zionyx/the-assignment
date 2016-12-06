using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle.Finder.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class UnitTests
    {

        /// <summary>
        /// Verify that the input of 6, 6, 6 is an Equilateral
        /// </summary>
        [Test]
        public void VerifyEquilateral()
        {
            CheckForTriangleTypes(6, 6, 6, typeof(Equilateral));
        }

        /// <summary>
        /// Verify that the input of 6, 4, 6 is an Isosceles
        /// </summary>
        [Test]
        public void VerifyIsosceles()
        {
            CheckForTriangleTypes(6, 4, 6, typeof(Isosceles));
        }

        /// <summary>
        /// Verify that sides of 3, 5, 6 is not Equilateral, not Isosceles, but a Scalene
        /// </summary>
        [Test]
        public void VerifyScalene()
        {
            CheckForTriangleTypes(3, 5, 6, typeof(Scalene));
        }

        /// <summary>
        /// With the values below, the object returned must not be any triangle type
        /// </summary>
        [Test]
        public void VerifyNotTriangle()
        {
            // Test for 0 length
            CheckForTriangleTypes(0, 5, 6, typeof(NotTriangle));
            // Test for negative length
            CheckForTriangleTypes(3, -1, 6, typeof(NotTriangle));
        }

        public void CheckForTriangleTypes(double a, double b, double c, Type expectedType)
        {
            object triangle = Triangle.CreateTriangle(a, b, c);

            // Get the type of these triangle
            Type triType = triangle.GetType();

            // Compare that the generated type is a Scalene
            Assert.IsTrue(triType.Equals(expectedType));
        }
    }
}
