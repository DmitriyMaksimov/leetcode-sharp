using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02042Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02042();
        Assert.That(sut.AreNumbersAscending("1 box has 3 blue 4 red 6 green and 12 yellow marbles"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02042();
        Assert.That(sut.AreNumbersAscending("hello world 5 x 5"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S02042();
        Assert.That(sut.AreNumbersAscending("sunset is at 7 51 pm overnight lows will be in the low 50 and 60 s"), Is.False);
    }
}
