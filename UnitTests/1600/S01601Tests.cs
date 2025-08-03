using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01601Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01601();
        Assert.That(sut.MaximumRequests(5,
            [[0, 1], [1, 0], [0, 1], [1, 2], [2, 0], [3, 4]]), Is.EqualTo(5));
    }

    [Test]
    public void T2()
    {
        var sut = new S01601();
        Assert.That(sut.MaximumRequests(3, [[0, 0], [1, 2], [2, 1]]), Is.EqualTo(3));
    }

    [Test]
    public void T3()
    {
        var sut = new S01601();
        Assert.That(sut.MaximumRequests(4, [[0, 3], [3, 1], [1, 2], [2, 0]]), Is.EqualTo(4));
    }
}