namespace leetcode_sharp;

// 1700. Number of Students Unable to Eat Lunch
// https://leetcode.com/problems/number-of-students-unable-to-eat-lunch/
public class S01700
{
    public int CountStudents(int[] students, int[] sandwiches)
    {
        var studentsQueue = new Queue<int>(students);
        var sandwichesQueue = new Queue<int>(sandwiches);
        var count = 0;

        while (studentsQueue.Count > 0 && count < studentsQueue.Count)
        {
            var student = studentsQueue.Dequeue();
            var sandwich = sandwichesQueue.Peek();
        
            if (student == sandwich)
            {
                sandwichesQueue.Dequeue();
                count = 0;
            }
            else
            {
                studentsQueue.Enqueue(student);
                count++;
            }
        }

        return studentsQueue.Count;
    }
}