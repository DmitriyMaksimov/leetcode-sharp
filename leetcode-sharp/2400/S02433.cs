﻿namespace leetcode_sharp;

// 2433. Find The Original Array of Prefix Xor
// https://leetcode.com/problems/find-the-original-array-of-prefix-xor
public class S02433
{
    public int[] FindArray(int[] pref)
    {
        var result = new int[pref.Length];
        
        result[0] = pref[0];
        
        for (var i = 1; i < pref.Length; i++)
        {
            result[i] = pref[i] ^ pref[i - 1];
        }

        return result;
    }
}