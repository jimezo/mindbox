namespace Mindbox.Shapes
{
    public sealed class CircleShape : IShape, ISquareCalculatable
    {
        private float _radius;

        internal CircleShape(float radius)
        {
            _radius = radius;
        }

        double ISquareCalculatable.GetSquare()
        {
            var square = Math.PI * Math.Pow(_radius, 2);

            return square;
        }
    }
}
