namespace leetcode_sharp;

// 2780. Minimum Index of a Valid Split
// https://leetcode.com/problems/minimum-index-of-a-valid-split
public class S02780
{
    public int MinimumIndex(IList<int> nums)
    {
        var map = new Dictionary<int, int> { [0] = 0 };
        var max = 0;
        var m = nums.Count;

        foreach (var num in nums)
        {
            map[num] = map.GetValueOrDefault(num) + 1;

            if (map[num] > map[max])
            {
                max = num;
            }
        }

        var freq = 0;

        for (var i = 0; i < m; i++)
        {
            if (nums[i] == max)
            {
                freq++;
            }

            if (freq * 2 > i + 1 && (map[max] - freq) * 2 > m - i - 1)
            {
                return i;
            }
        }

        return -1;
    }
}
