using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01626Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01626();
        Assert.That(sut.BestTeamScore([1, 3, 5, 10, 15], [1, 2, 3, 4, 5]), Is.EqualTo(34));
    }

    [Test]
    public void T2()
    {
        var sut = new S01626();
        Assert.That(sut.BestTeamScore([4, 5, 6, 5], [2, 1, 2, 1]), Is.EqualTo(16));
    }

    [Test]
    public void T3()
    {
        var sut = new S01626();
        Assert.That(sut.BestTeamScore([1, 2, 3, 5], [8, 9, 10, 1]), Is.EqualTo(6));
    }
}