namespace leetcode_sharp;

// 821. Shortest Distance to a Character
// https://leetcode.com/problems/shortest-distance-to-a-character/
public class S00821
{
    public int[] ShortestToChar(string s, char c)
    {
        var result = new int[s.Length];
        var prev = int.MinValue / 2;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                prev = i;
            }

            result[i] = i - prev;
        }

        prev = int.MaxValue / 2;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == c)
            {
                prev = i;
            }

            result[i] = Math.Min(result[i], prev - i);
        }

        return result;
    }
}