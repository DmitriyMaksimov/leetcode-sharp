namespace leetcode_sharp;

// 2027. Minimum Moves to Convert String
// https://leetcode.com/problems/minimum-moves-to-convert-string/
public class S02027
{
    public int MinimumMoves(string s)
    {
        var count = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] != 'X') continue;
            
            count++;
            i += 2;
        }

        return count;
    }
}