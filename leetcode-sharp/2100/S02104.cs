namespace leetcode_sharp;

// 2104. Sum of Subarray Ranges
// https://leetcode.com/problems/sum-of-subarray-ranges
public class S02104
{
    public long SubArrayRanges(int[] nums)
    {
        var n = nums.Length;
        int j;
        int k;
        long res = 0;

        var stack = new Stack<int>();

        for (var i = 0; i <= n; i++)
        {
            while (stack.Count > 0 && nums[stack.Peek()] > (i == n ? int.MinValue : nums[i]))
            {
                j = stack.Pop();
                k = stack.Count == 0 ? -1 : stack.Peek();
                res -= (long)nums[j] * (i - j) * (j - k);
            }

            stack.Push(i);
        }

        stack.Clear();

        for (var i = 0; i <= n; i++)
        {
            while (stack.Count > 0 && nums[stack.Peek()] < (i == n ? int.MaxValue : nums[i]))
            {
                j = stack.Pop();
                k = stack.Count == 0 ? -1 : stack.Peek();
                res += (long)nums[j] * (i - j) * (j - k);
            }

            stack.Push(i);
        }

        return res;
    }
}
