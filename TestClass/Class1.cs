using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3_Triangle;
using NUnit.Framework;


namespace TestClass
{
    public class TriangleTestCases
    {
        [TestFixture]

        public class TriangleTest
        {
            [Test]
            public void ValidTriangle_Input60and60and60_OutputValidTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 8805350;
                int thirdAngle = 60;

                string expectedResult = "The triangle is valid.";

                //Act
                string actualResult = Triangle.ValidTriangleJS(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expectedResult, actualResult);
            }
        }
    

    }

}
