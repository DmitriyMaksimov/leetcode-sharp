namespace leetcode_sharp;

// 477. Total Hamming Distance
// https://leetcode.com/problems/total-hamming-distance
public class S00477
{
    public int TotalHammingDistance(int[] nums)
    {
        var result = 0;
        var n = nums.Length;

        for (var j = 0; j < 32; j++)
        {
            var bitCount = 0;

            for (var i = 0; i < n; i++)
            {
                bitCount += (nums[i] >> j) & 1;
            }

            result += bitCount * (n - bitCount);
        }

        return result;
    }
}
