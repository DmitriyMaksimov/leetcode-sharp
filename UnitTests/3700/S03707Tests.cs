using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S03707))]
public class S03707Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03707();
        Assert.That(sut.ScoreBalance("adcb"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03707();
        Assert.That(sut.ScoreBalance("bace"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S03707();
        Assert.That(sut.ScoreBalance("edb"), Is.False);
    }
}