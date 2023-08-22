﻿namespace leetcode_sharp;

// 168. Excel Sheet Column Title
// https://leetcode.com/problems/excel-sheet-column-title/
public class S00168
{
    public string ConvertToTitle(int columnNumber)
    {
        var result = "";

        while (columnNumber > 0)
        {
            result = (char)('A' + (columnNumber - 1) % 26) + result;
            columnNumber = (columnNumber - 1) / 26;
        }

        return result;
    }
}