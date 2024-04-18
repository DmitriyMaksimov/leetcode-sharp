namespace leetcode_sharp;

// 3110. Score of a String
// https://leetcode.com/problems/score-of-a-string/
public class S03110
{
    public int ScoreOfString(string s)
    {
        var score = 0;
        
        for (var i = 1; i < s.Length; i++)
        {
            score += Math.Abs(s[i] - s[i - 1]);
        }

        return score;
    }
}