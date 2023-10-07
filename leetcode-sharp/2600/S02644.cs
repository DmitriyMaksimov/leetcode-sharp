namespace leetcode_sharp;

// 2644. Find the Maximum Divisibility Score
// https://leetcode.com/problems/find-the-maximum-divisibility-score
public class S02644
{
    public int MaxDivScore(int[] nums, int[] divisors)
    {
        var result = 0;
        var current = -1;

        foreach (var divisor in divisors)
        {
            var score = nums.Sum(num => num % divisor == 0 ? 1 : 0);

            if (score >= current)
            {
                result = score == current ? Math.Min(result, divisor) : divisor;
                current = score;
            }
        }

        return result;
    }
}