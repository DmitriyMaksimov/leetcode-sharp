namespace leetcode_sharp;

// 1358. Number of Substrings Containing All Three Characters
// https://leetcode.com/problems/number-of-substrings-containing-all-three-characters
public class S01358
{
    public int NumberOfSubstrings(string s)
    {
        int[] counts = [0, 0, 0];
        var result = 0;
        var i = 0;

        foreach (var c in s)
        {
            ++counts[c - 'a'];

            while (counts[0] > 0 && counts[1] > 0 && counts[2] > 0)
            {
                --counts[s[i++] - 'a'];
            }

            result += i;
        }

        return result;
    }
}
