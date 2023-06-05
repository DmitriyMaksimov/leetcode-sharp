using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01232Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01232();
        sut.CheckStraightLine(new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}, new[] {4, 5}, new[] {5, 6}, new[] {6, 7}}).Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01232();
        sut.CheckStraightLine(new[] {new[] {1, 1}, new[] {2, 3}, new[] {3, 4}, new[] {4, 5}, new[] {5, 6}, new[] {7, 7}}).Should().BeFalse();
    }
}