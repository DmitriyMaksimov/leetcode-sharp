using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02396Tests
{
    [Test]
    public void Test1()
    {
        var sut = new S02396();
        sut.IsStrictlyPalindromic(4).Should().BeFalse();
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S02396();
        sut.IsStrictlyPalindromic(9).Should().BeFalse();
    }
}