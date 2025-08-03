namespace leetcode_sharp;

// 2423. Remove Letter To Equalize Frequency
// https://leetcode.com/problems/remove-letter-to-equalize-frequency/
public class S02423
{
    public bool EqualFrequency(string word)
    {
        var arr = new int[26];
        foreach (var c in word)
        {
            arr[c - 'a']++;
        }

        var freq = new Dictionary<int, List<char>>();
        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0)
            {
                continue;
            }

            var letter = (char) (i + 'a');
            if (freq.TryGetValue(arr[i], out var list))
            {
                list.Add(letter);
            }
            else
            {
                freq[arr[i]] = [letter];
            }
        }

        if (freq.Count > 2)
        {
            return false;
        }

        var min = freq.Keys.Min();
        var max = freq.Keys.Max();

        if (freq.Count == 1 && freq[min].Count == 1)
        {
            return true;
        }

        if (min == 1 && freq[min].Count == 1)
        {
            return true;
        }

        if (min == 1 && max == 1)
        {
            return true;
        }

        if (max - min == 1 && freq[max].Count == 1)
        {
            return true;
        }

        return false;
    }
}