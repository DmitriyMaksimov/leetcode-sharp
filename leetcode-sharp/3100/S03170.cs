namespace leetcode_sharp;

// 3170. Lexicographically Minimum String After Removing Stars
// https://leetcode.com/problems/lexicographically-minimum-string-after-removing-stars
public class S03170
{
    public string ClearStars(string s)
    {
        const int maxLaters = 26;

        var n = s.Length;
        var removed = new bool[n];
        var buckets = new List<List<int>>();
        for (var i = 0; i < maxLaters; i++)
        {
            buckets.Add([]);
        }

        for (var i = 0; i < n; i++)
        {
            if (s[i] == '*')
            {
                removed[i] = true;

                var bucket = buckets.FirstOrDefault(b => b.Count > 0);
                if (bucket != null)
                {
                    var lastIndex = bucket[^1];
                    removed[lastIndex] = true;
                    bucket.RemoveAt(bucket.Count - 1);
                }
            }
            else
            {
                buckets[s[i] - 'a'].Add(i);
            }
        }

        return new string(s.Where((_, i) => !removed[i]).ToArray());
    }
}
