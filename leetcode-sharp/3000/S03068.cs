namespace leetcode_sharp;

// 3068. Find the Maximum Sum of Node Values
// https://leetcode.com/problems/find-the-maximum-sum-of-node-values
public class S03068
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges)
    {
        var totalSum = 0L;
        var count = 0;
        var positiveMin = int.MaxValue;
        var negativeMax = int.MinValue;

        foreach (var nodeValue in nums)
        {
            var nodeValAfterOperation = nodeValue ^ k;
            totalSum += nodeValue;
            var netChange = nodeValAfterOperation - nodeValue;

            if (netChange > 0)
            {
                positiveMin = Math.Min(positiveMin, netChange);
                totalSum += netChange;
                count++;
            }
            else
            {
                negativeMax = Math.Max(negativeMax, netChange);
            }
        }

        return count % 2 == 0 ? totalSum : Math.Max(totalSum - positiveMin, totalSum + negativeMax);
    }
}