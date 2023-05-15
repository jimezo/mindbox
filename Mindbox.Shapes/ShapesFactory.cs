namespace Mindbox.Shapes
{
    public static class ShapesFactory
    {
        public static TriangleShape CreateTriangle(float magnitudeA, float magnitudeB, float magnitudeC)
        {
            return new TriangleShape(magnitudeA, magnitudeB, magnitudeC);
        }

        public static CircleShape CreateCircle(float radius)
        {
            return new CircleShape(radius);
        }
    }
}
