using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main()
    {
        StackOfStrings stack = new StackOfStrings();

        stack.Push("kur");
        stack.Push("putka");
        stack.Pop();
        stack.Pop();
        if (!stack.IsEmpty())
        {
            foreach (var item in stack.Stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
