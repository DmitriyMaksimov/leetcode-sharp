namespace leetcode_sharp;

// 442. Find All Duplicates in an Array
// https://leetcode.com/problems/find-all-duplicates-in-an-array
public class S00442
{
    public IList<int> FindDuplicates(int[] nums)
    {
        List<int> res = [];

        foreach (var num in nums)
        {
            var index = Math.Abs(num) - 1;
            
            if (nums[index] < 0)
            {
                res.Add(Math.Abs(index + 1));
            }

            nums[index] = -nums[index];
        }

        return res;
    }
}