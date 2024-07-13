namespace leetcode_sharp;

// 2751. Robot Collisions
// https://leetcode.com/problems/robot-collisions
public class S02751
{
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
    {
        var indices = Enumerable.Range(0, positions.Length).ToArray();

        Array.Sort(indices, (x, y) => positions[x].CompareTo(positions[y]));

        var stack = new Stack<int>();

        foreach (var x in indices)
        {
            if (directions[x] == 'R')
            {
                stack.Push(x);
                continue;
            }

            while (stack.Count > 0)
            {
                var y = stack.Peek();

                if (healths[x] == healths[y])
                {
                    healths[x] = 0;
                    healths[y] = 0;
                    stack.Pop();
                    break;
                }

                if (healths[x] > healths[y])
                {
                    healths[x]--;
                    healths[y] = 0;
                    stack.Pop();
                }
                else
                {
                    healths[x] = 0;
                    healths[y]--;
                    break;
                }
            }
        }

        return healths.Where(health => health != 0).ToList();
    }
}