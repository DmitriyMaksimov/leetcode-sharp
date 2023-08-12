namespace leetcode_sharp;

// 84. Largest Rectangle in Histogram
// https://leetcode.com/problems/largest-rectangle-in-histogram/
public class S00084
{
    public int LargestRectangleArea(int[] heights)
    {
        var n = heights.Length;
        var stack = new Stack<int>();
        var leftSmall = new int[n];
        var rightSmall = new int[n];

        for (var i = 0; i < n; i++)
        {
            while (stack.Any() && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }

            leftSmall[i] = stack.Any() ? stack.Peek() + 1 : 0;
            stack.Push(i);
        }

        stack.Clear();

        for (var i = n - 1; i >= 0; i--)
        {
            while (stack.Any() && heights[stack.Peek()] >= heights[i])
            {
                stack.Pop();
            }

            rightSmall[i] = stack.Any() ? stack.Peek() - 1 : n - 1;

            stack.Push(i);
        }

        var maxA = 0;

        for (var i = 0; i < n; i++)
        {
            maxA = Math.Max(maxA, heights[i] * (rightSmall[i] - leftSmall[i] + 1));
        }

        return maxA;
    }
}