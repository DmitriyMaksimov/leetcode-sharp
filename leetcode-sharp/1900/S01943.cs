namespace leetcode_sharp;

// 1943. Describe the Painting
// https://leetcode.com/problems/describe-the-painting
public class S01943
{
    public IList<IList<long>> SplitPainting(int[][] segments)
    {
        var dictionary = new SortedDictionary<int, long>();

        foreach (var segment in segments)
        {
            dictionary.TryAdd(segment[0], 0);
            dictionary.TryAdd(segment[1], 0);

            dictionary[segment[0]] += segment[2];
            dictionary[segment[1]] -= segment[2];
        }

        var result = new List<IList<long>>();
        var prev = 0;
        var sum = 0L;

        foreach (var (key, value) in dictionary)
        {
            if (sum != 0)
            {
                result.Add(new List<long> { prev, key, sum });
            }

            sum += value;
            prev = key;
        }

        return result;
    }
}
