using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02283Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02283();
        Assert.That(sut.DigitCount("1210"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02283();
        Assert.That(sut.DigitCount("030"), Is.False);
    }
}
