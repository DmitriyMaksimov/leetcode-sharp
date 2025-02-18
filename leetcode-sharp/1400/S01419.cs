namespace leetcode_sharp;

// 1419. Minimum Number of Frogs Croaking
// https://leetcode.com/problems/minimum-number-of-frogs-croaking
public class S01419
{
    public int MinNumberOfFrogs(string croakOfFrogs)
    {
        var croak = new int[5];

        foreach (var c in croakOfFrogs)
        {
            switch (c)
            {
                case 'c':
                {
                    croak[0]++;
                    if (croak[4] != 0)
                    {
                        croak[4]--;
                    }

                    break;
                }
                case 'r' when croak[0] <= 0:
                    return -1;
                case 'r':
                    croak[0]--;
                    croak[1]++;
                    break;
                case 'o' when croak[1] <= 0:
                    return -1;
                case 'o':
                    croak[1]--;
                    croak[2]++;
                    break;
                case 'a' when croak[2] <= 0:
                    return -1;
                case 'a':
                    croak[2]--;
                    croak[3]++;
                    break;
                case 'k' when croak[3] <= 0:
                    return -1;
                case 'k':
                    croak[3]--;
                    croak[4]++;
                    break;
            }
        }

        if (croak[0] != 0 || croak[1] != 0 || croak[2] != 0 || croak[3] != 0)
        {
            return -1;
        }

        return croak[4];
    }
}
