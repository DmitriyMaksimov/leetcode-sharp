namespace leetcode_sharp;

// 3013. Divide an Array Into Subarrays With Minimum Cost II
// https://leetcode.com/problems/divide-an-array-into-subarrays-with-minimum-cost-ii
public class S03013
{
    private class Heap(Comparison<int> cmp)
    {
        private readonly List<int> _data = new();

        public int Count => _data.Count;

        public int Peek() => _data[0];

        public void Push(int x)
        {
            _data.Add(x);
            SiftUp(_data.Count - 1);
        }

        public int Pop()
        {
            var root = _data[0];
            var last = _data[^1];
            _data.RemoveAt(_data.Count - 1);
            if (_data.Count > 0)
            {
                _data[0] = last;
                SiftDown(0);
            }

            return root;
        }

        private void SiftUp(int i)
        {
            while (i > 0)
            {
                var p = (i - 1) / 2;
                if (cmp(_data[i], _data[p]) >= 0)
                {
                    break;
                }

                (_data[i], _data[p]) = (_data[p], _data[i]);
                i = p;
            }
        }

        private void SiftDown(int i)
        {
            var n = _data.Count;
            while (true)
            {
                int l = i * 2 + 1, r = l + 1, best = i;
                if (l < n && cmp(_data[l], _data[best]) < 0)
                {
                    best = l;
                }

                if (r < n && cmp(_data[r], _data[best]) < 0)
                {
                    best = r;
                }

                if (best == i)
                {
                    break;
                }

                (_data[i], _data[best]) = (_data[best], _data[i]);
                i = best;
            }
        }
    }

    public long MinimumCost(int[] nums, int k, int dist)
    {
        var n = nums.Length;
        var windowSum = 0L;
        var result = long.MaxValue;

        var usingHeap = new Heap((a, b) =>
        {
            var cmp = nums[b].CompareTo(nums[a]);
            return cmp != 0 ? cmp : b.CompareTo(a);
        });

        var waitingHeap = new Heap((a, b) =>
        {
            var cmp = nums[a].CompareTo(nums[b]);
            return cmp != 0 ? cmp : a.CompareTo(b);
        });

        var delayed = new Dictionary<int, int>();
        var inUsing = new HashSet<int>();

        for (var i = 1; i <= dist + 1; i++)
        {
            usingHeap.Push(i);
            inUsing.Add(i);
            windowSum += nums[i];
        }

        while (usingHeap.Count > k - 1)
        {
            Clean(usingHeap, delayed);
            var x = usingHeap.Pop();
            inUsing.Remove(x);
            windowSum -= nums[x];
            waitingHeap.Push(x);
        }

        result = Math.Min(result, windowSum);

        for (var i = 1; i + dist + 1 < n; i++)
        {
            var incoming = i + dist + 1;
            waitingHeap.Push(incoming);

            if (inUsing.Remove(i))
            {
                MarkDelayed(i, delayed);
                windowSum -= nums[i];

                Clean(usingHeap, delayed);
                Clean(waitingHeap, delayed);

                var x = waitingHeap.Pop();
                usingHeap.Push(x);
                inUsing.Add(x);
                windowSum += nums[x];
            }
            else
            {
                MarkDelayed(i, delayed);

                Clean(usingHeap, delayed);
                Clean(waitingHeap, delayed);

                if (waitingHeap.Count > 0 && usingHeap.Count > 0 && nums[waitingHeap.Peek()] < nums[usingHeap.Peek()])
                {
                    var big = usingHeap.Pop();
                    inUsing.Remove(big);
                    windowSum -= nums[big];
                    waitingHeap.Push(big);

                    var small = waitingHeap.Pop();
                    usingHeap.Push(small);
                    inUsing.Add(small);
                    windowSum += nums[small];
                }
            }

            result = Math.Min(result, windowSum);
        }

        return result + nums[0];
    }

    private static void Clean(Heap h, Dictionary<int, int> delayed)
    {
        while (h.Count > 0 && delayed.TryGetValue(h.Peek(), out var c))
        {
            if (c == 1)
            {
                delayed.Remove(h.Peek());
            }
            else
            {
                delayed[h.Peek()] = c - 1;
            }

            h.Pop();
        }
    }

    private static void MarkDelayed(int x, Dictionary<int, int> delayed)
    {
        delayed[x] = delayed.GetValueOrDefault(x) + 1;
    }
}