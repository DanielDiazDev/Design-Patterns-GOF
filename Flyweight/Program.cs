using System;
using System.Drawing;

namespace Flyweight
{
    class Program
    {
        static void Main()
        {
            var forest = new Forest();
            forest.PlantTree(new Point(1,2), "tree 1 (large obj 1.1)", "blue (large obj 1.2)", "large obj 1.3" );
            forest.PlantTree(new Point(10,20), "tree 2 (large obj 2.1)", "blue (large obj 2.2)", "large obj 2.3" );
            forest.PlantTree(new Point(11,21), "tree 2 (large obj 2.1)", "blue (large obj 2.2)", "large obj 2.3" );
            forest.PlantTree(new Point(12,22), "tree 2 (large obj 2.1)", "blue (large obj 2.2)", "large obj 2.3" );
            forest.PlantTree(new Point(100,200), "tree 3 (large obj 3.1)", "blue (large obj 3.2)", "large obj 3.3" );
            forest.PlantTree(new Point(101,201), "tree 3 (large obj 3.1)", "blue (large obj 3.2)", "large obj 3.3" );
            forest.PlantTree(new Point(102,202), "tree 3 (large obj 3.1)", "blue (large obj 3.2)", "large obj 3.3" );

            forest.Draw(new Rectangle());
            Console.ReadLine();
        }
    }
}