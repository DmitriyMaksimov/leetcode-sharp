using leetcode_sharp;

namespace UnitTests;

[TestFixture]
public class S00394Tests
{
    [Test]
    public void T1()
    {
        var sut = new S00394();
        sut.DecodeString("3[a]2[bc]").Should().Be("aaabcbc");
    }
    
    [Test]
    public void T2()
    {
        var sut = new S00394();
        sut.DecodeString("3[a2[c]]").Should().Be("accaccacc");
    }

    [Test]
    public void T3()
    {
        var sut = new S00394();
        sut.DecodeString("2[abc]3[cd]ef").Should().Be("abcabccdcdcdef");
    }

}