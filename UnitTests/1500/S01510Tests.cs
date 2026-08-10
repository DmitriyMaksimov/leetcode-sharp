using leetcode_sharp;

namespace UnitTests;

[TestFixture]
[TestOf(typeof(S01510))]
public class S01510Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01510();
        Assert.That(sut.WinnerSquareGame(1), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01510();
        Assert.That(sut.WinnerSquareGame(2), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01510();
        Assert.That(sut.WinnerSquareGame(4), Is.True);
    }
}