using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00521Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00521();
        sut.FindLUSlength("aba", "cdc").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00521();
        sut.FindLUSlength("aaa", "bbb").Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S00521();
        sut.FindLUSlength("aaa", "aaa").Should().Be(-1);
    }
}