using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02825Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02825();
        sut.CanMakeSubsequence("abc", "ad").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S02825();
        sut.CanMakeSubsequence("zc", "ad").Should().BeTrue();
    }

    [Test]
    public void T3()
    {
        var sut = new S02825();
        sut.CanMakeSubsequence("ab", "d").Should().BeFalse();
    }
}
