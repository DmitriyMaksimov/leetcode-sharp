namespace leetcode_sharp;

// 962. Maximum Width Ramp
// https://leetcode.com/problems/maximum-width-ramp
public class S00962
{
    public int MaxWidthRamp(int[] nums)
    {
        List<int> s = [];
        var res = 0;

        for (var i = 0; i < nums.Length; ++i)
        {
            if (s.Count == 0 || nums[i] < nums[s[^1]])
            {
                s.Add(i);
            }
            else
            {
                var left = 0;
                var right = s.Count - 1;

                while (left < right)
                {
                    var mid = left + (right - left) / 2;

                    if (nums[s[mid]] > nums[i])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }

                res = Math.Max(res, i - s[left]);
            }
        }

        return res;
    }
}
