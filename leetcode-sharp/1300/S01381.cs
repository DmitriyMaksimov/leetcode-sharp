namespace leetcode_sharp;

// 1381. Design a Stack With Increment Operation
// https://leetcode.com/problems/design-a-stack-with-increment-operation
public class S01381
{
    public class CustomStack
    {
        private readonly int _maxSize;
        private readonly int[] _stack;
        private int _numberOfElements = 0;

        public CustomStack(int maxSize)
        {
            _maxSize = maxSize;
            _stack = new int[maxSize];
        }

        public void Push(int x)
        {
            if (_numberOfElements < _maxSize)
            {
                _stack[_numberOfElements++] = x;
            }
        }

        public int Pop()
        {
            return _numberOfElements == 0 ? -1 : _stack[--_numberOfElements];
        }

        public void Increment(int k, int val)
        {
            var n = Math.Min(_numberOfElements, k);
            for (var i = 0; i < n; i++)
            {
                _stack[i] += val;
            }
        }
    }
}