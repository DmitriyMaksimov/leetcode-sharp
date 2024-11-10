namespace leetcode_sharp;

// 3097. Shortest Subarray With OR at Least K II
// https://leetcode.com/problems/shortest-subarray-with-or-at-least-k-ii
public class S03097
{
    public int MinimumSubarrayLength(int[] nums, int k)
    {
        var counts = new int[30];
        var cur = 0;
        var res = int.MaxValue;

        for (int i = 0, j = 0; i < nums.Length; i++)
        {
            for (var b = 0; b < counts.Length; b++)
            {
                if ((nums[i] & (1 << b)) == 0)
                {
                    continue;
                }

                if (++counts[b] == 1)
                {
                    cur += 1 << b;
                }
            }

            while (cur >= k && j <= i)
            {
                res = Math.Min(res, i - j + 1);

                for (var b = 0; b < counts.Length; b++)
                {
                    if ((nums[j] & (1 << b)) == 0)
                    {
                        continue;
                    }

                    if (--counts[b] == 0)
                    {
                        cur -= 1 << b;
                    }
                }

                j++;
            }
        }

        return res == int.MaxValue ? -1 : res;
    }
}
