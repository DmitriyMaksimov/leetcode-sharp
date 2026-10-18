using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S04020))]
public class S04020Tests
{
    [Test]
    public void T1()
    {
        var sut = new S04020();
        Assert.That(sut.ElevatorRequests(5, [2, 1, 4, 3]), Is.EqualTo(7));
    }

    [Test]
    public void T2()
    {
        var sut = new S04020();
        Assert.That(sut.ElevatorRequests(3, [2, 0, 0]), Is.EqualTo(4));
    }
}