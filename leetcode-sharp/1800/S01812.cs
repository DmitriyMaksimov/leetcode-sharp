namespace leetcode_sharp;

// 1812. Determine Color of a Chessboard Square
// https://leetcode.com/problems/determine-color-of-a-chessboard-square/
public class S01812
{
    public bool SquareIsWhite(string coordinates)
    {
        var n = coordinates[0] - 'a';
        var m = coordinates[1] - '0';
        
        return (n + m) % 2 == 0;
    }
}