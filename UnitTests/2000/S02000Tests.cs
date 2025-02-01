using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S02000Tests
{
    [Test]
    public void T1()
    {
        var sut = new S02000();
        Assert.That(sut.ReversePrefix("abcdefd", 'd'), Is.EqualTo("dcbaefd"));
    }
    
    [Test]
    public void T2()
    {
        var sut = new S02000();
        Assert.That(sut.ReversePrefix("xyxzxe", 'z'), Is.EqualTo("zxyxxe"));
    }

    [Test]
    public void T3()
    {
        var sut = new S02000();
        Assert.That(sut.ReversePrefix("abcd", 'z'), Is.EqualTo("abcd"));
    }
}