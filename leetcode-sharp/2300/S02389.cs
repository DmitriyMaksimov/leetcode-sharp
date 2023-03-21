namespace leetcode_sharp;

// 2389. Longest Subsequence With Limited Sum
// https://leetcode.com/problems/longest-subsequence-with-limited-sum/
public class S02389
{
    public int[] AnswerQueries(int[] nums, int[] queries)
    {
        Array.Sort(nums);
        var answers = new int[queries.Length];
        for (var i = 0; i < queries.Length; i++)
        {
            var sum = 0;
            var j = 0;

            while (j < nums.Length && sum <= queries[i])
            {
                sum += nums[j++];
            }

            answers[i] = sum > queries[i] ? j - 1 : j;
        }

        return answers;
    }
}