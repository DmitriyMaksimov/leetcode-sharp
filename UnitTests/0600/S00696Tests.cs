using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00696Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00696();
        sut.CountBinarySubstrings("00110011").Should().Be(6);
    }

    [Test]
    public void T2()
    {
        var sut = new S00696();
        sut.CountBinarySubstrings("10101").Should().Be(4);
    }
}