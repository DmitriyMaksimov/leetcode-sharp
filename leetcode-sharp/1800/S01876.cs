﻿namespace leetcode_sharp;

// 1876. Substrings of Size Three with Distinct Characters
// https://leetcode.com/problems/substrings-of-size-three-with-distinct-characters/
public class S01876
{
    public int CountGoodSubstrings(string s)
    {
        var count = 0;

        for (var i = 0; i < s.Length - 2; i++)
        {
            if (s[i] != s[i + 1] && s[i + 1] != s[i + 2] && s[i] != s[i + 2])
            {
                ++count;
            }
        }

        return count;
    }
}