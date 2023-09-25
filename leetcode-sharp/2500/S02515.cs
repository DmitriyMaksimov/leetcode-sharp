namespace leetcode_sharp;

// 2515. Shortest Distance to Target String in a Circular Array
// https://leetcode.com/problems/shortest-distance-to-target-string-in-a-circular-array/
public class S02515
{
    public int ClosetTarget(string[] words, string target, int startIndex)
    {
        var n = words.Length;
        var ans = int.MaxValue;

        for (var i = 0; i < n; i++)
        {
            if (words[i] == target)
            {
                ans = Math.Min(ans, Math.Min(Math.Abs(i - startIndex), n - Math.Abs(i - startIndex)));
            }
        }

        return ans == int.MaxValue ? -1 : ans;
    }
}