using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03439))]
public class S03439Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03439();
        Assert.That(sut.MaxFreeTime(5, 1, [1, 3], [2, 5]), Is.EqualTo(2));
    }

    [Test]
    public void T2()
    {
        var sut = new S03439();
        Assert.That(sut.MaxFreeTime(10, 1, [0, 2, 9], [1, 4, 10]), Is.EqualTo(6));
    }

    [Test]
    public void T3()
    {
        var sut = new S03439();
        Assert.That(sut.MaxFreeTime(5, 2, [0, 1, 2, 3, 4], [1, 2, 3, 4, 5]), Is.EqualTo(0));
    }
}