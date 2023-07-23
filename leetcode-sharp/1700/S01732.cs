namespace leetcode_sharp;

// 1732. Find the Highest Altitude
// https://leetcode.com/problems/find-the-highest-altitude/
public class S01732
{
    public int LargestAltitude(int[] gain)
    {
        var currentAttitude = 0;
        var maxAttitude = 0;

        foreach (var currentGain in gain)
        {
            currentAttitude += currentGain;
            maxAttitude = Math.Max(maxAttitude, currentAttitude);
        }
        
        return maxAttitude;
    }
}