namespace leetcode_sharp;

// 2501. Longest Square Streak in an Array
// https://leetcode.com/problems/longest-square-streak-in-an-array
public class S02501
{
    public int LongestSquareStreak(int[] nums)
    {
        Array.Sort(nums);
        Dictionary<int, int> dictionary = [];
        var result = -1;

        foreach (var x in nums)
        {
            var perfect = (int)Math.Sqrt(x);

            if (perfect * perfect == x && dictionary.TryGetValue(perfect, out var value))
            {
                dictionary[x] = value + 1;
                result = Math.Max(value + 1, result);
            }
            else
            {
                dictionary[x] = 1;
            }
        }

        return result;
    }
}
