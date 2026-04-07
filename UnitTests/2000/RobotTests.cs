using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S02069.Robot))]
public class S02069Tests
{
    [Test]
    public void T1()
    {
        var robot = new S02069.Robot(6, 3);
        robot.Step(2); // It moves two steps East to (2, 0), and faces East.
        robot.Step(2); // It moves two steps East to (4, 0), and faces East.
        using var scope = Assert.EnterMultipleScope();
        Assert.That(robot.GetPos(), Is.EqualTo([4, 0])); // return [4, 0]
        Assert.That(robot.GetDir(), Is.EqualTo("East")); // return "East"
        robot.Step(2); // It moves one step East to (5, 0), and faces East.
        // Moving the next step East would be out of bounds, so it turns and faces North.
        // Then, it moves one step North to (5, 1), and faces North.
        robot.Step(1); // It moves one step North to (5, 2), and faces North (not West).
        robot.Step(4); // Moving the next step North would be out of bounds, so it turns and faces West.
        // Then, it moves four steps West to (1, 2), and faces West.
        Assert.That(robot.GetPos(), Is.EqualTo([1, 2])); // return [1, 2]
        Assert.That(robot.GetDir(), Is.EqualTo("West")); // return "West"
    }
}