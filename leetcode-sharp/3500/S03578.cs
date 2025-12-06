namespace leetcode_sharp;

// 3578. Count Partitions With Max-Min Difference at Most K
// https://leetcode.com/problems/count-partitions-with-max-min-difference-at-most-k
public class S03578
{
    private const int Mod = 1_000_000_007;

    public int CountPartitions(int[] nums, int k)
    {
        var n = nums.Length;

        var dp = new int[n + 1];
        var acc = new int[n + 2];

        dp[0] = 1;
        acc[1] = 1;

        var minQ = new LinkedList<int>();
        var maxQ = new LinkedList<int>();

        var i = 0;

        for (var j = 0; j < n; j++)
        {
            while (maxQ.Count > 0 && nums[j] > nums[maxQ.Last!.Value])
            {
                maxQ.RemoveLast();
            }

            maxQ.AddLast(j);

            while (minQ.Count > 0 && nums[j] < nums[minQ.Last!.Value])
            {
                minQ.RemoveLast();
            }

            minQ.AddLast(j);

            while (nums[maxQ.First!.Value] - nums[minQ.First!.Value] > k)
            {
                i++;

                if (minQ.First!.Value < i)
                {
                    minQ.RemoveFirst();
                }

                if (maxQ.First!.Value < i)
                {
                    maxQ.RemoveFirst();
                }
            }

            dp[j + 1] = (acc[j + 1] - acc[i] + Mod) % Mod;
            acc[j + 2] = (acc[j + 1] + dp[j + 1]) % Mod;
        }

        return dp[n];
    }
}