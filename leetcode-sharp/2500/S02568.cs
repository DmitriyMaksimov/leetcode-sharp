namespace leetcode_sharp;

// 2568. Minimum Impossible OR
// https://leetcode.com/problems/minimum-impossible-or
public class S02568
{
    public int MinImpossibleOR(int[] nums)
    {
        var s = new HashSet<int>();

        // Add all elements of A to the HashSet
        foreach (var num in nums)
        {
            s.Add(num);
        }

        var result = 1;

        while (s.Contains(result))
        {
            result *= 2;
        }

        return result;
    }
}
