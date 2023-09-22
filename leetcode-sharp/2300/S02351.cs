namespace leetcode_sharp;

// 2351. First Letter to Appear Twice
// https://leetcode.com/problems/first-letter-to-appear-twice/
public class S02351
{
    public char RepeatedCharacter(string s)
    {
        var set = new HashSet<char>();

        foreach (var c in s)
        {
            if (set.Contains(c))
            {
                return c;
            }

            set.Add(c);
        }

        return ' ';
    }
}