namespace leetcode_sharp;

// 1014. Best Sightseeing Pair
// https://leetcode.com/problems/best-sightseeing-pair/
public class S01014
{
    public int MaxScoreSightseeingPair(int[] values)
    {
        var currentMax = 0;
        var result = 0;
        
        foreach (var value in values)
        {
            result = Math.Max(result, currentMax + value);
            currentMax = Math.Max(currentMax, value) - 1;
        }
        
        return result;
    }
}