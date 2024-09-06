namespace leetcode_sharp;

// 3274. Check if Two Chessboard Squares Have the Same Color
// https://leetcode.com/problems/check-if-two-chessboard-squares-have-the-same-color
public class S03274
{
    public bool CheckTwoChessboards(string coordinate1, string coordinate2)
    {
        return GetColor(coordinate1) == GetColor(coordinate2);
    }

    private static bool GetColor(string coordinate)
    {
        return (coordinate[0] - 'a' + coordinate[1] - '1') % 2 == 0;
    }
}
