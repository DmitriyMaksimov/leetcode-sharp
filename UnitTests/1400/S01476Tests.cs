using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01476Tests
{
    [Test]
    public void T1()
    {
        var subrectangleQueries = new S01476.SubrectangleQueries(new[] {new[] {1, 2, 1}, new[] {4, 3, 4}, new[] {3, 2, 1}, new[] {1, 1, 1}});
        // The initial rectangle (4x3) looks like:
        // 1 2 1
        // 4 3 4
        // 3 2 1
        // 1 1 1
        Assert.That(subrectangleQueries.GetValue(0, 2), Is.EqualTo(1));
        subrectangleQueries.UpdateSubrectangle(0, 0, 3, 2, 5);
        // After this update the rectangle looks like:
        // 5 5 5
        // 5 5 5
        // 5 5 5
        // 5 5 5 
        Assert.That(subrectangleQueries.GetValue(0, 2), Is.EqualTo(5));
        Assert.That(subrectangleQueries.GetValue(3, 1), Is.EqualTo(5));
        subrectangleQueries.UpdateSubrectangle(3, 0, 3, 2, 10);
        // After this update the rectangle looks like:
        // 5   5   5
        // 5   5   5
        // 5   5   5
        // 10  10  10 
        Assert.That(subrectangleQueries.GetValue(3, 1), Is.EqualTo(10)); // return 10
        Assert.That(subrectangleQueries.GetValue(0, 2), Is.EqualTo(5)); // return 5
    }
}