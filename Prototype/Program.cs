using System;
using System.Collections.Generic;

namespace Prototype
{
    // Concrete prototypes.

    static class Program
    {
        public static void Main()
        {
            List<Shape> shapes = new();

            Circle circle = new(1, 2, "red", 3);
            shapes.Add(circle);

            Shape anotherCircle = circle.Clone(); // Clone's return type is Shape.
            shapes.Add(anotherCircle);

            Rectangle rectangle = new(1, 2, "blue", 4, 5);
            shapes.Add(rectangle);

            Shape anotherRectangle = rectangle.Clone();
            shapes.Add(anotherRectangle);

            List<Shape> shapeCopies = new();

            foreach (var s in shapes)
            {
                shapeCopies.Add(s.Clone()); 
            }
        }
    }
}