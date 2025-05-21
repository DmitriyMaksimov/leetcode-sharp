namespace leetcode_sharp;

// 2216. Minimum Deletions to Make Array Beautiful
// https://leetcode.com/problems/minimum-deletions-to-make-array-beautiful
public class S02216
{
    public int MinDeletion(int[] nums)
    {
        var numberOfDuplicates = 0;

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1] && (i - numberOfDuplicates) % 2 == 0)
            {
                numberOfDuplicates++;
            }
        }

        return numberOfDuplicates + (nums.Length - numberOfDuplicates) % 2;
    }
}
