using AreaLibrary.Interfaces;

namespace AreaLibrary.Shape
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            //Validation of radius
            if (radius <= 1E-9)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть положительным числом", nameof(radius));
            }
            Radius = radius;
        }
        /// <summary>
        /// Get area
        /// The formula for calculating the area of a circle in terms of radius
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}