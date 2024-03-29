﻿namespace leetcode_sharp;

// 2839. Check if Strings Can be Made Equal With Operations I
// https://leetcode.com/problems/check-if-strings-can-be-made-equal-with-operations-i
public class S02839
{
    public bool CanBeEqual(string s1, string s2)
    {
        var zeroAndTwo = (s1[0] == s2[0] && s1[2] == s2[2]) || (s1[2] == s2[0] && s1[0] == s2[2]);
        var oneAndThree = (s1[1] == s2[1] && s1[3] == s2[3]) || (s1[3] == s2[1] && s1[1] == s2[3]);
        
        return zeroAndTwo && oneAndThree;
    }
}