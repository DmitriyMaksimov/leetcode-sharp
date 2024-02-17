namespace leetcode_sharp;

// 1642. Furthest Building You Can Reach
// https://leetcode.com/problems/furthest-building-you-can-reach
public class S01642
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        var p = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

        int i;

        for (i = 0; i < heights.Length - 1; i++)
        {
            var diff = heights[i + 1] - heights[i];

            if (diff <= 0)
            {
                continue;
            }

            bricks -= diff;
            p.Enqueue(diff, diff);

            if (bricks < 0)
            {
                bricks += p.Dequeue();
                ladders--;
            }

            if (ladders < 0)
            {
                break;
            }
        }

        return i;
    }
}