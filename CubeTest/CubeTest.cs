using System;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CubeTest
{
    [TestFixture]
    public class CubeTest
    {
        [TestCaseSource(typeof(CubeTestDataSource), "BuildCalculateInnerVolumeTestCases")]
        public void GetInnerVolumeTest(int sideLength, int expectedInnerVolume)
        {
            // Arrange
             var cube = new Cube.Cube(sideLength);

            // Act
            var actualInnerVolume = cube.GetInnerVolume();

            // Assert
            Console.WriteLine("sideLength: {0}", sideLength);
            Console.WriteLine("actualInnerVolume: {0}", actualInnerVolume);
            Console.WriteLine("expectedInnerVolume: {0}", expectedInnerVolume);

            Assert.AreEqual(actualInnerVolume, expectedInnerVolume);
        }

        [TestCaseSource(typeof(CubeTestDataSource), "BuildCalculateVolumeTestCases")]
        public void GetVolumeTest(int sideLength, int expectedVolume)
        {
            // Arrange
            var cube = new Cube.Cube(sideLength);

            // Act
            var actualVolume = cube.GetVolume();

            // Assert
            Console.WriteLine("sideLength: {0}", sideLength);
            Console.WriteLine("actualVolume: {0}", actualVolume);
            Console.WriteLine("expectedVolume: {0}", expectedVolume);

            Assert.AreEqual(actualVolume, expectedVolume);
        }
    }
}
