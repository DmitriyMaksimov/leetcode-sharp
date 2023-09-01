namespace leetcode_sharp;

// 551. Student Attendance Record I
// https://leetcode.com/problems/student-attendance-record-i/
public class S00551
{
    public bool CheckRecord(string s)
    {
        var absent = 0;
        var late = 0;
        foreach (var c in s)
        {
            switch (c)
            {
                case 'A':
                    absent++;
                    late = 0;
                    break;
                case 'L':
                    late++;
                    break;
                default:
                    late = 0;
                    break;
            }

            if (absent > 1 || late > 2)
            {
                return false;
            }
        }

        return true;
    }
}