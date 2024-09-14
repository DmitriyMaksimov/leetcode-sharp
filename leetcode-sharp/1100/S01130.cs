namespace leetcode_sharp;

// 1130. Minimum Cost Tree From Leaf Values
// https://leetcode.com/problems/minimum-cost-tree-from-leaf-values
public class S01130
{
    public int MctFromLeafValues(int[] arr)
    {
        Stack<int> stack = [];
        stack.Push(int.MaxValue);
        var result = 0;

        foreach (var n in arr)
        {
            while (stack.Peek() <= n)
            {
                var mid = stack.Pop();
                result += mid * Math.Min(stack.Peek(), n);
            }

            stack.Push(n);
        }

        while (stack.Count > 2)
        {
            result += stack.Pop() * stack.Peek();
        }

        return result;
    }
}
