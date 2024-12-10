using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02981Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02981();
        sut.MaximumLength("aaaa").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02981();
        sut.MaximumLength("abcdef").Should().Be(-1);
    }

    [Test]
    public void T3()
    {
        var sut = new S02981();
        sut.MaximumLength("abcaba").Should().Be(1);
    }
}
