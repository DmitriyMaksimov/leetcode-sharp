﻿namespace leetcode_sharp;

// 2057. Smallest Index With Equal Value
// https://leetcode.com/problems/smallest-index-with-equal-value/
public class S02057
{
    public int SmallestEqual(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (i % 10 == nums[i])
            {
                return i;
            }
        }

        return -1;
    }
}