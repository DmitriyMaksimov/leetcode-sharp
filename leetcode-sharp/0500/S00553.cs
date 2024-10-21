namespace leetcode_sharp;

// 553. Optimal Division
// https://leetcode.com/problems/optimal-division
public class S00553
{
    public string OptimalDivision(int[] nums)
    {
        if (nums.Length <= 2)
        {
            return string.Join("/", nums.Select(n => n.ToString()));
        }

        return $"{nums[0]}/(" + string.Join("/", nums.Skip(1).Select(n => n.ToString())) + ")";
    }
}
