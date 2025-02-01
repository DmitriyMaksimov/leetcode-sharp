using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01025Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01025();
        Assert.That(sut.DivisorGame(2), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01025();
        Assert.That(sut.DivisorGame(3), Is.False);
    }
}
