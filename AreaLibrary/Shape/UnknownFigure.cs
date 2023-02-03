using AreaLibrary.Interfaces;
using AreaLibrary.Structure;

namespace AreaLibrary.Shape
{
    /*
     * Задание. Вычисление площади фигуры без знания типа фигуры в compile-time.
     * Мои предположения:
     * Фигура неизвестна, но могут быть известны ее координаты по осям Х и У.
     * Тогда возможно рассчитать площадь n-угольника по формуле Гаусса.
     */
    public class UnknownFigure : IShape
    {
        /// <summary>
        /// List of Point
        /// </summary>
        public List<Point> Points;
        public UnknownFigure(params Point[] points) 
        { 
            Points = points.ToList();
        }
        /// <summary>
        /// Get Area Unknown Figure
        /// Gauss formula
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            double sum = 0;
            for (int i = 0; i < Points.Count; i++)
            {
                var j = (i + 1) % Points.Count;
                var p1 = Points[i];
                var p2 = Points[j];

                sum += p1.X * p2.Y - p1.Y * p2.X;
            }
            return Math.Abs(sum) / 2;
        }
    }
}
