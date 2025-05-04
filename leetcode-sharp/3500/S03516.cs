namespace leetcode_sharp;

// 3516. Find Closest Person
// https://leetcode.com/problems/find-closest-person
public class S03516
{
    public int FindClosest(int x, int y, int z)
    {
        return (Math.Abs(z - x) - Math.Abs(z - y)) switch
        {
            0 => 0,
            < 0 => 1,
            _ => 2
        };
    }
}
