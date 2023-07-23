namespace leetcode_sharp;

// 2367. Number of Arithmetic Triplets
// https://leetcode.com/problems/number-of-arithmetic-triplets/
public class S02367
{
    public int ArithmeticTriplets(int[] nums, int diff)
    {
        var hashSet = new HashSet<int>();
        var res = 0;

        foreach (var n in nums)
        {
            if (n >= 2 * diff && hashSet.Contains(n - diff) && hashSet.Contains(n - 2 * diff))
            {
                ++res;
            }

            hashSet.Add(n);
        }

        return res;
    }
}