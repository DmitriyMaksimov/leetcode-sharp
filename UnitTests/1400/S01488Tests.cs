using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01488))]
public class S01488Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01488();
        Assert.That(sut.AvoidFlood([1, 2, 3, 4]), Is.EqualTo([-1, -1, -1, -1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S01488();
        Assert.That(sut.AvoidFlood([1, 2, 0, 0, 2, 1]), Is.EqualTo([-1, -1, 2, 1, -1, -1]));
    }

    [Test]
    public void T3()
    {
        var sut = new S01488();
        Assert.That(sut.AvoidFlood([1, 2, 0, 1, 2]), Is.Empty);
    }

    [Test]
    public void T4()
    {
        var sut = new S01488();
        Assert.That(sut.AvoidFlood([0, 1, 1]), Is.Empty);
    }
}