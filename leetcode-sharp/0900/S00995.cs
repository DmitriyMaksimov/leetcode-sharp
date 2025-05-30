namespace leetcode_sharp;

// 995. Minimum Number of K Consecutive Bit Flips
// https://leetcode.com/problems/minimum-number-of-k-consecutive-bit-flips
public class S00995
{
    public int MinKBitFlips(int[] nums, int k)
    {
        var result = 0;
        Queue<int> flips = [];

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != (flips.Count % 2 != 0 ? 0 : 1))
            {
                ++result;
                flips.Enqueue(i + k - 1);
            }

            if (flips.Count != 0 && flips.Peek() <= i) flips.Dequeue();
        }

        return flips.Count == 0 ? result : -1;
    }
}
