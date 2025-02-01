using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01844Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01844();
        Assert.That(sut.ReplaceDigits("a1c1e1"), Is.EqualTo("abcdef"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01844();
        Assert.That(sut.ReplaceDigits("a1b2c3d4e"), Is.EqualTo("abbdcfdhe"));
    }
}