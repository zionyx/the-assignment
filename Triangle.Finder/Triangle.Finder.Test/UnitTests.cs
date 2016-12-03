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
        [Test]
        public void VerifyEquilateral()
        {
            Triangle triangle = Triangle.CreateTriangle(1, 1, 1);
            Type triType = triangle.GetType();
            Type equilateralType = typeof(Equilateral);
            Assert.IsTrue(triType.Equals(equilateralType));
        }

        [Test]
        public void VerifyIsosceles()
        {
            Triangle triangle = Triangle.CreateTriangle(1, 1, 1);
            Type triType = triangle.GetType();
            Type isoscelesType = typeof(Isosceles);
            Assert.IsTrue(triType.Equals(isoscelesType));
        }

        [Test]
        public void VerifyScalene()
        {
            Triangle triangle = Triangle.CreateTriangle(1, 1, 1);
            Type triType = triangle.GetType();
            Type scaleneType = typeof(Scalene);
            Assert.IsTrue(triType.Equals(scaleneType));
        }
    }
}
