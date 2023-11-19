namespace leetcode_sharp;

// 2917. Find the K-or of an Array
// https://leetcode.com/problems/find-the-k-or-of-an-array
public class S02917
{
    public int FindKOr(int[] nums, int k)
    {
        var dp = new int[31];

        foreach (var n in nums)
        {
            var num = n;
            var i = 0;
            while (num > 0)
            {
                if ((num & 1) == 1)
                {
                    dp[i] += 1;
                }

                i += 1;
                num >>= 1;
            }
        }
        
        var answer = 0;

        for (var i = 0; i < 31; i++)
        {
            if (dp[i] >= k)
            {
                answer += 1 << i;
            }
        }

        return answer;
    }
}