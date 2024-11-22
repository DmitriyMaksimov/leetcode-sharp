namespace leetcode_sharp;

// 677. Map Sum Pairs
// https://leetcode.com/problems/map-sum-pairs
public sealed class S00677
{
    public class MapSum
    {
        private readonly SortedDictionary<string, int> map = [];

        public MapSum()
        {
        }

        public void Insert(string key, int val)
        {
            map[key] = val;
        }

        public int Sum(string prefix)
        {
            var sum = 0;
            foreach (var entry in map)
            {
                if (entry.Key.StartsWith(prefix))
                {
                    sum += entry.Value;
                }
                else if (string.CompareOrdinal(entry.Key, prefix) > 0)
                {
                    break;
                }
            }

            return sum;
        }
    }
}
