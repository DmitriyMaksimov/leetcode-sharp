namespace leetcode_sharp;

// 641. Design Circular Deque
// https://leetcode.com/problems/design-circular-deque
public class S00641
{
    public class MyCircularDeque
    {
        private readonly List<int> _buffer;
        private readonly int _capacity;
        private int _count;
        private int _front;
        private int _rear;

        public MyCircularDeque(int k)
        {
            _buffer = Enumerable.Repeat(0, k).ToList();
            _count = 0;
            _capacity = k;
            _front = k - 1;
            _rear = 0;
        }

        public bool InsertFront(int value)
        {
            if (_count == _capacity)
            {
                return false;
            }

            _buffer[_front] = value;
            _front = (_front - 1 + _capacity) % _capacity;
            ++_count;

            return true;
        }

        public bool InsertLast(int value)
        {
            if (_count == _capacity)
            {
                return false;
            }

            _buffer[_rear] = value;
            _rear = (_rear + 1) % _capacity;
            ++_count;

            return true;
        }

        public bool DeleteFront()
        {
            if (_count == 0)
            {
                return false;
            }

            _front = (_front + 1) % _capacity;
            --_count;

            return true;
        }

        public bool DeleteLast()
        {
            if (_count == 0)
            {
                return false;
            }

            _rear = (_rear - 1 + _capacity) % _capacity;
            --_count;

            return true;
        }

        public int GetFront()
        {
            if (_count == 0)
            {
                return -1;
            }

            return _buffer[(_front + 1) % _capacity];
        }

        public int GetRear()
        {
            if (_count == 0)
            {
                return -1;
            }

            return _buffer[(_rear - 1 + _capacity) % _capacity];
        }

        public bool IsEmpty()
        {
            return _count == 0;
        }

        public bool IsFull()
        {
            return _count == _capacity;
        }
    }
}
