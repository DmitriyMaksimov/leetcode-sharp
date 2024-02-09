namespace leetcode_sharp;

// 811. Subdomain Visit Count
// https://leetcode.com/problems/subdomain-visit-count
public class S00811
{
    public IList<string> SubdomainVisits(string[] cpdomains)
    {
        var counts = new Dictionary<string, int>();

        foreach (var domain in cpdomains)
        {
            var strings = domain.Split(' ');
            var n = int.Parse(strings[0]);
            var s = strings[1];

            for (var i = 0; i < s.Length; ++i)
            {
                if (s[i] == '.')
                {
                    var d = s[(i + 1)..];
                    counts[d] = counts.GetValueOrDefault(d) + n;
                }
            }

            counts[s] = counts.GetValueOrDefault(s) + n;
        }

        return counts.Select(x => $"{x.Value} {x.Key}").ToList();
    }
}