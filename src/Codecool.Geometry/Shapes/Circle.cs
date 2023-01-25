using System;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Circle implementation class
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        ///     Gets formula for the area of the circle as a string.
        /// </summary>
        public override string AreaFormula => "π×r×r";

        /// <summary>
        ///     Gets formula for the perimeter of the circle as a string.
        /// </summary>
        public override string PerimeterFormula => "2×π×r";

        /// <inheritdoc />
        public override double Area => Math.PI*_r*_r;

        /// <inheritdoc />
        public override double Perimeter => 2*Math.PI*_r;

        private readonly double _r;

        public Circle(double radius)
        {
            _r = radius;
        }
        
        public override string ToString()
        {
            var stringToShow = new StringBuilder()
                .Append($"{GetType().Name}, ")
                .Append($"r = {_r}");

            return stringToShow.ToString();
        }
    }
}
