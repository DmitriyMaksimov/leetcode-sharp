namespace leetcode_sharp;

// 781. Rabbits in Forest
// https://leetcode.com/problems/rabbits-in-forest
public class S00781
{
    public int NumRabbits(int[] answers)
    {
        if (answers.Length == 0)
        {
            return 0;
        }

        Dictionary<int, int> dictionary = [];
        var result = 0;

        foreach (var answer in answers)
        {
            if (answer == 0)
            {
                result++;
            }
            else
            {
                dictionary.TryAdd(answer, 0);

                if (dictionary[answer] == 0)
                {
                    result += answer + 1;
                }

                dictionary[answer]++;

                if (dictionary[answer] == answer + 1)
                {
                    dictionary[answer] = 0;
                }
            }
        }

        return result;
    }
}
