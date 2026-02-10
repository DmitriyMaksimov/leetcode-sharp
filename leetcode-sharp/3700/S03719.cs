namespace leetcode_sharp;

// 3719. Longest Balanced Subarray I
// https://leetcode.com/problems/longest-balanced-subarray-i
public class S03719
{
    public int LongestBalanced(int[] nums)
    {
        var n = nums.Length;
        var maxLen = 0;

        for (var i = 0; i < n; i++)
        {
            var evenSet = new HashSet<int>();
            var oddSet = new HashSet<int>();

            for (var j = i; j < n; j++)
            {
                var val = nums[j];

                if (val % 2 == 0)
                {
                    evenSet.Add(val);
                }
                else
                {
                    oddSet.Add(val);
                }

                if (evenSet.Count == oddSet.Count)
                {
                    var currentLen = j - i + 1;
                    maxLen = Math.Max(maxLen, currentLen);
                }
            }
        }

        return maxLen;
    }
}