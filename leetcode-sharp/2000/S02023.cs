namespace leetcode_sharp;

// 2023. Number of Pairs of Strings With Concatenation Equal to Target
// https://leetcode.com/problems/number-of-pairs-of-strings-with-concatenation-equal-to-target
public class S02023
{
    public int NumOfPairs(string[] nums, string target)
    {
        Dictionary<string, int> map = [];
        var numOfPairs = 0;

        foreach (var n in nums)
        {
            if (target.StartsWith(n))
            {
                var sub = target.Substring(n.Length);
                if (map.TryGetValue(sub, out var value))
                {
                    numOfPairs += value;
                }
            }

            if (target.EndsWith(n))
            {
                var sub = target.Substring(0, target.Length - n.Length);
                if (map.TryGetValue(sub, out var value))
                {
                    numOfPairs += value;
                }
            }

            map[n] = map.GetValueOrDefault(n) + 1;
        }

        return numOfPairs;
    }
}