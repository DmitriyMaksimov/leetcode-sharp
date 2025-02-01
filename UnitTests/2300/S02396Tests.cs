using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02396Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S02396();
        Assert.That(sut.IsStrictlyPalindromic(4), Is.False);
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S02396();
        Assert.That(sut.IsStrictlyPalindromic(9), Is.False);
    }
}
