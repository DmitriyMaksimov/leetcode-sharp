namespace leetcode_sharp;

// 2279. Maximum Bags With Full Capacity of Rocks
// https://leetcode.com/problems/maximum-bags-with-full-capacity-of-rocks/
public class S02279
{
    public int MaximumBags(int[] capacity, int[] rocks, int additionalRocks)
    {
        var canFit = new int[capacity.Length];
        for (var i = 0; i < capacity.Length; i++)
        {
            canFit[i] = capacity[i] - rocks[i];
        }
        
        Array.Sort(canFit);
        var count = 0;
        
        foreach (var n in canFit)
        {
            if (n <= additionalRocks)
            {
                count++;
                additionalRocks -= n;
            }
            else
            {
                break;
            }
        }
        
        return count;
    }
}