namespace leetcode_sharp;

// 3769. Sort Integers by Binary Reflection
// https://leetcode.com/problems/sort-integers-by-binary-reflection
public class S03769
{
    public int[] SortByReflection(int[] nums)
    {
        return nums
            .OrderBy(ReflectValue)
            .ThenBy(n => n)
            .ToArray();
    }

    private static int ReflectValue(int n)
    {
        var reflected = 0;

        while (n > 0)
        {
            reflected = (reflected << 1) | (n & 1);
            n >>= 1;
        }

        return reflected;
    }
}