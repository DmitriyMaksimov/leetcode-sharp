using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03232Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03232();
        Assert.That(sut.CanAliceWin([1, 2, 3, 4, 5, 14]), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S03232();
        Assert.That(sut.CanAliceWin([5, 5, 5, 25]), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S03232();
        Assert.That(sut.CanAliceWin([1, 2, 3, 4, 10]), Is.False);
    }
}
