namespace leetcode_sharp;

// 2251. Number of Flowers in Full Bloom
// https://leetcode.com/problems/number-of-flowers-in-full-bloom
public class S02251
{
    public int[] FullBloomFlowers(int[][] flowers, int[] people)
    {
        var n = people.Length;
        var result = new List<int>(n);
        var events = new Dictionary<int, int>();

        foreach (var flower in flowers)
        {
            events[flower[0]] = events.GetValueOrDefault(flower[0]) + 1;
            events[flower[1] + 1] = events.GetValueOrDefault(flower[1] + 1) - 1;
        }

        var keys = events.Keys.Order().ToList();
        var sum = 0;

        foreach (var key in keys)
        {
            events[key] += sum;
            sum = events[key];
        }

        foreach (var person in people)
        {
            var left = 0;
            var right = keys.Count - 1;
            var index = -1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (keys[mid] <= person)
                {
                    index = keys[mid];
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            result.Add(index == -1 ? 0 : events[index]);
        }

        return result.ToArray();
    }
}