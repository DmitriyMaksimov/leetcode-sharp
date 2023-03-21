namespace leetcode_sharp;

// 1567. Maximum Length of Subarray With Positive Product
// https://leetcode.com/problems/maximum-length-of-subarray-with-positive-product/
public class S01567
{
    public int GetMaxLen(int[] nums)
    {
        var numberOfPositive = 0;
        var numberOfNegative = 0;
        var result = 0;
        
        foreach (var x in nums)
        {
            switch (x)
            {
                case 0:
                    numberOfPositive = 0;
                    numberOfNegative = 0;
                    break;
                case > 0:
                    numberOfPositive++;
                    numberOfNegative = numberOfNegative == 0 ? 0 : numberOfNegative + 1;
                    break;
                default:
                {
                    var temp = numberOfPositive;
                    numberOfPositive = numberOfNegative == 0 ? 0 : numberOfNegative + 1;
                    numberOfNegative = temp + 1;
                    break;
                }
            }

            result = Math.Max(result, numberOfPositive);
        }

        return result;
    }
}