namespace leetcode_sharp;

// 672. Bulb Switcher II
// https://leetcode.com/problems/bulb-switcher-ii
public class S00672
{
    public int FlipLights(int n, int presses)
    {
        if (presses == 0)
        {
            return 1;
        }

        if (n <= 0 || presses < 0)
        {
            return 0;
        }

        return n switch
        {
            1 => 2,
            2 => presses == 1 ? 3 : 4,
            _ => presses switch
            {
                1 => 4,
                2 => 7,
                _ => 8
            }
        };
    }
}
