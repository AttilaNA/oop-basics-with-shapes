namespace Codecool.Geometry.Shapes;

public class Empty : Shape
{
    public override string AreaFormula => "Empty";
    public override string PerimeterFormula => "Empty";
    public override double Area => 0;
    public override double Perimeter => 0;

    public override string ToString()
    {
        return "Empty";
    }
}