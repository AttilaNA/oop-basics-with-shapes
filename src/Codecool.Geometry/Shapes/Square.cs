using System;
using System.Text;

namespace Codecool.Geometry.Shapes
{
    /// <summary>
    ///     Square implementation class
    /// </summary>
    public class Square : Rectangle
    {
        /// <summary>
        ///     Gets formula for the area of the rectangle as a string.
        /// </summary>
        public new static string AreaFormula => "a×a";

        /// <summary>
        ///     Gets formula for the perimeter of the rectangle as a string.
        /// </summary>
        public new static string PerimeterFormula => "4×a";

        public Square(double a) : base(a, a)
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
