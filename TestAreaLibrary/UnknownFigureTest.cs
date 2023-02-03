using AreaLibrary.Shape;
using AreaLibrary.Structure;

namespace TestSquareLibrary
{
    public class UnknownFigureTest
    {
        [Fact]
        public void UnknownFigureTest_GetSquare_DoubleResult()
        {
            //Arrange
            var unknownFigure = new UnknownFigure(
                new Point(2, 1),
                new Point(5, 7),
                new Point(8, 12),
                new Point(-1, 2));
            //Act
            var result = unknownFigure.GetArea();
            //Assert
            Assert.Equal(18, result);
            Assert.IsType<UnknownFigure>(unknownFigure);
        }

    }
}
