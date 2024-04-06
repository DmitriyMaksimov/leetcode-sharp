using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01249Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01249();
        sut.MinRemoveToMakeValid("lee(t(c)o)de)").Should().Be("lee(t(c)o)de");
    }

    [Test]
    public void T2()
    {
        var sut = new S01249();
        sut.MinRemoveToMakeValid("a)b(c)d").Should().Be("ab(c)d");
    }

    [Test]
    public void T3()
    {
        var sut = new S01249();
        sut.MinRemoveToMakeValid("))((").Should().Be("");
    }
}