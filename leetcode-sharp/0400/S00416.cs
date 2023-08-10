namespace leetcode_sharp;

// 416. Partition Equal Subset Sum
// https://leetcode.com/problems/partition-equal-subset-sum/
public class S00416
{
    public bool CanPartition(int[] nums)
    {
        var sum = nums.Sum();
        if (sum % 2 != 0)
        {
            return false;
        }

        var n = nums.Length;
        sum /= 2;
        var possible = new bool[n + 1, sum + 1];

        for (var i = 1; i <= sum; i++)
        {
            possible[0, i] = false;
        }

        for (var i = 0; i <= n; i++)
        {
            possible[i, 0] = true;
        }

        for (var i = 1; i <= n; i++)
        {
            for (var j = 1; j <= sum; j++)
            {
                if (nums[i - 1] > j)
                {
                    possible[i, j] = possible[i - 1, j];
                }
                else
                {
                    possible[i, j] = possible[i - 1, j - nums[i - 1]] || possible[i - 1, j];
                }
            }
        }

        return possible[n, sum];
    }
}