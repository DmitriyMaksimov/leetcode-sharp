namespace leetcode_sharp;

// 622. Design Circular Queue
// https://leetcode.com/problems/design-circular-queue
public class S00622
{
    public class MyCircularQueue
    {
        private readonly int[] _buffer;
        private int _front = 0;
        private int _rear = -1;
        private int _len = 0;

        public MyCircularQueue(int k)
        {
            _buffer = new int[k];
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            _rear = (_rear + 1) % _buffer.Length;
            _buffer[_rear] = value;
            _len++;

            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }

            _front = (_front + 1) % _buffer.Length;
            _len--;

            return true;
        }

        public int Front()
        {
            return IsEmpty() ? -1 : _buffer[_front];
        }

        public int Rear()
        {
            return IsEmpty() ? -1 : _buffer[_rear];
        }

        public bool IsEmpty()
        {
            return _len == 0;
        }

        public bool IsFull()
        {
            return _len == _buffer.Length;
        }
    }
}
