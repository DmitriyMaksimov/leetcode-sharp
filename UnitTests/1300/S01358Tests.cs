using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01358Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01358();
        sut.NumberOfSubstrings("abcabc").Should().Be(10);
    }

    [Test]
    public void T2()
    {
        var sut = new S01358();
        sut.NumberOfSubstrings("aaacb").Should().Be(3);
    }

    [Test]
    public void T3()
    {
        var sut = new S01358();
        sut.NumberOfSubstrings("abc").Should().Be(1);
    }
}
