namespace leetcode_sharp;

// 1010. Pairs of Songs With Total Durations Divisible by 60
// https://leetcode.com/problems/pairs-of-songs-with-total-durations-divisible-by-60
public class S01010
{
    public int NumPairsDivisibleBy60(int[] time)
    {
        var dictionary = new Dictionary<int, int>();
        var result = 0;

        foreach (var t in time)
        {
            var timeReminder = t % 60;
            var requiredReminder = timeReminder == 0 ? 0 : 60 - timeReminder;

            if (dictionary.TryGetValue(requiredReminder, out var value))
            {
                result += value;
            }

            dictionary[timeReminder] = dictionary.GetValueOrDefault(timeReminder) + 1;
        }

        return result;
    }
}
