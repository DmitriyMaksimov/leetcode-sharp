namespace leetcode_sharp;

// 874. Walking Robot Simulation
// https://leetcode.com/problems/walking-robot-simulation
public class S00874
{
    public int RobotSim(int[] commands, int[][] obstacles)
    {
        int[][] direction = [[0, 1], [1, 0], [0, -1], [-1, 0]];
        var x = 0;
        var y = 0;
        var d = 0;
        var maxDistance = 0;

        HashSet<string> obstacleSet = [];
        foreach (var obstacle in obstacles)
        {
            obstacleSet.Add(obstacle[0] + "_" + obstacle[1]);
        }

        foreach (var command in commands)
        {
            switch (command)
            {
                case -1:
                    d = (d + 1) % 4;
                    break;
                case -2:
                    d = (d + 3) % 4;
                    break;
                default:
                {
                    for (var i = 0; i < command; i++)
                    {
                        var nx = x + direction[d][0];
                        var ny = y + direction[d][1];

                        if (obstacleSet.Contains(nx + "_" + ny))
                        {
                            break;
                        }

                        x = nx;
                        y = ny;
                        maxDistance = Math.Max(maxDistance, x * x + y * y);
                    }

                    break;
                }
            }
        }

        return maxDistance;
    }
}
