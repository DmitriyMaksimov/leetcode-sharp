namespace leetcode_sharp;

// 3653. XOR After Range Multiplication Queries I
// https://leetcode.com/problems/xor-after-range-multiplication-queries-i
public class S03653
{
    private const int Mod = 1_000_000_007;

    public int XorAfterQueries(int[] nums, int[][] queries)
    {
        foreach (var query in queries)
        {
            var l = query[0];
            var r = query[1];
            var k = query[2];
            var v = query[3];

            while (l <= r)
            {
                nums[l] = (int)((long)nums[l] * v % Mod);
                l += k;
            }
        }

        return nums.Aggregate(0, (current, num) => current ^ num);
    }
}