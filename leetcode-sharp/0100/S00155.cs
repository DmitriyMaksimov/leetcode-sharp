namespace leetcode_sharp;

// 155. Min Stack
// https://leetcode.com/problems/min-stack/
public class S00155
{
public class MinStack
{
    private Stack<(int value, int min)> _stack = new();

    public MinStack()
    {
    }

    public void Push(int val)
    {
        var min = _stack.Any() ? GetMin() : val;
        _stack.Push((val, Math.Min(val, min)));
    }

    public void Pop()
    {
        _stack.Pop();
    }

    public int Top()
    {
        return _stack.Peek().value;
    }

    public int GetMin()
    {
        return _stack.Peek().min;
    }
}
}