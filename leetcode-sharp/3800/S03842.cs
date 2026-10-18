namespace leetcode_sharp;

// 3842. Toggle Light Bulbs
// https://leetcode.com/problems/toggle-light-bulbs
public class S03842
{
    public IList<int> ToggleLightBulbs(IList<int> bulbs)
    {
        var on = new bool[101];
        
        foreach (var bulb in bulbs)
        {
            on[bulb] = !on[bulb];
        }

        var result = new List<int>();

        for (var i = 0; i < on.Length; i++)
        {
            if (on[i])
            {
                result.Add(i);
            }
        }

        return result;
    }
}