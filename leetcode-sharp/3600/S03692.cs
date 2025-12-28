namespace leetcode_sharp;

// 3692. Majority Frequency Characters
// https://leetcode.com/problems/majority-frequency-characters
public class S03692
{
    public string MajorityFrequencyGroup(string s)
    {
        var bestGroup = s
            .GroupBy(c => c)
            .GroupBy(g => g.Count())
            .OrderByDescending(g => g.Count())
            .ThenByDescending(g => g.Key)
            .First();

        return new string(bestGroup.Select(g => g.Key).ToArray());
    }
}