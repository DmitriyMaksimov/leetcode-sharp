namespace leetcode_sharp;

// 2349. Design a Number Container System
// https://leetcode.com/problems/design-a-number-container-system
public static class S02349
{
    public class NumberContainers
    {
        private readonly Dictionary<int, SortedSet<int>> _res = new();
        private readonly Dictionary<int, int> _indexVal = new();

        public void Change(int index, int number)
        {
            if (_indexVal.TryGetValue(index, out var prevNum))
            {
                if (prevNum == number)
                {
                    return;
                }

                _res[prevNum].Remove(index);
                if (_res[prevNum].Count == 0)
                {
                    _res.Remove(prevNum);
                }
            }

            _res.TryAdd(number, []);

            _res[number].Add(index);
            _indexVal[index] = number;
        }

        public int Find(int number)
        {
            return _res.TryGetValue(number, out var set) && set.Count > 0 ? set.Min : -1;
        }
    }
}
