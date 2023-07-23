namespace leetcode_sharp;

// 1822. Sign of the Product of an Array
// https://leetcode.com/problems/sign-of-the-product-of-an-array/
public class S01822
{
    public int ArraySign(int[] nums)
    {
        var isPositive = true;
        foreach (var num in nums)
        {
            switch (num)
            {
                case 0:
                    return 0;
                case < 0:
                    isPositive = !isPositive;
                    break;
            }
        }
        
        return isPositive ? 1 : -1;
    }
}