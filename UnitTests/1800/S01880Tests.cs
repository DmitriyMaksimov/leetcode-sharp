using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01880Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01880();
        sut.IsSumEqual("acb", "cba", "cdb").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S01880();
        sut.IsSumEqual("aaa", "a", "aab").Should().BeFalse();
    }

    [Test]
    public void T3()
    {
        var sut = new S01880();
        sut.IsSumEqual("aaa", "a", "aaaa").Should().BeTrue();
    }
}