namespace leetcode_sharp;

// 2315. Count Asterisks
// https://leetcode.com/problems/count-asterisks/
public class S02315
{
    public int CountAsterisks(string s)
    {
        var count = 0;
        var insidePipes = false;

        foreach (var ch in s)
        {
            switch (ch)
            {
                case '|':
                    insidePipes = !insidePipes;
                    break;
                case '*' when !insidePipes:
                    ++count;
                    break;
            }
        }
        
        return count;
    }
}