namespace leetcode_sharp;

// 2149. Rearrange Array Elements by Sign
// https://leetcode.com/problems/rearrange-array-elements-by-sign
public class S02149
{
    public int[] RearrangeArray(int[] nums)
    {
        var result = new int[nums.Length];
        var positiveIndex = 0;
        var negativeIndex = 1;

        foreach (var num in nums)
        {
            switch (num)
            {
                case > 0:
                    result[positiveIndex] = num;
                    positiveIndex += 2;
                    break;
                case < 0:
                    result[negativeIndex] = num;
                    negativeIndex += 2;
                    break;
            }
        }
        
        return result;
    }
}