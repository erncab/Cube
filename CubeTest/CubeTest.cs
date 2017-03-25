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
            var volume = cube.GetVolumeWithoutOuterMostLayer();

            // Assert
            Console.WriteLine("sideLength: {0}", sideLength);
            Console.WriteLine("volume: {0}", volume);
            Console.WriteLine("expectedVolume: {0}", expectedVolume);

            Assert.AreEqual(volume, expectedVolume);
        }

        [TestMethod]
        public void GetVolume()
        {
            // Arrange
            const int sideLength = 3;
            const int expectedVolume = 27;

            var cube = new Cube.Cube(sideLength);

            // Act
            var volume = cube.GetVolume();

            // Assert
            Console.WriteLine("sideLength: {0}", sideLength);
            Console.WriteLine("volume: {0}", volume);
            Console.WriteLine("expectedVolume: {0}", expectedVolume);

            Assert.AreEqual(volume, expectedVolume);
        }
    }
}
