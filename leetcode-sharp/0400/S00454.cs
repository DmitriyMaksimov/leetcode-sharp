namespace leetcode_sharp;

// 454. 4Sum II
// https://leetcode.com/problems/4sum-ii
public class S00454
{
    public int FourSumCount(int[] nums1, int[] nums2, int[] nums3, int[] nums4)
    {
        var map = new Dictionary<int, int>();

        foreach (var c in nums3)
        {
            foreach (var d in nums4)
            {
                var sum = c + d;
                map[sum] = map.GetValueOrDefault(sum) + 1;
            }
        }

        var result = 0;

        foreach (var a in nums1)
        {
            foreach (var b in nums2)
            {
                var target = -(a + b);
                if (map.TryGetValue(target, out var value))
                {
                    result += value;
                }
            }
        }

        return result;
    }
}
