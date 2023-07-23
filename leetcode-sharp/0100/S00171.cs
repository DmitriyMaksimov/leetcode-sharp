namespace leetcode_sharp;

// 171. Excel Sheet Column Number
// https://leetcode.com/problems/excel-sheet-column-number/
public class S00171
{
    public int TitleToNumber(string columnTitle)
    {
        var retVal = 0;

        foreach (var ch in columnTitle)
        {
            retVal = retVal * 26 + ch - 'A' + 1;
        }
        
        return retVal;
    }
}