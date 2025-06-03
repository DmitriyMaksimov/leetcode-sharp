namespace leetcode_sharp;

// 1298. Maximum Candies You Can Get from Boxes
// https://leetcode.com/problems/maximum-candies-you-can-get-from-boxes
public class S01298
{
    public int MaxCandies(int[] status, int[] candies, int[][] keys, int[][] containedBoxes, int[] initialBoxes)
    {
        var n = status.Length;
        var opened = new bool[n];
        var toBeOpened = new bool[n];

        var queue = new Queue<int>();

        foreach (var v in initialBoxes)
        {
            queue.Enqueue(v);
            toBeOpened[v] = true;
        }

        var result = 0;

        while (queue.Count > 0)
        {
            var cur = queue.Dequeue();
            if (status[cur] == 1 && !opened[cur])
            {
                result += candies[cur];
                opened[cur] = true;

                foreach (var k in keys[cur])
                {
                    if (status[k] == 1 && toBeOpened[k])
                    {
                        continue;
                    }

                    status[k] = 1;
                    if (toBeOpened[k] && !opened[k])
                    {
                        queue.Enqueue(k);
                    }
                }

                foreach (var k in containedBoxes[cur])
                {
                    toBeOpened[k] = true;
                    queue.Enqueue(k);
                }
            }
        }

        return result;
    }
}
