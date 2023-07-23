namespace leetcode_sharp;

// 1636. Sort Array by Increasing Frequency
// https://leetcode.com/problems/sort-array-by-increasing-frequency/
public class S01636
{
    public int[] FrequencySort(int[] nums)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            dictionary[n] = dictionary.GetValueOrDefault(n, 0) + 1;
        }

        var i = 0;
        foreach (var (value, frequency) in dictionary.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
        {
            for (var j = 0; j < frequency; j++)
            {
                nums[i++] = value;
            }
        }
        
        return nums;
    }
}