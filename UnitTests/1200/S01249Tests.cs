using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01249Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01249();
        Assert.That(sut.MinRemoveToMakeValid("lee(t(c)o)de)"), Is.EqualTo("lee(t(c)o)de"));
    }

    [Test]
    public void T2()
    {
        var sut = new S01249();
        Assert.That(sut.MinRemoveToMakeValid("a)b(c)d"), Is.EqualTo("ab(c)d"));
    }

    [Test]
    public void T3()
    {
        var sut = new S01249();
        Assert.That(sut.MinRemoveToMakeValid("))(("), Is.EqualTo(""));
    }
}