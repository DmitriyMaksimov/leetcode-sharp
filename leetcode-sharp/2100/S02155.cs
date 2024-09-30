namespace leetcode_sharp;

// 2155. All Divisions With the Highest Score of a Binary Array
// https://leetcode.com/problems/all-divisions-with-the-highest-score-of-a-binary-array
public class S02155
{
    public IList<int> MaxScoreIndices(int[] nums)
    {
        var ones = nums.Sum();
        var zeros = 0;
        var score = 0;

        List<int> res = [];

        for (var i = 0; i <= nums.Length; ++i)
        {
            if (ones + zeros > score)
            {
                score = ones + zeros;
                res.Clear();
            }

            if (ones + zeros == score)
            {
                res.Add(i);
            }

            if (i < nums.Length)
            {
                zeros += nums[i] == 0 ? 1 : 0;
                ones -= nums[i];
            }
        }

        return res;
    }
}
