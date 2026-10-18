namespace leetcode_sharp;

// 4048. Count Values With Equally Spaced Occurrences I
// https://leetcode.com/problems/count-values-with-equally-spaced-occurrences-i
public class S04048
{
    public int CountSpecialIntegers(int[] nums)
    {
        var groups = new Dictionary<int, List<int>>();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            groups.TryAdd(num, []);
            groups[num].Add(i);
        }

        var result = 0;

        foreach (var (_, indexes) in groups.Where(pair => pair.Value.Count == 3))
        {
            if ((indexes[2] - indexes[1]) == (indexes[1] - indexes[0]))
            {
                ++result;
            }
        }

        return result;
    }
}