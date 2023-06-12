namespace leetcode_sharp;

// 1773. Count Items Matching a Rule
// https://leetcode.com/problems/count-items-matching-a-rule/
public class S01773
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        var ruleIndex = ruleKey switch
        {
            "type" => 0,
            "color" => 1,
            _ => 2
        };

        return items.Count(item => item[ruleIndex] == ruleValue);
    }
}