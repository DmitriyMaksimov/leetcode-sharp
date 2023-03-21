namespace leetcode_sharp;

// 6. Zigzag Conversion
// https://leetcode.com/problems/zigzag-conversion/
public class S00006
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1)
        {
            return s;
        }
        
        var rows = new string[numRows];
        var currentRow = 0;
        var direction = 1;
        
        foreach (var ch in s)
        {
            rows[currentRow] += ch;
            currentRow += direction;
            if (currentRow == numRows || currentRow == -1)
            {
                direction = -direction;
                currentRow += direction * 2;
            }
        }
        
        return string.Join("", rows);
    }
}