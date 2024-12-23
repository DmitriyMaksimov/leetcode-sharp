using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S01297Tests
{
    [Test]
    public void T1()
    {
        var sut = new S01297();
        sut.MaxFreq("aababcaab", 2, 3, 4).Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S01297();
        sut.MaxFreq("aaaa", 1, 3, 3).Should().Be(2);
    }
}
