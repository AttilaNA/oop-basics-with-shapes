using System;
using System.Linq;
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
            bool isRunning = true;

            while (isRunning)
            {
                int option = 6;  // TODO read the keyboard here
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
                    option = int.Parse(selectedMainMenuOption);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Wrong input!");
                    Console.WriteLine();
                }

                switch (option)
                {
                    case 1:
                        // TODO Add new shape
                        var shapes = new ShapeCollection();
                        shapes.AddShape(new Circle(4));
                        shapes.AddShape(new Triangle(3, 5, 6));
                        shapes.AddShape(new EquilateralTriangle(6));
                        shapes.GetShapesTable();
                        break;
                    case 2:
                        // TODO Show all shapes
                        break;
                    case 3:
                        // TODO Show shape with the largest perimeter
                        break;
                    case 4:
                        // TODO Show shape with the largest area
                        break;
                    case 5:
                        // TODO Show formulas
                        break;
                    case 0:
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
