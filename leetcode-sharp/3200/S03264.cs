namespace leetcode_sharp;

// 3264. Final Array State After K Multiplication Operations I
// https://leetcode.com/problems/final-array-state-after-k-multiplication-operations-i
public class S03264
{
    public int[] GetFinalState(int[] nums, int k, int multiplier)
    {
        while (k-- > 0)
        {
            var index = nums.Select((item, index) => (item, index)).Min().index;
            nums[index] *= multiplier;
        }

        return nums;
    }
}
