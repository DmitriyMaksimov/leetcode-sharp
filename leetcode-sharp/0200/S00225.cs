namespace leetcode_sharp;

public static class S00225
{
    public class MyStack
    {
        private readonly Queue<int> _queue = new();

        public void Push(int x)
        {
            _queue.Enqueue(x);
            for (var i = 0; i < _queue.Count - 1; i++)
            {
                _queue.Enqueue(_queue.Dequeue());
            }
        }

        public int Pop()
        {
            return _queue.Dequeue();
        }

        public int Top()
        {
            return _queue.Peek();
        }

        public bool Empty()
        {
            return !_queue.Any();
        }
    }
}