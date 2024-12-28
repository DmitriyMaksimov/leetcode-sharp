using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02957Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02957();
        sut.RemoveAlmostEqualCharacters("aaaaa").Should().Be(2);
    }

    [Test]
    public void T2()
    {
        var sut = new S02957();
        sut.RemoveAlmostEqualCharacters("abddez").Should().Be(2);
    }

    [Test]
    public void T3()
    {
        var sut = new S02957();
        sut.RemoveAlmostEqualCharacters("zyxyxyz").Should().Be(3);
    }
}
