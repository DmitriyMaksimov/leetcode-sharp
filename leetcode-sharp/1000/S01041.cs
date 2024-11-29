namespace leetcode_sharp;

// 1041. Robot Bounded In Circle
// https://leetcode.com/problems/robot-bounded-in-circle
public class S01041
{
    public bool IsRobotBounded(string instructions)
    {
        int[] direction = [0, 1];
        var x = 0;
        var y = 0;

        foreach (var instruction in instructions)
        {
            if (instruction == 'G')
            {
                x += direction[0];
                y += direction[1];
            }
            else if (instruction == 'L')
            {
                direction = [-direction[1], direction[0]];
            }
            else
            {
                direction = [direction[1], -direction[0]];
            }
        }

        return (x == 0 && y == 0) || !(direction[0] == 0 && direction[1] == 1);
    }
}
