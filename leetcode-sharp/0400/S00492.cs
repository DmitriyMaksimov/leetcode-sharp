namespace leetcode_sharp;

// 492. Construct the Rectangle
// https://leetcode.com/problems/construct-the-rectangle/
public class S00492
{
    public int[] ConstructRectangle(int area)
    {
        var w = (int) Math.Sqrt(area);
        while (area % w != 0)
        {
            w--;
        }

        return [area / w, w];
    }
}