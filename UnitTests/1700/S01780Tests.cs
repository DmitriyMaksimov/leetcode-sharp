using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01780Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01780();
        Assert.That(sut.CheckPowersOfThree(12), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01780();
        Assert.That(sut.CheckPowersOfThree(91), Is.True);
    }

    [Test]
    public void T3()
    {
        var sut = new S01780();
        Assert.That(sut.CheckPowersOfThree(21), Is.False);
    }
}
