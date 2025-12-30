namespace leetcode_sharp;

// 3707. Equal Score Substrings
// https://leetcode.com/problems/equal-score-substrings
public class S03707
{
    public bool ScoreBalance(string s)
    {
        var leftSum = 0;
        var rightSum = s.Select(c => c - 'a' + 1).Sum();

        foreach (var charScore in s.Select(ch => ch - 'a' + 1))
        {
            leftSum += charScore;
            rightSum -= charScore;

            if (leftSum == rightSum)
            {
                return true;
            }
        }

        return false;
    }
}