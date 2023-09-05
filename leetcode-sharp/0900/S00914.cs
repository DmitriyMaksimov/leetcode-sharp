namespace leetcode_sharp;

// 914. X of a Kind in a Deck of Cards
// https://leetcode.com/problems/x-of-a-kind-in-a-deck-of-cards/
public class S00914
{
    public bool HasGroupsSizeX(int[] deck)
    {
        var dict = new Dictionary<int, int>();
        foreach (var i in deck)
        {
            dict[i] = dict.GetValueOrDefault(i) + 1;
        }

        var min = dict.Values.Min();

        if (min < 2)
        {
            return false;
        }

        for (var i = 2; i <= min; i++)
        {
            var flag = dict.Values.All(j => j % i == 0);

            if (flag)
            {
                return true;
            }
        }

        return false;
    }
}