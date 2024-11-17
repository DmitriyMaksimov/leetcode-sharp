namespace leetcode_sharp;

// 900. RLE Iterator
// https://leetcode.com/problems/rle-iterator
public static class S00900
{
    public class RLEIterator
    {
        private readonly int[] _encoding;
        private int _index;

        public RLEIterator(int[] encoding)
        {
            _encoding = encoding;
        }

        public int Next(int n)
        {
            while (_index < _encoding.Length && n > _encoding[_index])
            {
                n -= _encoding[_index];
                _index += 2;
            }

            if (_index >= _encoding.Length)
            {
                return -1;
            }

            _encoding[_index] -= n;

            return _encoding[_index + 1];
        }
    }
}
