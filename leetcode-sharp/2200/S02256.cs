namespace leetcode_sharp;

// 2256. Minimum Average Difference
// https://leetcode.com/problems/minimum-average-difference/ 
public class S02256
{
    public int MinimumAverageDifference(int[] nums)
    {
        var longs = nums.Select(x => (long)x);
        var rightSum = longs.Sum();
        var numsLength = nums.Length;
        var averages = new long[numsLength];
        var leftSum = 0L;
        
        for (var i = 0; i < numsLength; i++)
        {
            leftSum += nums[i];
            rightSum -= nums[i];
            var numberOfElementsOnRight = numsLength - i - 1;
            if (numberOfElementsOnRight == 0)
            {
                numberOfElementsOnRight = 1;
            }
            averages[i] = Math.Abs(leftSum / (i + 1) - rightSum / numberOfElementsOnRight);
        }

        var minAverage = averages[0];
        var index = 0;
        
        for (var i = 1; i < averages.Length; i++)
        {
            if (averages[i] < minAverage)
            {
                minAverage = averages[i];
                index = i;
            }
        }
        
        return index;
    }
}