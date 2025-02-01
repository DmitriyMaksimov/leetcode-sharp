using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02038Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02038();
        Assert.That(sut.WinnerOfGame("AAABABB"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02038();
        Assert.That(sut.WinnerOfGame("AA"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02038();
        Assert.That(sut.WinnerOfGame("ABBBBBBBAAA"), Is.False);
    }

    [Test]
    public void T4()
    {
        var sut = new S02038();
        Assert.That(sut.WinnerOfGame("AAAAABBB"), Is.True);
    }
}
