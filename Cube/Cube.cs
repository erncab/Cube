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
            return _sideLength * _sideLength * _sideLength;
        }

        private readonly int _sideLength;
    }
}