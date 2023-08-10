namespace leetcode_sharp;

// 763. Partition Labels
// https://leetcode.com/problems/partition-labels/
public class S00763
{
    public IList<int> PartitionLabels(string s)
    {
        var map = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            map[s[i]] = i;
        }

        var result = new List<int>();
        var prev = -1;
        var max = 0;

        for (var i = 0; i < s.Length; i++)
        {
            max = Math.Max(max, map[s[i]]);
            if (max == i)
            {
                result.Add(max - prev);
                prev = max;
            }
        }

        return result;
    }
}