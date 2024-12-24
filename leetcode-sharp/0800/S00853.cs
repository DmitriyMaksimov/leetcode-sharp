namespace leetcode_sharp;

// 853. Car Fleet
// https://leetcode.com/problems/car-fleet
public class S00853
{
    public int CarFleet(int target, int[] position, int[] speed)
    {
        var result = 0;
        var timeArr = new double[target];

        for (var i = 0; i < position.Length; i++)
        {
            timeArr[position[i]] = (double)(target - position[i]) / speed[i];
        }

        var prev = 0.0;

        for (var i = target - 1; i >= 0; i--)
        {
            var cur = timeArr[i];
            if (cur > prev)
            {
                prev = cur;
                result++;
            }
        }

        return result;
    }
}
