using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RectangleIntersection
{
    public class Rectangle
    {
        public string id;
        public int width;
        public int height;
        public int x;
        public int y;

        public Rectangle(string id, int width, int height, int x, int y)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.x = x;
            this.y = y;
        }

        public void CompareRectangles(Rectangle secondRectangle)
        {
            var firstRectFirstPosition = (this.x + this.width);
            var firstRectSecondPosition = this.y + this.height;

            var secondRectFirstPosition = secondRectangle.x + secondRectangle.width;
            var secondRectSecondPosition = secondRectangle.y + secondRectangle.height;

            if (firstRectFirstPosition == secondRectFirstPosition &&
                firstRectSecondPosition == secondRectSecondPosition)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
