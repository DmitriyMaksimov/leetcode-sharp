namespace leetcode_sharp;

// 1262. Greatest Sum Divisible by Three
// https://leetcode.com/problems/greatest-sum-divisible-by-three
public class S01262
{
    public int MaxSumDivThree(int[] nums)
    {
        int[] current = [0, int.MinValue, int.MinValue];

        foreach (var num in nums)
        {
            var previous = (int[])current.Clone();

            for (var r = 0; r < current.Length; r++)
            {
                current[r] = Math.Max(num + previous[(r + num) % 3], previous[r]);
            }
        }

        return current[0];
    }
}
