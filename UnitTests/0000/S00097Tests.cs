using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00097Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00097();
        sut.IsInterleave("aabcc", "dbbca", "aadbbcbcac").Should().BeTrue();
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00097();
        sut.IsInterleave("aabcc", "dbbca", "aadbbbaccc").Should().BeFalse();
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00097();
        sut.IsInterleave("", "", "").Should().BeTrue();
    }

}