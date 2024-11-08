namespace leetcode_sharp;

// 1296. Divide Array in Sets of K Consecutive Numbers
// https://leetcode.com/problems/divide-array-in-sets-of-k-consecutive-numbers
public class S01296
{
    public bool IsPossibleDivide(int[] nums, int k)
    {
        if (nums.Length % k != 0)
        {
            return false;
        }

        var dictionary = new SortedDictionary<int, int>();

        foreach (var num in nums)
        {
            dictionary[num] = dictionary.GetValueOrDefault(num) + 1;
        }

        while (dictionary.Count > 0)
        {
            var first = dictionary.First().Key;

            for (var i = first; i < first + k; i++)
            {
                if (!dictionary.TryGetValue(i, out var value))
                {
                    return false;
                }

                dictionary[i] = --value;

                if (value == 0)
                {
                    dictionary.Remove(i);
                }
            }
        }

        return true;
    }
}