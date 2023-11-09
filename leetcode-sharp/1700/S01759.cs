namespace leetcode_sharp;

// 1759. Count Number of Homogenous Substrings
// https://leetcode.com/problems/count-number-of-homogenous-substrings
public class S01759
{
    private const int Mod = 1_000_000_007;

    public int CountHomogenous(string s)
    {
        var answer = 0;
        var currFreq = 0;
        var lastChar = '\0';

        foreach (var c in s)
        {
            if (c == lastChar)
            {
                currFreq++;
            }
            else
            {
                currFreq = 1;
                lastChar = c;
            }

            answer = (answer + currFreq) % Mod;
        }

        return answer;
    }
}