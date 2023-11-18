namespace leetcode_sharp;

// 2855. Minimum Right Shifts to Sort the Array
// https: //leetcode.com/problems/minimum-right-shifts-to-sort-the-array
public class S02855
{
    public int MinimumRightShifts(IList<int> nums)
    {
        var i = 0;
        while (i < nums.Count - 1 && nums[i] < nums[i + 1])
        {
            i++;
        }

        var j = i;

        while (i < nums.Count - 1 && nums[j] > nums[i + 1])
        {
            i++;
            if (i < nums.Count - 1 && (nums[i] > nums[i + 1] || nums[i + 1] > nums[0]))
            {
                return -1;
            }
        }

        return i != nums.Count - 1 ? -1 : (nums.Count - 1) - j;
    }
}