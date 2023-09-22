namespace leetcode_sharp;

// 2341. Maximum Number of Pairs in Array
// https://leetcode.com/problems/maximum-number-of-pairs-in-array/
public class S02341
{
    public int[] NumberOfPairs(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            dict[num] = dict.GetValueOrDefault(num) + 1;
        }

        var result = new int[2];

        foreach (var value in dict.Values)
        {
            result[0] += value / 2;
            result[1] += value % 2;
        }

        return result;
    }
}