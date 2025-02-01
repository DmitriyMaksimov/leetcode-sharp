using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00097Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00097();
        Assert.That(sut.IsInterleave("aabcc", "dbbca", "aadbbcbcac"), Is.True);
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00097();
        Assert.That(sut.IsInterleave("aabcc", "dbbca", "aadbbbaccc"), Is.False);
    }
    
    [Test]
    public void T3()
    {
        var sut = new S00097();
        Assert.That(sut.IsInterleave("", "", ""), Is.True);
    }

}
