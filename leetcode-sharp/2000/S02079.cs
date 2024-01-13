namespace leetcode_sharp;

// 2079. Watering Plants
// https://leetcode.com/problems/watering-plants
public class S02079
{
    public int WateringPlants(int[] plants, int capacity)
    {
        var res = 0;
        var can = capacity;

        for (var i = 0; i < plants.Length; ++i)
        {
            if (can < plants[i])
            {
                res += i * 2;
                can = capacity;
            }

            can -= plants[i];
        }

        return res + plants.Length;
    }
}