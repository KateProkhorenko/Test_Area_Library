using AreaLibrary.Shape;

namespace TestSquareLibrary
{
    public class CircleTests
    {
        [Fact]
        
        public void Circle_GetSquare_DoubleResult()
        {
            //Arrange
            Circle circle = new Circle(5);
            //Act
            var result = circle.GetArea();
            //Assert
            Assert.Equal((Math.PI * Math.Pow(5, 2)), result);
        }

        [Fact]
        public void Circle_NegativeRadius()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-85));
        }
        [Fact]
        public void Circle_ZeroRadius() 
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }
    }
}