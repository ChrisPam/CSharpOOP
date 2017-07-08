using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DrawingTool
{
    public class CorDraw
    {
        public int x;
        public int y;

        public CorDraw(int x)
        {
            this.x = x;
            this.y = 0;
        }

        public CorDraw(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw(int x, int y)
        {
            DrawLine(x, "-");

            if (y == 0)
            {
                y = x;
            }
            DrawLine(x, " ");

            DrawLine(x, "-");

        }

        public void DrawLine(int x, string pattern)
        {
            Console.Write("|");
            for (int i = 0; i < x; i++)
            {
                Console.Write(pattern);
            }
            Console.WriteLine("|");
        }
    }
}
