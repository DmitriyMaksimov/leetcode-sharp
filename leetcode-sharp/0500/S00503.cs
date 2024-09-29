namespace leetcode_sharp;

// 503. Next Greater Element II
// https://leetcode.com/problems/next-greater-element-ii
public class S00503
{
    public int[] NextGreaterElements(int[] nums)
    {
        var n = nums.Length;
        var next = Enumerable.Repeat(-1, n).ToArray();
        Stack<int> stack = [];

        for (var i = 0; i < n * 2; i++)
        {
            var num = nums[i % n];

            while (stack.Count != 0 && nums[stack.Peek()] < num)
            {
                next[stack.Pop()] = num;
            }

            if (i < n)
            {
                stack.Push(i);
            }
        }

        return next;
    }
}
