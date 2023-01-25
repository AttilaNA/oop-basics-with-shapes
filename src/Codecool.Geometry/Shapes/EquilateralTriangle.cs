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
        public new static string AreaFormula => "a×a×sqrt(3)/4";

        /// <summary>
        ///     Gets formula for the perimeter of the triangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "3×a";

        public EquilateralTriangle(double a) : base(a, a, a)
        {
        }
        
        public override string ToString()
        {
            var stringToShow = new StringBuilder()
                .Append("Equilateral Triangle\n")
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
