using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S03090Tests
{
    [Test]
    public void T1()
    {
        var sut = new S03090();
        sut.MaximumLengthSubstring("bcbbbcba").Should().Be(4);
    }

    [Test]
    public void T2()
    {
        var sut = new S03090();
        sut.MaximumLengthSubstring("aaaa").Should().Be(2);
    }
}