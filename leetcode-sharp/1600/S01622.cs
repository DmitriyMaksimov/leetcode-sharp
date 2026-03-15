namespace leetcode_sharp;

// 1622. Fancy Sequence
// https://leetcode.com/problems/fancy-sequence
public class S01622
{
    public class Fancy
    {
        private const int Mod = 1_000_000_007;
        private readonly List<long> _seq = [];
        private long _increment;
        private long _mult = 1;

        public void Append(int val)
        {
            _seq.Add((Mod + val - _increment) % Mod * ModPow(_mult, Mod - 2) % Mod);
        }

        public void AddAll(int inc)
        {
            _increment = (_increment + inc % Mod) % Mod;
        }

        public void MultAll(int m)
        {
            _mult = _mult * m % Mod % Mod;
            _increment = _increment * m % Mod % Mod;
        }

        public int GetIndex(int idx)
        {
            if (idx >= _seq.Count)
            {
                return -1;
            }

            return (int)((_seq[idx] * _mult % Mod + _increment) % Mod);
        }

        private static long ModPow(long x, int y)
        {
            var total = 1L;
            var p = x;

            for (; y != 0; y >>= 1)
            {
                if ((y & 1) != 0)
                {
                    total = total * p % Mod;
                }

                p = p * p % Mod;
            }

            return total;
        }
    }
}