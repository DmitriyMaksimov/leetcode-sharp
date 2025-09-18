using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03408))]
public class S03408Tests
{
    [Test]
    public void T1()
    {
        var taskManager = new S03408.TaskManager([[1, 101, 10], [2, 102, 20], [3, 103, 15]]); // Initializes with three tasks for Users 1, 2, and 3.
        taskManager.Add(4, 104, 5); // Adds task 104 with priority 5 for User 4.
        taskManager.Edit(102, 8); // Updates priority of task 102 to 8.
        Assert.That(taskManager.ExecTop(), Is.EqualTo(3)); // return 3. Executes task 103 for User 3.
        taskManager.Rmv(101); // Removes task 101 from the system.
        taskManager.Add(5, 105, 15); // Adds task 105 with priority 15 for User 5.
        Assert.That(taskManager.ExecTop(), Is.EqualTo(5)); // return 5. Executes task 105 for User 5.
    }
}