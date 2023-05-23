namespace leetcode_sharp;

// 703. Kth Largest Element in a Stream
// https://leetcode.com/problems/kth-largest-element-in-a-stream/
public class S00703
{
    public class KthLargest
    {
        private readonly int _k;
        private readonly List<int> _values = new();
        
        public KthLargest(int k, int[] nums)
        {
            _k = k;
            foreach (var num in nums)
            {
                addValue(num);
            }
        }

        public int Add(int val)
        {
            addValue(val);

            return _values[^_k];
        }

        private void addValue(int val)
        {
            var index = _values.BinarySearch(val);
            _values.Insert((index >= 0) ? index : ~index, val);
        }
    }
}