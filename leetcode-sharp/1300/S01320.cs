namespace leetcode_sharp;

// 1320. Minimum Distance to Type a Word Using Two Fingers
// https://leetcode.com/problems/minimum-distance-to-type-a-word-using-two-fingers
public class S01320
{
    public int MinimumDistance(string word)
    {
        var currentStates = new Dictionary<(int finger1, int finger2), int>
        {
            [(0, 0)] = 0
        };

        foreach (var character in word)
        {
            var targetKeyIndex = character - 'A' + 1;
            var nextStates = new Dictionary<(int finger1, int finger2), int>();

            foreach (var ((finger1Position, finger2Position), currentCost) in currentStates)
            {
                var costUsingFinger1 = currentCost + Distance(finger1Position, targetKeyIndex);
                var state1 = (targetKeyIndex, finger2Position);

                nextStates[state1] = Math.Min(nextStates.GetValueOrDefault(state1, int.MaxValue), costUsingFinger1);

                var costUsingFinger2 = currentCost + Distance(finger2Position, targetKeyIndex);
                var state2 = (finger1Position, targetKeyIndex);

                nextStates[state2] = Math.Min(nextStates.GetValueOrDefault(state2, int.MaxValue), costUsingFinger2);
            }

            currentStates = nextStates;
        }

        return currentStates.Values.Min();
    }

    private static int Distance(int fromKey, int toKey)
    {
        if (fromKey == 0)
        {
            return 0;
        }

        var fromIndex = fromKey - 1;
        var toIndex = toKey - 1;

        return Math.Abs(fromIndex / 6 - toIndex / 6) + Math.Abs(fromIndex % 6 - toIndex % 6);
    }
}