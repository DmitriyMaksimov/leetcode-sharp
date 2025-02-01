using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01417Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01417();
        Assert.That(sut.Reformat("a0b1c2"), Is.EqualTo("0a1b2c"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01417();
        Assert.That(sut.Reformat("leetcode"), Is.EqualTo(""));
    }

    [Test]
    public void T3()
    {
        var sut = new S01417();
        Assert.That(sut.Reformat("1229857369"), Is.EqualTo(""));
    }
}