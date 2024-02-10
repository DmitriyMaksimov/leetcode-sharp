using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00647Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00647();
        sut.CountSubstrings("abc").Should().Be(3);
    }

    [Test]
    public void T2()
    {
        var sut = new S00647();
        sut.CountSubstrings("aaa").Should().Be(6);
    }
}