namespace leetcode_sharp;

// 2150. Find All Lonely Numbers in the Array
// https://leetcode.com/problems/find-all-lonely-numbers-in-the-array
public class S02150
{
    public IList<int> FindLonely(int[] nums)
    {
        Dictionary<int, int> dictionary = [];

        foreach (var n in nums)
        {
            dictionary[n] = dictionary.GetValueOrDefault(n) + 1;
        }

        List<int> result = [];

        foreach (var (key, count) in dictionary)
        {
            if (count == 1 && !dictionary.ContainsKey(key + 1) && !dictionary.ContainsKey(key - 1))
            {
                result.Add(key);
            }
        }

        return result;
    }
}
