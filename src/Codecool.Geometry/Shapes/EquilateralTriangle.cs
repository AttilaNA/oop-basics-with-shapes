using System;
using System.Text;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Equilateral Triangle implementation class
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        /// <summary>
        ///     Gets formula for the area of the triangle as a string.
        /// </summary>
        public override string AreaFormula => "a×a×sqrt(3)/4";

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public override string PerimeterFormula => "3×a";

        public EquilateralTriangle(double a) : base(a, a, a)
        {
        }
        
        public override string ToString()
        {
            var stringToShow = new StringBuilder()
                .Append($"{GetType().Name}, ")
                .Append($"a = {_a}");

            return stringToShow.ToString();
        }
    }
}
