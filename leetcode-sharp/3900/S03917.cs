namespace leetcode_sharp;

// 3917. Count Indices With Opposite Parity
// Bhttps://leetcode.com/problems/count-indices-with-opposite-parity
public class S03917
{
    public int[] CountOppositeParity(int[] nums)
    {
        var evenCount = 0;
        var oddCount = 0;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (nums[i] % 2 == 0)
            {
                nums[i] = oddCount; 
                evenCount++;
            }
            else
            {
                nums[i] = evenCount;
                oddCount++;
            }
        }

        return nums;
    }
}