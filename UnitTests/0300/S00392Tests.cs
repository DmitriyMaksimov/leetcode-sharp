using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00392Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00392();
        Assert.That(sut.IsSubsequence("abc", "ahbgdc"), Is.True);
    }

    [Test]
    public void T2()
    {
        var sut = new S00392();
        Assert.That(sut.IsSubsequence("axc", "ahbgdc"), Is.False);
    }
}
