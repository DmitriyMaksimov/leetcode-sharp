using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03921))]
public class S03921Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03921();
        Assert.That(sut.ScoreValidator(["1", "4", "W", "6", "WD"]), Is.EqualTo([12, 1]));
    }

    [Test]
    public void T2()
    {
        var sut = new S03921();
        Assert.That(sut.ScoreValidator(["WD", "NB", "0", "4", "4"]), Is.EqualTo([10, 0]));
    }

    [Test]
    public void T3()
    {
        var sut = new S03921();
        Assert.That(sut.ScoreValidator(["W", "W", "W", "W", "W", "W", "W", "W", "W", "W", "W"]), Is.EqualTo([0, 10]));
    }
}