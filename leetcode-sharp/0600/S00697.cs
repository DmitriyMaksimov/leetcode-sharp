namespace leetcode_sharp;

// 697. Degree of an Array
// https://leetcode.com/problems/degree-of-an-array/
public class S00697
{
    public int FindShortestSubArray(int[] nums)
    {
        var dict = new Dictionary<int, int[]>();
        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];

            if (!dict.ContainsKey(num))
            {
                dict.Add(num, new[] { 1, i, i });
            }
            else
            {
                dict[num][0]++;
                dict[num][2] = i;
            }
        }

        var max = 0;
        var min = 0;
        
        foreach (var kv in dict)
        {
            if (kv.Value[0] > max)
            {
                max = kv.Value[0];
                min = kv.Value[2] - kv.Value[1] + 1;
            }
            else if (kv.Value[0] == max)
            {
                min = Math.Min(min, kv.Value[2] - kv.Value[1] + 1);
            }
        }

        return min;
    }
}