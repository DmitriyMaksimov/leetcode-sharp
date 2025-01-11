namespace leetcode_sharp;

// 1673. Find the Most Competitive Subsequence
// https://leetcode.com/problems/find-the-most-competitive-subsequence
public class S01673
{
    public int[] MostCompetitive(int[] nums, int k)
    {
        var stack = new Stack<int>();
        var numsToDelete = nums.Length - k;

        foreach (var num in nums)
        {
            while (stack.Count > 0 && num < stack.Peek() && numsToDelete > 0)
            {
                stack.Pop();
                numsToDelete--;
            }

            stack.Push(num);
        }

        return stack.Reverse().Take(k).ToArray();
    }
}
