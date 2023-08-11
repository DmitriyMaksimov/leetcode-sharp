namespace leetcode_sharp;

// 49. Group Anagrams
// https://leetcode.com/problems/group-anagrams/
public class S00049
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        foreach (var word in strs)
        {
            var sortedWord = new string(word.OrderBy(ch => ch).ToArray());

            if (!map.ContainsKey(sortedWord))
            {
                map.Add(sortedWord, new List<string>());
            }

            map[sortedWord].Add(word);
        }

        return new List<IList<string>>(map.Values);
    }
}