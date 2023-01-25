using System;
using System.Text;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Regular Pentagon implementation class
    /// </summary>
    public class RegularPentagon : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the pentagon as a string.
        /// </summary>
        public new static string AreaFormula => "a×a×sqrt(5×(5+2×sqrt(5))/4";

        /// <summary>
        ///     Gets formula for the perimeter of the pentagon as a string.
        /// </summary>
        public new static string PerimeterFormula => "5×a";

        /// <inheritdoc/>
        public override double Area => _a * _a * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)) / 4);

        /// <inheritdoc/>
        public override double Perimeter => 5 * _a;

        private readonly double _a;

        public RegularPentagon(double a)
        {
            _a = a;
        }
        
        public override string ToString()
        {
            var stringToShow = new StringBuilder()
                .Append("Pentagon\n")
                .Append("\n")
                .Append($"a = {_a}\n")
                .Append($"Perimeter: {Perimeter}\n")
                .Append($"Formula: {PerimeterFormula}\n")
                .Append($"Area: {Area}\n")
                .Append($"Formula: {AreaFormula}\n");

            return stringToShow.ToString();
        }
    }
}
