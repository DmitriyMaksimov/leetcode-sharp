namespace leetcode_sharp;

// 75. Sort Colors
// https://leetcode.com/problems/sort-colors/
public class S00075
{
    public void SortColors(int[] nums)
    {
        var numberOfZeros = 0;
        var numberOfOnes = 0;
        foreach (var num in nums)
        {
            switch (num)
            {
                case 0:
                    ++numberOfZeros;
                    break;
                case 1:
                    ++numberOfOnes;
                    break;
            }
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (i > numberOfZeros + numberOfOnes - 1)
            {
                nums[i] = 2;
            }
            else if (i > numberOfZeros - 1)
            {
                nums[i] = 1;
            }
            else
            {
                nums[i] = 0;
            }
        }
    }
}