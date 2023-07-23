namespace leetcode_sharp;

// 946. Validate Stack Sequences
// https://leetcode.com/problems/validate-stack-sequences/
public class S00946
{
    public bool ValidateStackSequences(int[] pushed, int[] popped)
    {
        var pushedIndex = 0;
        var poppedIndex = 0;

        foreach (var val in pushed)
        {
            pushed[pushedIndex++] = val;
            while (pushedIndex > 0 && pushed[pushedIndex - 1] == popped[poppedIndex])
            {
                pushedIndex--;
                poppedIndex++;
            }
        }

        return pushedIndex == 0;
    }
}