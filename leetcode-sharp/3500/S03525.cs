namespace leetcode_sharp;

// 3525. Find X Value of Array II
// https://leetcode.com/problems/find-x-value-of-array-ii
public class S03525
{
    private sealed class Node(int k)
    {
        public int[] RemainderCounts { get; } = new int[k];
        public int ProductRemainder { get; set; } = 1;
    }

    private sealed class SegmentTree
    {
        private readonly int _modulus;
        private readonly int _size;
        private readonly Node[] _tree;

        public SegmentTree(int[] numbers, int k)
        {
            _modulus = k;

            _size = 1;
            while (_size < numbers.Length)
            {
                _size *= 2;
            }

            _tree = new Node[2 * _size];

            for (var i = 0; i < _tree.Length; i++)
            {
                _tree[i] = new Node(k);
            }

            for (var i = 0; i < numbers.Length; i++)
            {
                var remainder = numbers[i] % k;

                _tree[_size + i].RemainderCounts[remainder] = 1;
                _tree[_size + i].ProductRemainder = remainder;
            }

            for (var i = _size - 1; i > 0; i--)
            {
                _tree[i] = Merge(_tree[2 * i], _tree[2 * i + 1]);
            }
        }

        public void Update(int index, int value)
        {
            var position = _size + index;
            var remainder = value % _modulus;

            var node = _tree[position];

            Array.Clear(node.RemainderCounts);
            node.RemainderCounts[remainder] = 1;
            node.ProductRemainder = remainder;

            for (position /= 2; position > 0; position /= 2)
            {
                _tree[position] = Merge(
                    _tree[2 * position],
                    _tree[2 * position + 1]
                );
            }
        }

        public Node Query(int left, int right)
        {
            var leftResult = new Node(_modulus);
            var rightResult = new Node(_modulus);

            left += _size;
            right += _size;

            while (left < right)
            {
                if ((left & 1) != 0)
                {
                    leftResult = Merge(leftResult, _tree[left]);
                    left++;
                }

                if ((right & 1) != 0)
                {
                    right--;
                    rightResult = Merge(_tree[right], rightResult);
                }

                left /= 2;
                right /= 2;
            }

            return Merge(leftResult, rightResult);
        }

        private Node Merge(Node left, Node right)
        {
            var result = new Node(_modulus);

            // Subarrays entirely inside the left segment.
            for (var remainder = 0; remainder < _modulus; remainder++)
            {
                result.RemainderCounts[remainder] =
                    left.RemainderCounts[remainder];
            }

            for (var rightRemainder = 0; rightRemainder < _modulus; rightRemainder++)
            {
                var count = right.RemainderCounts[rightRemainder];

                if (count == 0)
                {
                    continue;
                }

                var combinedRemainder = left.ProductRemainder * rightRemainder % _modulus;

                result.RemainderCounts[combinedRemainder] += count;
            }

            result.ProductRemainder = left.ProductRemainder * right.ProductRemainder % _modulus;

            return result;
        }
    }

    public int[] ResultArray(int[] nums, int k, int[][] queries)
    {
        var segmentTree = new SegmentTree(nums, k);
        var result = new int[queries.Length];

        for (var i = 0; i < queries.Length; i++)
        {
            var query = queries[i];

            var index = query[0];
            var value = query[1];
            var start = query[2];
            var targetRemainder = query[3];

            segmentTree.Update(index, value);

            var suffix = segmentTree.Query(start, nums.Length);

            result[i] = suffix.RemainderCounts[targetRemainder];
        }

        return result;
    }
}