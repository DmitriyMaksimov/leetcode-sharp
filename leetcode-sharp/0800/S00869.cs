namespace leetcode_sharp;

// 869. Reordered Power of 2
// https://leetcode.com/problems/reordered-power-of-2
public class S00869
{
    public bool ReorderedPowerOf2(int n)
    {
        var s = new string(n.ToString().ToCharArray().Order().ToArray());

        List<string> powersOf2 = [];

        var power = 1;

        for (var i = 0; i <= 30; i++)
        {
            powersOf2.Add(new string(power.ToString().ToCharArray().Order().ToArray()));
            power <<= 1;
        }

        return powersOf2.Any(x => x == s);
    }
}
