namespace leetcode_sharp;

// 1670. Design Front Middle Back Queue
// https://leetcode.com/problems/design-front-middle-back-queue
public static class S01670
{
    public class FrontMiddleBackQueue
    {
        private readonly LinkedList<int> _a = [];
        private readonly LinkedList<int> _b = [];

        private void MoveFromAtoB()
        {
            if (_a.Count <= _b.Count)
            {
                return;
            }

            _b.AddFirst(_a.Last!.Value);
            _a.RemoveLast();
        }

        private void MoveFormBtoA()
        {
            if (_b.Count <= _a.Count + 1)
            {
                return;
            }

            _a.AddLast(_b.First!.Value);
            _b.RemoveFirst();
        }

        public void PushFront(int val)
        {
            _a.AddFirst(val);
            MoveFromAtoB();
        }

        public void PushMiddle(int val)
        {
            _a.AddLast(val);
            MoveFromAtoB();
        }

        public void PushBack(int val)
        {
            _b.AddLast(val);
            MoveFormBtoA();
        }

        public int PopFront()
        {
            if (_a.Count == 0 && _b.Count == 0)
            {
                return -1;
            }

            int result;

            if (_a.Count == 0)
            {
                result = _b.First!.Value;
                _b.RemoveFirst();
            }
            else
            {
                result = _a.First!.Value;
                _a.RemoveFirst();
                MoveFormBtoA();
            }

            return result;
        }

        public int PopMiddle()
        {
            if (_a.Count == 0 && _b.Count == 0)
            {
                return -1;
            }

            int result;

            if (_a.Count == _b.Count)
            {
                result = _a.Last!.Value;
                _a.RemoveLast();
            }
            else
            {
                result = _b.First!.Value;
                _b.RemoveFirst();
            }

            return result;
        }

        public int PopBack()
        {
            if (_a.Count == 0 && _b.Count == 0)
            {
                return -1;
            }

            var result = _b.Last!.Value;
            _b.RemoveLast();
            MoveFromAtoB();
            return result;
        }
    }
}
