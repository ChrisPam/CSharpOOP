using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StackOfStrings
{
    private List<string> stack;

    public StackOfStrings()
    {
        this.stack = new List<string>();
    }

    public List<string> Stack
    {
        get { return this.stack; }
    }

    public void Push(string item)
    {
        stack.Add(item);
    }

    public string Pop()
    {
        var item = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return item;
    }

    public string Peek()
    {
        var item = stack[stack.Count - 1];
        return item;
    }

    public bool IsEmpty()
    {
        if (stack.Count < 0)
            return false;
        return true;
    }
}
