namespace leetcode_sharp;

// 2306. Naming a Company
// https://leetcode.com/problems/naming-a-company/
public class S02306
{
    private readonly HashSet<string>[] _groups = new HashSet<string>[26];    // first char => list of ideas' suffix (all characters except the first)
    
    public long DistinctNames(string[] ideas)
    {
        for (var index = 0; index < _groups.Length; index++)
        {
            _groups[index] = [];
        }

        foreach (var idea in ideas)
        {
            var firstChar = idea[0] - 'a';

            _groups[firstChar].Add(idea[1..]);
        }

        var result = 0L;

        for (var i = 0; i < _groups.Length - 1; i++)
        {
            for (var j = i + 1; j < _groups.Length; j++)
            {
                var intersectCount = _groups[i].Intersect(_groups[j]).Count();
                var count1 = _groups[i].Count - intersectCount;
                var count2 = _groups[j].Count - intersectCount;
                result += count1 * count2;
            }
        }

        return result * 2;
    }
}