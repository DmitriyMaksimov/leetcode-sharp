namespace leetcode_sharp;

// 981. Time Based Key-Value Store
// https://leetcode.com/problems/time-based-key-value-store
public static class S00981
{
    public class TimeMap
    {
        private readonly Dictionary<string, List<(int Timestamp, string Value)>> _map = new();

        public void Set(string key, string value, int timestamp)
        {
            _map.TryAdd(key, []);
            _map[key].Add((timestamp, value));
        }

        public string Get(string key, int timestamp)
        {
            if (!_map.TryGetValue(key, out var values))
            {
                return "";
            }

            var index = values.BinarySearch((timestamp, ""), Comparer<(int, string)>.Create((a, b) => a.Item1.CompareTo(b.Item1)));

            if (index >= 0)
            {
                return values[index].Value;
            }

            index = ~index;

            return index == 0 ? "" : values[index - 1].Value;
        }
    }
}
