using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02068Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02068();
        sut.CheckAlmostEquivalent("aaaa", "bccb").Should().BeFalse();
    }

    [Test]
    public void T2()
    {
        var sut = new S02068();
        sut.CheckAlmostEquivalent("abcdeef", "abaaacc").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S02068();
        sut.CheckAlmostEquivalent("cccddabba", "babababab").Should().BeTrue();
    }
}