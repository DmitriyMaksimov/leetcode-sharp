using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00292Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00292();
        Assert.That(sut.CanWinNim(4), Is.False);
    }

    [Test]
    public void T2()
    {
        var sut = new S00292();
        Assert.That(sut.CanWinNim(1), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S00292();
        Assert.That(sut.CanWinNim(2), Is.True);
    }

}
