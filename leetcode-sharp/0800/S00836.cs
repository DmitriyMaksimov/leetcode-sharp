namespace leetcode_sharp;

// 836. Rectangle Overlap
// https://leetcode.com/problems/rectangle-overlap/
public class S00836
{
    public bool IsRectangleOverlap(int[] rec1, int[] rec2)
    {
        return rec1[0] < rec2[2] && rec1[1] < rec2[3] && rec2[0] < rec1[2] && rec2[1] < rec1[3];
    }
}