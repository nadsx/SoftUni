namespace Shapes
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int radius = int.Parse(Console.ReadLine());
            IDrawable circle = new Circle(radius);

            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            IDrawable rect = new Rectangle(width, height);

            var shapes = new List<IDrawable>
            {
                circle,
                rect
            };

            DrawAllShapes(shapes);
        }

        private static void DrawAllShapes(IEnumerable<IDrawable> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
