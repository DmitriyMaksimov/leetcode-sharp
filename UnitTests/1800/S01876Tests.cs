using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01876Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01876();
        sut.CountGoodSubstrings("xyzzaz").Should().Be(1);
    }

    [Test]
    public void T2()
    {
        var sut = new S01876();
        sut.CountGoodSubstrings("aababcabc").Should().Be(4);
    }
}