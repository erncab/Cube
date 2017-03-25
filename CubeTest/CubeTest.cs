using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeTest
{
    [TestClass]
    public class CubeTest
    {
        [TestMethod]
        public void GetVolume()
        {
            // Arrange
            const int sideLength = 1;

            var cube = new Cube.Cube(sideLength);

            // Act
            var volume = cube.GetVolume();

            // Assert
            Assert.AreEqual(volume, 1);
        }
    }
}
