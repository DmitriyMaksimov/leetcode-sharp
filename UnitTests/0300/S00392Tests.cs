using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00392Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00392();
        sut.IsSubsequence("abc", "ahbgdc").Should().BeTrue();
    }

    [Test]
    public void T2()
    {
        var sut = new S00392();
        sut.IsSubsequence("axc", "ahbgdc").Should().BeFalse();
    }
}