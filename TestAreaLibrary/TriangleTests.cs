using AreaLibrary.Shape;


namespace TestSquareLibrary
{
    public class TriangleTests
    {
        [Fact]
        public void Triangle_GetArea_DoubleResult()
        {
            //Arrange
            Triangle triangle = new Triangle(25, 7, 24);
            //Act
            var result = triangle.GetArea();
            //Assert
            Assert.Equal(84, result);
            Assert.IsType<Triangle>(triangle);
        }

        [Fact]
        public void Triangle_Validate_NegativeValue_ExceptionResult()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-2, 7, 24));
        }
        [Fact]
        public void Triangle_Validate_ZeroValue_ExceptionResult()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 7, 24));
        }
        [Fact]
        public void Triangle_GetIsRightTriangle_BoolResult()
        {
            //Arrange
            Triangle triangle = new(7.00, 25.00, 24.00);
            //Act
            var result = triangle.GetIsRightTriangle();
            //Assert
            Assert.True(result);
        }
    }
}
