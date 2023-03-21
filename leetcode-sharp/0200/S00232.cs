namespace leetcode_sharp;

// 232. Implement Queue using Stacks
// https://leetcode.com/problems/implement-queue-using-stacks/
public class S00232
{
    private Stack<int> s1 = new();  // Main stack
    private Stack<int> s2 = new();  // Temporary stack - when we need to pop value, we move all elements from s1 to s2
    
    public void Push(int x)
    {
        // Move all element from s2 back to s1
        while (s2.TryPop(out var value))
        {
            s1.Push(value);
        }

        s1.Push(x);
    }

    public int Pop()
    {
        // Move all element from s1 to s2
        while (s1.TryPop(out var value))
        {
            s2.Push(value);
        }

        return s2.Pop();
    }

    public int Peek()
    {
        // Move all element from s1 to s2
        while (s1.TryPop(out var value))
        {
            s2.Push(value);
        }

        return s2.Peek();
    }

    public bool Empty()
    {
        return s1.Count == 0 && s2.Count == 0;
    }
}