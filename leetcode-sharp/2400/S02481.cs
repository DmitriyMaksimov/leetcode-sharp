﻿namespace leetcode_sharp;

// 2481. Minimum Cuts to Divide a Circle
// https://leetcode.com/problems/minimum-cuts-to-divide-a-circle
public class S02481
{
    public int NumberOfCuts(int n)
    {
        if (n == 1)
        {
            return 0;
        }

        return n % 2 == 0 ? n / 2 : n;
    }
}