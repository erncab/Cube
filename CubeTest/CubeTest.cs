using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeTest
{
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void GetVolumeWithoutOuterMostLayer()
        {
            // Arrange
            const int sideLength = 1;
            const int expectedVolume = 0;

             var cube = new Cube.Cube(sideLength);

            // Act
            var volume = cube.GetVolume();

            // Assert
            Assert.AreEqual(volume, expectedVolume);

            Console.WriteLine("sideLength: {0}", sideLength);
            Console.WriteLine("volume: {0}", volume);
        }

        [TestMethod]
        public void GetVolume()
        {
            // Arrange
            const int sideLength = 2;
            const int expectedVolume = 8;

            var cube = new Cube.Cube(sideLength);

            // Act
            var volume = cube.GetVolume();

            // Assert
            Assert.AreEqual(volume, expectedVolume);

            Console.WriteLine("sideLength: {0}", sideLength);
            Console.WriteLine("volume: {0}", volume);
        }
    }
}
