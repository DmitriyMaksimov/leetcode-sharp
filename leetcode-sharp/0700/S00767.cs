namespace leetcode_sharp;

// 767. Reorganize String
// https://leetcode.com/problems/reorganize-string/
public class S00767
{
    public string ReorganizeString(string s)
    {
        var freqMap = new Dictionary<char, int>();
        foreach (var c in s)
        {
            freqMap.TryAdd(c, 0);
            freqMap[c]++;
        }

        var sortedChars = new List<char>(freqMap.Keys);
        sortedChars.Sort((a, b) => freqMap[b].CompareTo(freqMap[a]));

        if (freqMap[sortedChars[0]] > (s.Length + 1) / 2)
        {
            return "";
        }

        var res = new char[s.Length];
        var i = 0;
        foreach (var c in sortedChars)
        {
            for (var j = 0; j < freqMap[c]; j++)
            {
                if (i >= s.Length)
                {
                    i = 1;
                }

                res[i] = c;
                i += 2;
            }
        }

        return new string(res);
    }
}