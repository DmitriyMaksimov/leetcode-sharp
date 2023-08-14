namespace leetcode_sharp;

// 1268. Search Suggestions System
// https://leetcode.com/problems/search-suggestions-system/
public class S01268
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        var result = new List<IList<string>>();

        for (var i = 1; i <= searchWord.Length; i++)
        {
            var curSearchSubstring = searchWord[..i];
            result.Add(
                products
                    .Where(p => (p.Length > i ? p[..i] : p) == curSearchSubstring)
                    .OrderBy(p => p)
                    .Take(3)
                    .ToList());
        }

        return result;
    }
}