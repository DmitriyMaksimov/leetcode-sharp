using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02283Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02283();
        sut.DigitCount("1210").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02283();
        sut.DigitCount("030").Should().BeFalse();
    }
}