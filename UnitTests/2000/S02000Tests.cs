using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02000Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02000();
        sut.ReversePrefix("abcdefd", 'd').Should().Be("dcbaefd");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02000();
        sut.ReversePrefix("xyxzxe", 'z').Should().Be("zxyxxe");
    }

    [Test]
    public void T3()
    {
        var sut = new S02000();
        sut.ReversePrefix("abcd", 'z').Should().Be("abcd");
    }
}