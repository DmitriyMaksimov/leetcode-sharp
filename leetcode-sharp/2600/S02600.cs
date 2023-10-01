namespace leetcode_sharp;

// 2600. K Items With the Maximum Sum
// https://leetcode.com/problems/k-items-with-the-maximum-sum
public class S02600
{
    public int KItemsWithMaximumSum(int numOnes, int numZeros, int numNegOnes, int k)
    {
        var sum = 0;

        if (k > 0)
        {
            var n = Math.Min(numOnes, k);
            sum += n;
            k -= n;
        } 
        
        if (k > 0)
        {
            var n = Math.Min(numZeros, k);
            k -= n;
        } 
        
        if (k > 0)
        {
            var n = Math.Min(numNegOnes, k);
            sum -= n;
        } 
        
        return sum;
    }
}