using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03522Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03522();
        Assert.That(sut.CalculateScore(["jump", "add", "add", "jump", "add", "jump"], [2, 1, 3, 1, -2, -3]), Is.EqualTo(1));
    }

    [Test]
    public void T2()
    {
        var sut = new S03522();
        Assert.That(sut.CalculateScore(["jump", "add", "add"], [3, 1, 1]), Is.EqualTo(0));
    }

    [Test]
    public void T3()
    {
        var sut = new S03522();
        Assert.That(sut.CalculateScore(["jump"], [0]), Is.EqualTo(0));
    }
}
