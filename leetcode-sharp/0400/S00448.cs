namespace leetcode_sharp;

// 448. Find All Numbers Disappeared in an Array
// https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
public class S00448
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        foreach (var num in nums)
        {
            var idx = Math.Abs(num) - 1;

            if (nums[idx] > 0)
            {
                nums[idx] = -nums[idx];
            }
        }

        var list = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                list.Add(i + 1);
            }
        }

        return list;
    }
}