namespace leetcode_sharp;

// 1733. Minimum Number of People to Teach
// https://leetcode.com/problems/minimum-number-of-people-to-teach
public class S01733
{
    public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
    {
        var personLanguages = languages
            .Select(l => new HashSet<int>(l))
            .ToArray();

        var dontSpeak = new HashSet<int>();

        foreach (var friendship in friendships)
        {
            var u = friendship[0] - 1;
            var v = friendship[1] - 1;

            if (personLanguages[u].Overlaps(personLanguages[v]))
            {
                continue;
            }

            dontSpeak.Add(u);
            dontSpeak.Add(v);
        }

        var langCount = new Dictionary<int, int>();

        foreach (var lang in dontSpeak.SelectMany(person => personLanguages[person]))
        {
            langCount[lang] = langCount.GetValueOrDefault(lang, 0) + 1;
        }

        if (dontSpeak.Count == 0)
        {
            return 0;
        }

        var maxKnownLang = langCount.Values.DefaultIfEmpty(0).Max();

        return dontSpeak.Count - maxKnownLang;
    }
}