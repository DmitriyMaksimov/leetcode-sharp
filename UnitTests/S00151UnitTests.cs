using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00151UnitTests
{
    [Test]
    public void Test1()
    {
        var sut = new S00151();
        sut.ReverseWords("the sky is blue").Should().Be("blue is sky the");
    }
    
    [Test]
    public void Test2()
    {
        var sut = new S00151();
        sut.ReverseWords("  hello world  ").Should().Be("world hello");
    }
    
    [Test]
    public void Test3()
    {
        var sut = new S00151();
        sut.ReverseWords("a good   example").Should().Be("example good a");
    }
}