namespace leetcode_sharp;

// 3442. Maximum Difference Between Even and Odd Frequency I
// https://leetcode.com/problems/maximum-difference-between-even-and-odd-frequency-i
public class S03442
{
    public int MaxDifference(string s)
    {
        Dictionary<char, int> dictionary = [];
        foreach (var c in s)
        {
            dictionary[c] = dictionary.GetValueOrDefault(c) + 1;
        }

        return dictionary.Values.Where(x => x % 2 == 1).Max() - dictionary.Values.Where(x => x % 2 == 0).Min();
    }
}
