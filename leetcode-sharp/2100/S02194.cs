namespace leetcode_sharp;

// 2194. Cells in a Range on an Excel Sheet
// https://leetcode.com/problems/cells-in-a-range-on-an-excel-sheet/
public class S02194
{
    public IList<string> CellsInRange(string s)
    {
        var fromCol = s[0];
        var fromRow = s[1];
        var toCol = s[3];
        var toRow = s[4];
        var result = new List<string>();

        for (var col = fromCol; col <= toCol; col++)
        {
            for (var row = fromRow; row <= toRow; ++row)
            {
                result.Add($"{col}{row}");
            }            
        }
        
        return result;
    }
}