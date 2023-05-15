namespace Mindbox.Shapes
{
    public static class ShapeExtensions
    {
        public static double GetSquare(this ISquareCalculatable squareCalculatable)
        {
            if (squareCalculatable == null)
                return default;

            return squareCalculatable.GetSquare();
        }

        public static double? TryGetSquare(IShape shape)
        {
            if (shape is ISquareCalculatable squareCalculatable)
                return squareCalculatable.GetSquare();

            return null;
        }
    }
}
