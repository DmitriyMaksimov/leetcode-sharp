namespace leetcode_sharp;

// 284. Peeking Iterator
// https://leetcode.com/problems/peeking-iterator
public static class S00284
{
    public class PeekingIterator
    {
        private readonly IEnumerator<int> _iterator;
        private bool _hasNext;

        public PeekingIterator(IEnumerator<int> iterator)
        {
            _iterator = iterator;
            _hasNext = true;
        }

        public int Peek()
        {
            return _iterator.Current;
        }

        public int Next()
        {
            var n = _iterator.Current;
            _hasNext = _iterator.MoveNext();
            return n;
        }

        public bool HasNext()
        {
            return _hasNext;
        }
    }
}
