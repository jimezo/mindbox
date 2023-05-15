namespace Mindbox.Shapes
{
    public sealed class TriangleShape : IShape, ISquareCalculatable
    {
        private float _magnitudeA;
        private float _magnitudeB;
        private float _magnitudeC;

        internal TriangleShape(float magnitudeA, float magnitudeB, float magnitudeC)
        {
            _magnitudeA = magnitudeA;
            _magnitudeB = magnitudeB;
            _magnitudeC = magnitudeC;
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(_magnitudeA, 2) + Math.Pow(_magnitudeB, 2) == Math.Pow(_magnitudeC, 2);
        }

        double ISquareCalculatable.GetSquare()
        {
            var semiPerimeter = (_magnitudeA + _magnitudeB + _magnitudeC) / 2;
            var square = Math.Sqrt(semiPerimeter * (semiPerimeter - _magnitudeA) * (semiPerimeter - _magnitudeB) * (semiPerimeter - _magnitudeC));

            return square;
        }
    }
}
