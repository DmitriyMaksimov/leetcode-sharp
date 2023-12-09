namespace leetcode_sharp;

// 2442. Count Number of Distinct Integers After Reverse Operations
// https://leetcode.com/problems/count-number-of-distinct-integers-after-reverse-operations
public class S02442
{
    public int CountDistinctIntegers(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var reverseSet = new HashSet<int>(set.Select(reverse));

        set.UnionWith(reverseSet);

        return set.Count;
    }

    private static int reverse(int num)
    {
        var rev = 0;

        while (num != 0)
        {
            rev = rev * 10 + num % 10;
            num /= 10;
        }

        return rev;
    }
}