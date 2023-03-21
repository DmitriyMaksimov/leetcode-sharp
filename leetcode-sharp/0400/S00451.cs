namespace leetcode_sharp;

// 451. Sort Characters By Frequency
// https://leetcode.com/problems/sort-characters-by-frequency/
public class S00451
{
    public string FrequencySort(string s)
    {
        var dictionary = new Dictionary<char, int>();
        
        foreach (var ch in s)
        {
            dictionary[ch] = dictionary.GetValueOrDefault(ch) + 1;
        }

        var retVal = "";
        
        foreach (var (key, value) in dictionary.OrderByDescending(x => x.Value))
        {
            retVal += new string(key, value);
        }
        
        return retVal;
    }
}