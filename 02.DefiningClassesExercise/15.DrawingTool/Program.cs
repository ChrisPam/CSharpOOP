using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.DrawingTool
{
    public class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            var x = int.Parse(Console.ReadLine());
            int y = 0;
            if (figure.ToLower() != "square")
                y = int.Parse(Console.ReadLine());

            var fig = new CorDraw(x, y);
            fig.Draw(x, y);
        }
    }
}
