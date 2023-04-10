namespace leetcode_sharp;

// 1608. Special Array With X Elements Greater Than or Equal X
// https://leetcode.com/problems/special-array-with-x-elements-greater-than-or-equal-x/
public class S01608
{
    public int SpecialArray(int[] nums)
    {
        var counts = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            counts[n] = counts.GetValueOrDefault(n) + 1;
        }

        var number = nums.Length;

        // Size of nums array is 100 at most
        for (var i = 0; i <= 100; i++)
        {
            if (number == i)
            {
                return i;
            }

            number -= counts.GetValueOrDefault(i);
        }

        return -1;
    }
}