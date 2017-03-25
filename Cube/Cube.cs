using System;

namespace Cube
{
    public class Cube
    {
        public Cube(int sideLength)
        {
            _sideLength = sideLength;
        }

        public int GetVolume()
        {
            return CalculatePow(_sideLength, 3);
        }

        public int GetVolumeWithoutOuterMostLayer()
        {
            if (_sideLength == 1)
            {
                return 0;
            }

            const int pow = 3;

            return CalculatePow(_sideLength, pow) - CalculatePow(_sideLength - 1, pow);
        }

        private static int CalculatePow(int number, int pow)
        {
            return (int) Math.Pow(number, pow);
        }

        private readonly int _sideLength;
    }
}