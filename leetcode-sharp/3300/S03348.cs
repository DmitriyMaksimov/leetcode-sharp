namespace leetcode_sharp;

// 3348. Smallest Divisible Digit Product II
// https://leetcode.com/problems/smallest-divisible-digit-product-ii
public class S03348
{
    private readonly int[] _allowedPrimes = [2, 3, 5, 7];

    // Contribution of each digit to prime exponents.
    private readonly int[,] _contrib = new[,]
    {
        { 0, 0, 0, 0 }, // 0
        { 0, 0, 0, 0 }, // 1
        { 1, 0, 0, 0 }, // 2
        { 0, 1, 0, 0 }, // 3
        { 2, 0, 0, 0 }, // 4
        { 0, 0, 1, 0 }, // 5
        { 1, 1, 0, 0 }, // 6
        { 0, 0, 0, 1 }, // 7
        { 3, 0, 0, 0 }, // 8
        { 0, 2, 0, 0 } // 9
    };

    private int _maxE2;
    private int _maxE3;
    private int _maxE5;
    private int _maxE7;

    // dp[e2,e3,e5,e7] = minimum digits needed
    private int[,,,] _dp = null!;

    private void BuildDp(int E2, int E3, int E5, int E7)
    {
        _maxE2 = E2;
        _maxE3 = E3;
        _maxE5 = E5;
        _maxE7 = E7;

        _dp = new int[E2 + 1, E3 + 1, E5 + 1, E7 + 1];

        for (var i = 0; i <= E2; i++)
        {
            for (var j = 0; j <= E3; j++)
            {
                for (var k = 0; k <= E5; k++)
                {
                    for (var l = 0; l <= E7; l++)
                    {
                        _dp[i, j, k, l] = int.MaxValue;
                    }
                }
            }
        }

        _dp[0, 0, 0, 0] = 0;

        var maxSum = E2 + E3 + E5 + E7;

        for (var s = 1; s <= maxSum; s++)
        {
            for (var e2 = 0; e2 <= E2; e2++)
            {
                for (var e3 = 0; e3 <= E3; e3++)
                {
                    for (var e5 = 0; e5 <= E5; e5++)
                    {
                        for (var e7 = 0; e7 <= E7; e7++)
                        {
                            if (e2 + e3 + e5 + e7 != s)
                            {
                                continue;
                            }

                            var best = int.MaxValue;

                            for (var d = 2; d <= 9; d++)
                            {
                                var ne2 = Math.Max(0, e2 - _contrib[d, 0]);
                                var ne3 = Math.Max(0, e3 - _contrib[d, 1]);
                                var ne5 = Math.Max(0, e5 - _contrib[d, 2]);
                                var ne7 = Math.Max(0, e7 - _contrib[d, 3]);

                                if (_dp[ne2, ne3, ne5, ne7] != int.MaxValue)
                                {
                                    best = Math.Min(best, _dp[ne2, ne3, ne5, ne7] + 1);
                                }
                            }

                            _dp[e2, e3, e5, e7] = best;
                        }
                    }
                }
            }
        }
    }

    private int MinDigits(int e2, int e3, int e5, int e7)
    {
        return _dp[
            Math.Min(e2, _maxE2),
            Math.Min(e3, _maxE3),
            Math.Min(e5, _maxE5),
            Math.Min(e7, _maxE7)
        ];
    }

    private void ApplyDigit(int[] freq, int d)
    {
        freq[2] = Math.Max(0, freq[2] - _contrib[d, 0]);
        freq[3] = Math.Max(0, freq[3] - _contrib[d, 1]);
        freq[5] = Math.Max(0, freq[5] - _contrib[d, 2]);
        freq[7] = Math.Max(0, freq[7] - _contrib[d, 3]);
    }

    private bool IsReqMet(int[] freq)
    {
        foreach (var p in _allowedPrimes)
        {
            if (freq[p] > 0)
            {
                return false;
            }
        }

        return true;
    }

    // Smallest suffix of exactly length L satisfying freq.
    private string GreedyFill(int[] freq, int l)
    {
        var res = new char[l];

        for (var pos = 0; pos < l; pos++)
        {
            var slotsAfter = l - pos - 1;

            for (var d = 1; d <= 9; d++)
            {
                var nf = (int[])freq.Clone();
                ApplyDigit(nf, d);

                if (MinDigits(nf[2], nf[3], nf[5], nf[7]) <= slotsAfter)
                {
                    freq = nf;
                    res[pos] = (char)('0' + d);
                    break;
                }
            }
        }

        return new string(res);
    }

    public string SmallestNumber(string num, long t)
    {
        var freqFull = new int[10];

        foreach (var p in _allowedPrimes)
        {
            while (t % p == 0)
            {
                freqFull[p]++;
                t /= p;
            }
        }

        if (t > 1)
        {
            return "-1";
        }

        BuildDp(freqFull[2], freqFull[3], freqFull[5], freqFull[7]);

        var len = num.Length;

        var hasZero = false;
        foreach (var c in num)
        {
            if (c == '0')
            {
                hasZero = true;
                break;
            }
        }

        // Case 1: num itself works
        if (!hasZero)
        {
            var freq = (int[])freqFull.Clone();

            foreach (var c in num)
                ApplyDigit(freq, c - '0');

            if (IsReqMet(freq))
            {
                return num;
            }
        }

        // prefixFreq[i] = remaining requirements before position i
        var prefixFreq = new int[len + 1][];
        prefixFreq[0] = (int[])freqFull.Clone();

        for (var i = 0; i < len; i++)
        {
            prefixFreq[i + 1] = (int[])prefixFreq[i].Clone();

            if (num[i] != '0')
            {
                ApplyDigit(prefixFreq[i + 1], num[i] - '0');
            }
        }

        var limit = hasZero ? num.IndexOf('0') : len - 1;

        var answer = "";

        for (var pos = limit; pos >= 0 && answer.Length == 0; pos--)
        {
            var freqBefore = prefixFreq[pos];
            var origDigit = num[pos] - '0';

            for (var d = origDigit + 1; d <= 9; d++)
            {
                var nf = (int[])freqBefore.Clone();
                ApplyDigit(nf, d);

                var slotsAfter = len - pos - 1;

                if (MinDigits(nf[2], nf[3], nf[5], nf[7]) <= slotsAfter)
                {
                    answer = num.Substring(0, pos)
                             + (char)('0' + d)
                             + GreedyFill(nf, slotsAfter);
                    break;
                }
            }
        }

        if (answer.Length > 0)
        {
            return answer;
        }

        var totalNeeded = MinDigits(
            freqFull[2],
            freqFull[3],
            freqFull[5],
            freqFull[7]);

        var l = Math.Max(len + 1, totalNeeded);

        return GreedyFill((int[])freqFull.Clone(), l);
    }
}