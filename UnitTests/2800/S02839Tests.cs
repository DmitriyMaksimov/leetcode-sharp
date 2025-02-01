using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02839Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02839();
        Assert.That(sut.CanBeEqual("abcd", "cdab"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S02839();
        Assert.That(sut.CanBeEqual("abcd", "dacb"), Is.False);
    }
}
