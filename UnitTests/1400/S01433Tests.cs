using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01433Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01433();
        Assert.That(sut.CheckIfCanBreak("abc", "xya"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S01433();
        Assert.That(sut.CheckIfCanBreak("abe", "acd"), Is.False);
    }

    [Test]
    public void T3()
    {
        var sut = new S01433();
        Assert.That(sut.CheckIfCanBreak("leetcodee", "interview"), Is.True);
    }
}
