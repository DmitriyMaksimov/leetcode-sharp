namespace leetcode_sharp;

// 961. N-Repeated Element in Size 2N Array
// https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
public class S00961
{
    public int RepeatedNTimes(int[] nums)
    {
        var hashSet = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!hashSet.Add(num))
            {
                return num;
            }
        }
        
        return 0;
    }
}