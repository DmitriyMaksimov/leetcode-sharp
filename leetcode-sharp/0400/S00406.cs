namespace leetcode_sharp;

// 406. Queue Reconstruction by Height
// https://leetcode.com/problems/queue-reconstruction-by-height
public class S00406
{
    public int[][] ReconstructQueue(int[][] people)
    {
        var result = new List<int[]>(people.Length);
        
        foreach (var p in people.OrderByDescending(x => x[0]).ThenBy(x => x[1]))
        {
            result.Insert(p[1], p);
        }

        return result.ToArray();
    }
}