namespace leetcode_sharp;

// 1432. Max Difference You Can Get From Changing an Integer
// https://leetcode.com/problems/max-difference-you-can-get-from-changing-an-integer
public class S01432
{
    public int MaxDiff(int num)
    {
        var a = num.ToString().ToCharArray();
        var b = (char[])a.Clone();
        var x = a[0]; 
        var y = '\0';
    
        for (var i = 0; i < a.Length; ++i)
        {
            if (a[i] == x)
            {
                a[i] = '9';
                b[i] = '1';
            }
            else if ((x == '1' && a[i] > '0') || (x == '9' && a[i] < '9'))
            {
                if (y == '\0')
                {
                    y = a[i];
                }
    
                if (y == a[i])
                {
                    if (x == '1')
                    {
                        b[i] = '0';
                    }
                    else
                    {
                        a[i] = '9';
                    }
                }
            }
        }
    
        var max = int.Parse(new string(a));
        var min = int.Parse(new string(b));
        return max - min;
    }
}