namespace leetcode_sharp;

// Number of Changing Keys
public class S100215
{
    public int CountKeyChanges(string s)
    {
        s = s.ToLower();
        var count = 0;
        var lastKey = s[0];

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] != lastKey)
            {
                lastKey = s[i];
                ++count;
            }
        }

        return count;
    }
}