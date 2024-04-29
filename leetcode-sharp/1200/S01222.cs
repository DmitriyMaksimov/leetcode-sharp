namespace leetcode_sharp;

// 1222. Queens That Can Attack the King
// https://leetcode.com/problems/queens-that-can-attack-the-king
public class S01222
{
    public IList<IList<int>> QueensAttacktheKing(int[][] queens, int[] king)
    {
        List<IList<int>> result = [];

        var seen = new bool[8, 8];

        foreach (var queen in queens)
        {
            seen[queen[0], queen[1]] = true;
        }

        int[] dirs = [-1, 0, 1];
        
        foreach (var dx in dirs)
        {
            foreach (var dy in dirs)
            {
                if (dx == 0 && dy == 0)
                {
                    continue;
                }

                var x = king[0];
                var y = king[1];

                while (x + dx >= 0 && x + dx < 8 && y + dy >= 0 && y + dy < 8)
                {
                    x += dx;
                    y += dy;
                    if (seen[x, y])
                    {
                        result.Add([x, y]);
                        break;
                    }
                }
            }
        }

        return result;
    }
}