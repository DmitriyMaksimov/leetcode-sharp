namespace leetcode_sharp;

// 2399. Check Distances Between Same Letters
// https://leetcode.com/problems/check-distances-between-same-letters/
public class S02399
{
    public bool CheckDistances(string s, int[] distance)
    {
        var indexes = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var ch = s[i];

            if (indexes.TryGetValue(ch, out var first))
            {
                if (i - first - 1 != distance[ch - 'a'])
                {
                    return false;
                }
            }
            else
            {
                indexes.Add(ch, i);
            }
        }
        
        return true;
    }
}