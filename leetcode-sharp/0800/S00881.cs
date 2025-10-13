namespace leetcode_sharp;

// 881. Boats to Save People
// https://leetcode.com/problems/boats-to-save-people/
public class S00881
{
    public int NumRescueBoats(int[] people, int limit)
    {
        var sortedList = people.Order().ToArray();
        var boats = 0;
        var lightest = 0;
        var heaviest = sortedList.Length - 1;

        while (lightest <= heaviest)
        {
            if (sortedList[lightest] + sortedList[heaviest] <= limit)
            {
                // Both can go
                lightest++;
            }

            // Heaviest can go in any case 
            heaviest--;
            ++boats;
        }
        
        return boats;
    }
}