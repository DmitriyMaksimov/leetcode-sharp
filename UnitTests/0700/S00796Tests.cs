using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00796Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00796();
        Assert.That(sut.RotateString("abcde", "cdeab"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00796();
        Assert.That(sut.RotateString("abcde", "abced"), Is.False);
    }
}
