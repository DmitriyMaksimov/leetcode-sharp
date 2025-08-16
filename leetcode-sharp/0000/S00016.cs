namespace leetcode_sharp;

// 16. 3Sum Closest
// https://leetcode.com/problems/3sum-closest
public class S00016
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums);
        var result = nums[0] + nums[1] + nums[2];

        for (var i = 0; i < nums.Length - 2; i++)
        {
            var left = i + 1;
            var right = nums.Length - 1;

            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];

                if (Math.Abs(target - sum) < Math.Abs(target - result))
                {
                    result = sum;
                }

                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        return result;
    }
}