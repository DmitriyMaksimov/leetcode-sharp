namespace leetcode_sharp;

// 1405. Longest Happy String
// https://leetcode.com/problems/longest-happy-string
public class S01405
{
    public string LongestDiverseString(int a, int b, int c)
    {
        var total = a + b + c;
        var currA = 0;
        var currB = 0;
        var currC = 0;
        var result = "";

        while (total-- > 0)
        {
            if ((a >= b && a >= c && currA != 2) || (a > 0 && (currB == 2 || currC == 2)))
            {
                result += 'a';
                a--;
                currA++;
                currB = 0;
                currC = 0;
            }
            else if ((b >= a && b >= c && currB != 2) || (b > 0 && (currA == 2 || currC == 2)))
            {
                result += 'b';
                b--;
                currB++;
                currA = 0;
                currC = 0;
            }
            else if ((c >= a && c >= b && currC != 2) || (c > 0 && (currA == 2 || currB == 2)))
            {
                result += 'c';
                c--;
                currC++;
                currA = 0;
                currB = 0;
            }
        }

        return result;
    }
}
