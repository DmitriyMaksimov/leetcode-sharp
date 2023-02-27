namespace leetcode_sharp;

// 118. Pascal's Triangle
// https://leetcode.com/problems/pascals-triangle/
public class S00118
{
    public IList<IList<int>> Generate(int numRows)
    {
        var list = new List<IList<int>> {new List<int> {1}};

        while (--numRows > 0)
        {
            var row = new List<int>();
            var prevRow = list.Last();
            
            for (var i = 0; i < prevRow.Count + 1; i++)
            {
                if (i == 0 || prevRow.Count == 1 || i == prevRow.Count)
                {
                    row.Add(1);
                }
                else
                {
                    row.Add(prevRow[i - 1] + prevRow[i]);
                }
            }

            list.Add(row);
        }
        
        return list;
    }
}