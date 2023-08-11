namespace leetcode_sharp;

// 31. Next Permutation
// https://leetcode.com/problems/next-permutation/
public class S00031
{
    public void NextPermutation(int[] nums)
    {
        int i;
        var min = int.MaxValue;
        var pivot = 0;
        var pos = 0;

        for (i = nums.Length - 1; i >= 1; i--)
        {
            if (nums[i] <= nums[i - 1]) continue;
            pivot = i;
            break;
        }

        if (pivot > 0)
        {
            for (i = pivot; i < nums.Length; i++)
            {
                if (nums[i] > nums[pivot - 1])
                {
                    min = Math.Min(min, nums[i]);
                }

                if (min == nums[i])
                {
                    pos = i;
                }
            }

            (nums[pos], nums[pivot - 1]) = (nums[pivot - 1], nums[pos]);
        }

        //reverse from pivot to end
        var high = nums.Length - 1;
        while (pivot <= high)
        {
            (nums[high], nums[pivot]) = (nums[pivot], nums[high]);
            high--;
            pivot++;
        }
    }
}