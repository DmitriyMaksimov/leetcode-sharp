namespace leetcode_sharp;

// 2099. Find Subsequence of Length K With the Largest Sum
// https://leetcode.com/problems/find-subsequence-of-length-k-with-the-largest-sum/
public class S02099
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        return nums
            .Select((n, i) => new {n, i})
            .OrderByDescending(x => x.n)
            .Take(k)
            .OrderBy(x => x.i)
            .Select(x => x.n)
            .ToArray();
    }
}