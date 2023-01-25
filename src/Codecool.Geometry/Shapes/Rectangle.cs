using System;
using System.Text;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Rectangle implementation class
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public override string AreaFormula => "a×b";

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public override string PerimeterFormula => "2×a+2×b";

        /// <inheritdoc />
        public override double Area => _a * _b;

        /// <inheritdoc />
        public override double Perimeter => 2 * _a + 2 * _b;

        protected readonly double _a;

        private readonly double _b;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }
        
        public override string ToString()
        {
            var stringToShow = new StringBuilder()
                .Append($"{GetType().Name}, ")
                .Append($"a = {_a}, b = {_b}");

            return stringToShow.ToString();
        }
    }
}
