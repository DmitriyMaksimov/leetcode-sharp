namespace leetcode_sharp;

// 1629. Slowest Key
// https://leetcode.com/problems/slowest-key/
public class S01629
{
    public char SlowestKey(int[] releaseTimes, string keysPressed)
    {
        var maxDuration = releaseTimes[0];
        var maxKey = keysPressed[0];

        for (var i = 1; i < releaseTimes.Length; i++)
        {
            var duration = releaseTimes[i] - releaseTimes[i - 1];
        
            if (duration > maxDuration)
            {
                maxDuration = duration;
                maxKey = keysPressed[i];
            }
            else if (duration == maxDuration)
            {
                maxKey = maxKey > keysPressed[i] ? maxKey : keysPressed[i];
            }
        }

        return maxKey;
    }
}