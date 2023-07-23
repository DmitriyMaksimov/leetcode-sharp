namespace leetcode_sharp;

// 2336. Smallest Number in Infinite Set
// https://leetcode.com/problems/smallest-number-in-infinite-set/
public class S02336
{
    public class SmallestInfiniteSet
    {
        private const int Max = 1000;
        private readonly PriorityQueue<int, int> _set;

        public SmallestInfiniteSet()
        {
            _set = new PriorityQueue<int, int>(Enumerable.Range(1, Max).Select(x => (x, x)));
        }

        public int PopSmallest()
        {
            var smallest = _set.Dequeue();

            // Remove duplicated elements (if any)
            while (_set.TryPeek(out var nextElement, out _))
            {
                if (nextElement != smallest)
                {
                    break;
                }

                _set.Dequeue();
            }
            
            return smallest;
        }

        public void AddBack(int num)
        {
            _set.Enqueue(num, num);
        }
    }
}