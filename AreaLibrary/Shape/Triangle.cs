using AreaLibrary.Interfaces;


namespace AreaLibrary.Shape
{
    public class Triangle : ITriangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        public bool IsRightTriangle { get; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Validate(SideA, SideB, SideC);
            IsRightTriangle = GetIsRightTriangle();
        }
        /// <summary>
        /// Get area
        /// According to Heron's formula
        /// </summary>
        /// <returns> (double) area </returns>
        public double GetArea()
        {
            var halfPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB)
                * (halfPerimeter - SideC));
        }
        /// <summary>
        /// Validatetion side of Triangle
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void Validate(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Сторона треугольника должна быть" +
                                                        " положительным числом и не равна 0.");
            }
            //Theorem. Each side of a triangle is less than the sum of the other two sides
            var maxSide = Math.Max(SideA, Math.Max(sideB, sideC));
            if ((sideA + sideB + sideC) - maxSide - maxSide < 0)
            {
                throw new ArgumentOutOfRangeException("Каждая сторона треугольника должна быть " +
                                                        "меньше суммы двух других сторон.");
            }
        }
        /// <summary>
        /// Get IsRightTriangle
        /// According to the Pythagorean theorem
        /// </summary>
        /// <returns>(bool) IsRightTriangle</returns>
        public bool GetIsRightTriangle(double eps = 1E-9)
        {
            var result = new List<double> { SideA, SideB, SideC };
            result.Sort();
            return Math.Abs(Math.Pow(result[2], 2) - Math.Pow(result[1], 2) 
                - Math.Pow(result[0], 2)) <= eps;
        }
    }
}
