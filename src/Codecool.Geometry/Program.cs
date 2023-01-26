using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Codecool.Geometry.Containers;
using Codecool.Geometry.Shapes;

namespace Codecool.Geometry
{
    /// <summary>
    ///     This is the main class of your program which contains Main method
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///     This is the entry point of your program.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            var myShapeCollection = new ShapeCollection();
            bool isRunning = true;

            while (isRunning)
            {
                // TODO read the keyboard here
                int optionMainMenu = 6;
                Console.WriteLine();
                var mainMenuOptions = "Choose an option:\n" +
                              "0. Exit\n" +
                              "1. Add new shape\n" +
                              "2. Show all shapes\n" +
                              "3. Show shape with the largest perimeter\n" +
                              "4. Show shape with the largest area\n" +
                              "5. Show formulas";
                Console.WriteLine(mainMenuOptions);
                var selectedMainMenuOption = Console.ReadLine();
                if (new string[] { "0", "1", "2", "3", "4", "5" }.Contains(selectedMainMenuOption))
                {
                    optionMainMenu = int.Parse(selectedMainMenuOption);
                    if (optionMainMenu != 0)
                    {
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Wrong input!");
                }

                switch (optionMainMenu)
                {
                    case 1:
                        // TODO Add new shape
                        int optionAddNewShapeMenu = 7;
                        bool isAdded = false;

                        while (!isAdded)
                        {
                            Console.WriteLine();
                            var AddNewShapeMenuOptions = "Add a Shape:\n" +
                                                         "1. Circle\n" +
                                                         "2. Triangle\n" +
                                                         "3. Equilateral Triangle\n" +
                                                         "4. Rectangle\n" +
                                                         "5. Square\n" +
                                                         "6. Regular Pentagon\n" +
                                                         "0. Return main menu";
                            Console.WriteLine(AddNewShapeMenuOptions);
                            var selectedAddNewShapeMenuOptions = Console.ReadLine();
                            if (new [] { "0", "1", "2", "3", "4", "5", "6" }.Contains(selectedAddNewShapeMenuOptions))
                            {
                                optionAddNewShapeMenu = int.Parse(selectedAddNewShapeMenuOptions);
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Wrong input!");
                            }

                            switch (optionAddNewShapeMenu)
                            {
                                case 1:
                                    bool isInputCircleValid = false;
                                    while (!isInputCircleValid)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Type the value of r: ");
                                        
                                        var tipedR = Console.ReadLine();
                                        if (tipedR.Length == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine();
                                            Console.WriteLine("Wrong input!");
                                        }
                                        else
                                        {
                                            var isInputCircleWrong = false;
                                            for (int i = 0; i < tipedR.Length; i++)
                                            {
                                                switch (i)
                                                {
                                                    case 0:
                                                        if (!new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                            .Contains(tipedR[i]))
                                                        {
                                                            isInputCircleWrong = true;
                                                        }
                                                        break;
                                                
                                                    default:
                                                        if (!new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                            .Contains(tipedR[i]))
                                                        {
                                                            isInputCircleWrong = true;
                                                        }
                                                        break;
                                                }

                                                if (isInputCircleWrong)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("Wrong input!");
                                                    break;
                                                }
                                            }

                                            if (!isInputCircleWrong)
                                            {
                                                isInputCircleValid = true;
                                                myShapeCollection.AddShape(new Circle(Double.Parse(tipedR)));
                                            }
                                        }
                                    }
                                    isAdded = true;
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Shape added successfully!");
                                    break;
                                case 2:
                                    var sides = new Dictionary<string, double>() { };
                                    foreach (var side in new string[]{"a", "b", "c"})
                                    {
                                        bool isInputTriangleValid = false;
                                        while (!isInputTriangleValid)
                                        {
                                            Console.WriteLine();
                                            Console.Write($"Type the value of {side}: ");
                                            
                                            var tipedSide = Console.ReadLine();
                                            if (tipedSide.Length == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine("Wrong input!");
                                            }
                                            else
                                            {
                                                var isInputTriangleWrong = false;
                                                for (int i = 0; i < tipedSide.Length; i++)
                                                {
                                                    switch (i)
                                                    {
                                                        case 0:
                                                            if (!new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                                .Contains(tipedSide[i]))
                                                            {
                                                                isInputTriangleWrong = true;
                                                            }
                                                            break;
                                                    
                                                        default:
                                                            if (!new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                                .Contains(tipedSide[i]))
                                                            {
                                                                isInputTriangleWrong = true;
                                                            }
                                                            break;
                                                    }

                                                    if (isInputTriangleWrong)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine();
                                                        Console.WriteLine("Wrong input!");
                                                        break;
                                                    }
                                                }

                                                if (!isInputTriangleWrong)
                                                {
                                                    isInputTriangleValid = true;
                                                    sides[side] = double.Parse(tipedSide);
                                                    Console.Clear();
                                                }
                                            }
                                        }
                                    }
                                    myShapeCollection.AddShape(new Triangle(sides["a"], sides["b"], sides["c"]));
                                    isAdded = true;
                                    Console.WriteLine();
                                    Console.WriteLine("Shape added successfully!");
                                    break;
                                case 3:
                                    bool isInputEquilateralTriangleValid = false;
                                    while (!isInputEquilateralTriangleValid)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Type the value of a: ");
                                        
                                        var tipedA = Console.ReadLine();
                                        if (tipedA.Length == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine();
                                            Console.WriteLine("Wrong input!");
                                        }
                                        else
                                        {
                                            var isInputEquilateralTriangleWrong = false;
                                            for (int i = 0; i < tipedA.Length; i++)
                                            {
                                                switch (i)
                                                {
                                                    case 0:
                                                        if (!new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                            .Contains(tipedA[i]))
                                                        {
                                                            isInputEquilateralTriangleWrong = true;
                                                        }
                                                        break;
                                                
                                                    default:
                                                        if (!new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                            .Contains(tipedA[i]))
                                                        {
                                                            isInputEquilateralTriangleWrong = true;
                                                        }
                                                        break;
                                                }

                                                if (isInputEquilateralTriangleWrong)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("Wrong input!");
                                                    break;
                                                }
                                            }

                                            if (!isInputEquilateralTriangleWrong)
                                            {
                                                isInputEquilateralTriangleValid = true;
                                                myShapeCollection.AddShape(new EquilateralTriangle(double.Parse(tipedA)));
                                            }
                                        }
                                    }
                                    isAdded = true;
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Shape added successfully!");
                                    break;
                                case 4:
                                    var sidesOfRectangle = new Dictionary<string, double>() { };
                                    foreach (var side in new string[]{"a", "b"})
                                    {
                                        bool isInputRectangleValid = false;
                                        while (!isInputRectangleValid)
                                        {
                                            Console.WriteLine();
                                            Console.Write($"Type the value of {side}: ");
                                            
                                            var tipedSide = Console.ReadLine();
                                            if (tipedSide.Length == 0)
                                            {
                                                Console.Clear();
                                                Console.WriteLine();
                                                Console.WriteLine("Wrong input!");
                                            }
                                            else
                                            {
                                                var isInputRectangleWrong = false;
                                                for (int i = 0; i < tipedSide.Length; i++)
                                                {
                                                    switch (i)
                                                    {
                                                        case 0:
                                                            if (!new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                                .Contains(tipedSide[i]))
                                                            {
                                                                isInputRectangleWrong = true;
                                                            }
                                                            break;
                                                    
                                                        default:
                                                            if (!new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                                .Contains(tipedSide[i]))
                                                            {
                                                                isInputRectangleWrong = true;
                                                            }
                                                            break;
                                                    }

                                                    if (isInputRectangleWrong)
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine();
                                                        Console.WriteLine("Wrong input!");
                                                        break;
                                                    }
                                                }

                                                if (!isInputRectangleWrong)
                                                {
                                                    isInputRectangleValid = true;
                                                    sidesOfRectangle[side] = double.Parse(tipedSide);
                                                    Console.Clear();
                                                }
                                            }
                                        }
                                    }
                                    myShapeCollection.AddShape(new Rectangle(sidesOfRectangle["a"], sidesOfRectangle["b"]));
                                    isAdded = true;
                                    Console.WriteLine();
                                    Console.WriteLine("Shape added successfully!");
                                    break;
                                case 5:
                                    bool isInputSquareValid = false;
                                    while (!isInputSquareValid)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Type the value of a: ");
                                        
                                        var tipedA = Console.ReadLine();
                                        if (tipedA.Length == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine();
                                            Console.WriteLine("Wrong input!");
                                        }
                                        else
                                        {
                                            var isInputSquareWrong = false;
                                            for (int i = 0; i < tipedA.Length; i++)
                                            {
                                                switch (i)
                                                {
                                                    case 0:
                                                        if (!new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                            .Contains(tipedA[i]))
                                                        {
                                                            isInputSquareWrong = true;
                                                        }
                                                        break;
                                                
                                                    default:
                                                        if (!new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                            .Contains(tipedA[i]))
                                                        {
                                                            isInputSquareWrong = true;
                                                        }
                                                        break;
                                                }

                                                if (isInputSquareWrong)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("Wrong input!");
                                                    break;
                                                }
                                            }

                                            if (!isInputSquareWrong)
                                            {
                                                isInputSquareValid = true;
                                                myShapeCollection.AddShape(new Square(double.Parse(tipedA)));
                                            }
                                        }
                                    }
                                    isAdded = true;
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Shape added successfully!");
                                    break;
                                case 6:
                                    bool isInputRegularPentagonValid = false;
                                    while (!isInputRegularPentagonValid)
                                    {
                                        Console.WriteLine();
                                        Console.Write("Type the value of a: ");
                                        
                                        var tipedA = Console.ReadLine();
                                        if (tipedA.Length == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine();
                                            Console.WriteLine("Wrong input!");
                                        }
                                        else
                                        {
                                            var isInputRegularPentagonWrong = false;
                                            for (int i = 0; i < tipedA.Length; i++)
                                            {
                                                switch (i)
                                                {
                                                    case 0:
                                                        if (!new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                            .Contains(tipedA[i]))
                                                        {
                                                            isInputRegularPentagonWrong = true;
                                                        }
                                                        break;
                                                
                                                    default:
                                                        if (!new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }
                                                            .Contains(tipedA[i]))
                                                        {
                                                            isInputRegularPentagonWrong = true;
                                                        }
                                                        break;
                                                }

                                                if (isInputRegularPentagonWrong)
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine();
                                                    Console.WriteLine("Wrong input!");
                                                    break;
                                                }
                                            }

                                            if (!isInputRegularPentagonWrong)
                                            {
                                                isInputRegularPentagonValid = true;
                                                myShapeCollection.AddShape(new RegularPentagon(double.Parse(tipedA)));
                                            }
                                        }
                                    }
                                    isAdded = true;
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine("Shape added successfully!");
                                    break;
                                case 0:
                                    isAdded = true;
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;
                    case 2:
                        // TODO Show all shapes
                        myShapeCollection.GetShapesTable();
                        break;
                    case 3:
                        // TODO Show shape with the largest perimeter
                        myShapeCollection.GetLargestShapeByPerimeter().GetShapesTable();
                        break;
                    case 4:
                        // TODO Show shape with the largest area
                        myShapeCollection.GetLargestShapeByArea().GetShapesTable();
                        break;
                    case 5:
                        // TODO Show formulas
                        bool isSelected = false;

                        while (!isSelected)
                        {
                            Console.WriteLine();
                            int optionShowFormulaMenu = 7;
                            var ShowFormulaMenuOptions = "Choose a shape:\n" +
                                                         "1. Circle\n" +
                                                         "2. Triangle\n" +
                                                         "3. Equilateral Triangle\n" +
                                                         "4. Rectangle\n" +
                                                         "5. Square\n" +
                                                         "6. Regular Pentagon\n" +
                                                         "0. Return main menu";
                            Console.WriteLine(ShowFormulaMenuOptions);
                            var selectedShowFormulaMenuOptions = Console.ReadLine();
                            if (new [] { "0", "1", "2", "3", "4", "5", "6" }.Contains(selectedShowFormulaMenuOptions))
                            {
                                optionShowFormulaMenu = int.Parse(selectedShowFormulaMenuOptions);
                                Console.Clear();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Wrong input!");
                            }

                            switch (optionShowFormulaMenu)
                            {
                                case 1:
                                    var circle = new Circle(1);
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine($"{circle.GetType().Name} area formula: {circle.AreaFormula}, {circle.GetType().Name} perimeter formula: {circle.PerimeterFormula}");
                                    break;
                                case 2:
                                    var triangle = new Triangle(1, 2, 3);
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine($"{triangle.GetType().Name} area formula: {triangle.AreaFormula}, {triangle.GetType().Name} perimeter formula: {triangle.PerimeterFormula}");
                                    break;
                                case 3:
                                    var equilateralTriangle = new EquilateralTriangle(1);
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine($"{equilateralTriangle.GetType().Name} area formula: {equilateralTriangle.AreaFormula}, {equilateralTriangle.GetType().Name} perimeter formula: {equilateralTriangle.PerimeterFormula}");
                                    break;
                                case 4:
                                    var rectangle = new Rectangle(1, 2);
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine($"{rectangle.GetType().Name} area formula: {rectangle.AreaFormula}, {rectangle.GetType().Name} perimeter formula: {rectangle.PerimeterFormula}");
                                    break;
                                case 5:
                                    var square = new Square(1);
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine($"{square.GetType().Name} area formula: {square.AreaFormula}, {square.GetType().Name} perimeter formula: {square.PerimeterFormula}");
                                    break;
                                case 6:
                                    var regularPentagon = new RegularPentagon(1);
                                    Console.Clear();
                                    Console.WriteLine();
                                    Console.WriteLine($"{regularPentagon.GetType().Name} area formula: {regularPentagon.AreaFormula}, {regularPentagon.GetType().Name} perimeter formula: {regularPentagon.PerimeterFormula}");
                                    break;
                                case 0:
                                    isSelected = true;
                                    Console.Clear();
                                    break;
                            }
                            
                        }
                        break;
                    case 0:
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
