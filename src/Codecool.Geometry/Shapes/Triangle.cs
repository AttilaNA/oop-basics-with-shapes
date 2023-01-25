using System;
using System.Text;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Triangle implementation class
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public new static string AreaFormula => "sqrt(s×(s-a)×(s-b)×(s-c))";

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "a+b+c";

        /// <inheritdoc/>
        public override double Perimeter => _a + _b + _c;

        /// <inheritdoc />
        public override double Area => Math.Sqrt(SemiPerimeter*(SemiPerimeter-_a)*(SemiPerimeter-_b)*(SemiPerimeter-_c));

        private double SemiPerimeter => (_a + _b + _c) / 2;

        protected readonly double _a;

        private readonly double _b;

        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        
        public override string ToString()
        {
            var stringToShow = new StringBuilder()
                .Append("Triangle\n")
                .Append("\n")
                .Append($"a = {_a}, b = {_b}, c = {_c}\n")
                .Append($"Perimeter: {Perimeter}\n")
                .Append($"Formula: {PerimeterFormula}\n")
                .Append($"Area: {Area}\n")
                .Append($"Formula: {AreaFormula}\n");

            return stringToShow.ToString();
        }
    }
}
