namespace leetcode_sharp;

// 2211. Count Collisions on a Road
// https://leetcode.com/problems/count-collisions-on-a-road
public class S02211
{
    public int CountCollisions(string directions)
    {
        var left = 0;
        var right = directions.Length - 1;

        while (left < directions.Length && directions[left] == 'L')
        {
            left++;
        }

        while (right >= 0 && directions[right] == 'R')
        {
            right--;
        }

        return directions.Skip(left).Take(right - left + 1).Count(x => x != 'S');
    }
}