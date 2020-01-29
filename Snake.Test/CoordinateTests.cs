using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Snake.Test
{
    [TestClass]
    [TestCategory("Coordinate Tests")]
    public class CoordinateTests
    {
        [TestMethod]
        public void OverrideEqualReturnTrue()
        {
            //arrange
            Coordinate coordinate1 = new Coordinate(5, 10);
            Coordinate coordinate2 = new Coordinate(5, 10);

            //act
            var output = coordinate1.Equals(coordinate2);

            //assert
            Assert.IsTrue(output);
        }
    }
}
