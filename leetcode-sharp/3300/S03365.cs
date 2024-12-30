namespace leetcode_sharp;

// 3365. Rearrange K Substrings to Form Target String
// https://leetcode.com/problems/rearrange-k-substrings-to-form-target-string
public class S03365
{
    public bool IsPossibleToRearrange(string s, string t, int k)
    {
        Dictionary<string, int> dictionary = [];

        var size = s.Length / k;

        for (var i = 0; i < s.Length; i += size)
        {
            dictionary[s.Substring(i, size)] = dictionary.GetValueOrDefault(s.Substring(i, size)) + 1;
            dictionary[t.Substring(i, size)] = dictionary.GetValueOrDefault(t.Substring(i, size)) - 1;
        }

        return dictionary.Values.All(value => value == 0);
    }
}
