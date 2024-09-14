namespace leetcode_sharp;

// 609. Find Duplicate File in System
// https://leetcode.com/problems/find-duplicate-file-in-system
public class S00609
{
    public IList<IList<string>> FindDuplicate(string[] paths)
    {
        var n = paths.Length;
        if (n == 0) return [];

        Dictionary<string, HashSet<string>> map = [];
        foreach (var path in paths)
        {
            var strs = path.Split(" ");

            for (var i = 1; i < strs.Length; i++)
            {
                var idx = strs[i].IndexOf("(");
                var content = strs[i][idx..];
                var filename = strs[0] + "/" + strs[i][..idx];
                var filenames = map.GetValueOrDefault(content, []);
                filenames.Add(filename);
                map[content] = filenames;
            }
        }

        var result = new List<IList<string>>();
        result.AddRange(map.Values.Where(hashSet => hashSet.Count > 1).Select(set => new List<string>(set)));

        return result;
    }
}
