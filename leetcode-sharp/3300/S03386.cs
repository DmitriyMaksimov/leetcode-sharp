namespace leetcode_sharp;

// 3386. Button with Longest Push Time
//https://leetcode.com/problems/button-with-longest-push-time
public class S03386
{
    public int ButtonWithLongestTime(int[][] events)
    {
        var currentIndex = events[0][0];
        var currentMaxTime = events[0][1];

        for (var i = 1; i < events.Length; i++)
        {
            var buttonIndex = events[i][0];
            var buttonTime = events[i][1] - events[i - 1][1];

            if (buttonTime >= currentMaxTime)
            {
                currentIndex = buttonTime == currentMaxTime ? Math.Min(currentIndex, buttonIndex) : buttonIndex;
                currentMaxTime = buttonTime;
            }
        }

        return currentIndex;
    }
}
