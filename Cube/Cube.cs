﻿using System;

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

        /// <summary>
        /// Removing the outer most layer.
        /// </summary>
        /// <returns></returns>
        public int GetInnerVolume()
        {
            if (_sideLength <= 2)
            {
                return 0;
            }

            return CalculatePow(_sideLength - 2, 3);
        }

        private static int CalculatePow(int number, int pow)
        {
            return (int) Math.Pow(number, pow);
        }

        private readonly int _sideLength;
    }
}