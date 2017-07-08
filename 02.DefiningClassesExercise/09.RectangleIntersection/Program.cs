using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RectangleIntersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];

            var rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var id = command[0];
                var width = int.Parse(command[1]);
                var height = int.Parse(command[2]);
                var x = int.Parse(command[3]);
                var y = int.Parse(command[4]);

                var rectangle = new Rectangle(id, width, height, x, y);
                rectangles.Add(id, rectangle);
            }

            for (int i = 0; i < m; i++)
            {
                var command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstKey = command[0];
                var secondKey = command[1];

                rectangles[firstKey].CompareRectangles(rectangles[secondKey]);
            }
        }
    }
}
