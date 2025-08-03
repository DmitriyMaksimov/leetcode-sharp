namespace leetcode_sharp;

// 2595. Number of Even and Odd Bits
// https://leetcode.com/problems/number-of-even-and-odd-bits/
public class S02595
{
    public int[] EvenOddBit(int n)
    {
        var even = 0;
        var odd = 0;

        while (n > 0)
        {
            if (n % 2 == 1)
            {
                ++even;
            }

            n /= 2;

            if (n % 2 == 1)
            {
                ++odd;
            }

            n /= 2;
        }

        return [even, odd];
    }
}