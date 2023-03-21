namespace leetcode_sharp;

// 169. Majority Element
// https://leetcode.com/problems/majority-element/
public class S00169
{
    public int MajorityElement(int[] nums)
    {
        var dictionary = new Dictionary<int, int>();
        foreach (var n in nums)
        {
            dictionary[n] = dictionary.GetValueOrDefault(n, 0) + 1;
        }

        return dictionary.MaxBy(x => x.Value).Key;
    }
}