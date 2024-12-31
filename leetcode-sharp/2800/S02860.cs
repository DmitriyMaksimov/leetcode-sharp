namespace leetcode_sharp;

// 2860. Happy Students
// https://leetcode.com/problems/happy-students
public class S02860
{
    public int CountWays(IList<int> nums)
    {
        nums = nums.Order().ToList();

        var result = nums[0] == 0 ? 0 : 1;

        for (var i = 0; i < nums.Count; ++i)
        {
            var countWith = i + 1;

            if (countWith > nums[i] && (i + 1 == nums.Count || countWith < nums[i + 1]))
            {
                result++;
            }
        }

        return result;
    }
}
