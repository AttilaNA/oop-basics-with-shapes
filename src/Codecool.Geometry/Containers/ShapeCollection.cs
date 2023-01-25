using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Codecool.Geometry.Shapes;
using Microsoft.VisualBasic;

namespace Codecool.Geometry.Containers
{
    /// <summary>
    ///     Shape Collection class
    /// </summary>
    public class ShapeCollection
    {
        private List<Shape> Shapes { get; set; } = new List<Shape>();

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        public Shape GetLargestShapeByPerimeter()
        {
            return Shapes.MaxBy(x => x.Perimeter);
        }

        public Shape GetLargestShapeByArea()
        {
            return Shapes.MaxBy(x => x.Area);
        }

        public void GetShapesTable()
        {
            if (Shapes.Count == 0)
            {
                Console.WriteLine("Collection is empty!");
            }
            else
            {
                Console.WriteLine($"{String.Format("/{0, 4}", $"{String.Concat(Enumerable.Repeat("-", 4))}")}" +
                                  $"{String.Format("|{0, 30}", $"{String.Concat(Enumerable.Repeat("-", 30))}")}" +
                                  $"{String.Format("|{0, 50}", $"{String.Concat(Enumerable.Repeat("-", 50))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 50}\\", $"{String.Concat(Enumerable.Repeat("-", 50))}")}");

                Console.WriteLine($"{String.Format("|{0, 4}", "ID")}" +
                                  $"{String.Format("|{0, 30}", "Class")}" +
                                  $"{String.Format("|{0, 50}", "toString")}" +
                                  $"{String.Format("|{0, 15}", "Perimeter")}" +
                                  $"{String.Format("|{0, 15}", "Formula")}" +
                                  $"{String.Format("|{0, 15}", "Area")}" +
                                  $"{String.Format("|{0, 50}|", "Formula")}");
                
                Console.WriteLine($"{String.Format("|{0, 4}", $"{String.Concat(Enumerable.Repeat("-", 4))}")}" +
                                  $"{String.Format("|{0, 30}", $"{String.Concat(Enumerable.Repeat("-", 30))}")}" +
                                  $"{String.Format("|{0, 50}", $"{String.Concat(Enumerable.Repeat("-", 50))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 50}|", $"{String.Concat(Enumerable.Repeat("-", 50))}")}");
                
                for (int i = 0; i < Shapes.Count; i++)
                {
                    Console.WriteLine($"{String.Format("|{0, 4}", $"{i}")}" +
                                      $"{String.Format("|{0, 30}", $"{Shapes[i].GetType().Name}")}" +
                                      $"{String.Format("|{0, 50}", $"{Shapes[i]}")}" +
                                      $"{String.Format("|{0, 15}", $"{Math.Round(Shapes[i].Perimeter, 2)}")}" +
                                      $"{String.Format("|{0, 15}", $"{Shapes[i].PerimeterFormula}")}" +
                                      $"{String.Format("|{0, 15}", $"{Math.Round(Shapes[i].Area, 2)}")}" +
                                      $"{String.Format("|{0, 50}|", $"{Shapes[i].AreaFormula}")}");

                    if (i < Shapes.Count - 1)
                    {
                        Console.WriteLine($"{String.Format("|{0, 4}", $"{String.Concat(Enumerable.Repeat("-", 4))}")}" +
                                          $"{String.Format("|{0, 30}", $"{String.Concat(Enumerable.Repeat("-", 30))}")}" +
                                          $"{String.Format("|{0, 50}", $"{String.Concat(Enumerable.Repeat("-", 50))}")}" +
                                          $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                          $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                          $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                          $"{String.Format("|{0, 50}|", $"{String.Concat(Enumerable.Repeat("-", 50))}")}");
                    }
                }
                
                Console.WriteLine($"{String.Format("\\{0, 4}", $"{String.Concat(Enumerable.Repeat("-", 4))}")}" +
                                  $"{String.Format("|{0, 30}", $"{String.Concat(Enumerable.Repeat("-", 30))}")}" +
                                  $"{String.Format("|{0, 50}", $"{String.Concat(Enumerable.Repeat("-", 50))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 15}", $"{String.Concat(Enumerable.Repeat("-", 15))}")}" +
                                  $"{String.Format("|{0, 50}/", $"{String.Concat(Enumerable.Repeat("-", 50))}")}");
            }
        }
    }
}
