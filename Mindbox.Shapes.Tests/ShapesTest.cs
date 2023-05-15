using Xunit.Abstractions;

namespace Mindbox.Shapes.Tests
{
    public class ShapesTest
    {
        private ITestOutputHelper _outputHelper;

        public ShapesTest(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(6, 9, 14)]
        [InlineData(5, 12, 13)]
        public void TestTriangleSquare(int a, int b, int c)
        {
            var triangle = ShapesFactory.CreateTriangle(a, b, c);

            var square = triangle.GetSquare();
            var squareFromAbstractShape = ShapeExtensions.TryGetSquare((IShape)triangle);

            _outputHelper.WriteLine($"Square = {square}");
            _outputHelper.WriteLine($"IsRightTriangle = {triangle.IsRightTriangle()}");

            Assert.True(square == squareFromAbstractShape);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(14)]
        [InlineData(20)]
        public void TestCircleSquare(int radius)
        {
            var circle = ShapesFactory.CreateCircle(radius);

            var square = circle.GetSquare();
            var squareFromAbstractShape = ShapeExtensions.TryGetSquare((IShape)circle);

            _outputHelper.WriteLine($"Square = {square}");

            Assert.True(square == squareFromAbstractShape);
        }
    }
}